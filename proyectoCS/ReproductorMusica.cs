using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace proyectoCS
{
    public partial class ReproductorMusica : Form
    {
        public ReproductorMusica()
        {
            InitializeComponent();
            trackList.Hide();
            this.Height = 136;
        }
        string[] rutas, archivos;
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            trackList.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio|*.mp3;*.wmv;*.wav;*.flac;*.m4a;";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivos = openFileDialog.SafeFileNames;
                rutas = openFileDialog.FileNames;
                foreach (string s in archivos)
                {
                    trackList.Items.Add(s);
                }
 
            }
            vlcControl1.Audio.Volume = 50;
        }

        bool togglePL = true;
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (togglePL)
            {
                this.Height = this.Height + trackList.Height + 20;
                trackList.Show();
            }
            else
            {
                this.Height = 136;
                trackList.Hide();
            }
            togglePL = !togglePL;
        }
        private void btnAleatorio_Click(object sender, EventArgs e)
        { aleatorio(); }
        private void btnPause_Click(object sender, EventArgs e)
        { vlcControl1.Pause(); }
        private void btnAnterior_Click(object sender, EventArgs e)
        { anterior(); }
        private void btnSiguiente_Click(object sender, EventArgs e)
        { siguiente(); }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(rutas[trackList.SelectedIndex]));

            TagLib.File file = TagLib.File.Create(rutas[trackList.SelectedIndex]);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                pbAlbum.Image = bm;
                pbAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                // set "no cover" image
            }
            timer1.Start();
        }
        private void siguiente()
        {
            if (trackList.Items.Count > 0)
            {
                if (trackList.SelectedIndex < trackList.Items.Count - 1)
                {
                    trackList.SelectedIndex = trackList.SelectedIndex + 1;
                }
            }
        }
        private void anterior()
        {
            if (trackList.SelectedIndex > 0)
            { trackList.SelectedIndex = trackList.SelectedIndex - 1; }

        }
        private void sbTiempo_Scroll(object sender, ScrollEventArgs e)
        { vlcControl1.Time = sbTiempo.Value * 1000; }

        private void sbVolumen_Scroll(object sender, ScrollEventArgs e)
        {
            int nuevoValor = sbVolumen.Value;
            vlcControl1.Audio.Volume = nuevoValor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                sbTiempo.Maximum = (int)vlcControl1.Length / 1000;
                sbTiempo.Value = (int)vlcControl1.Time / 1000;
            }

            TimeSpan t = TimeSpan.FromMilliseconds(vlcControl1.Time);
            string time = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
            lbTime.Text = time;
            TimeSpan t2 = TimeSpan.FromMilliseconds(vlcControl1.Length);
            string totalTime = string.Format("{0:D2}:{1:D2}", t2.Minutes, t2.Seconds);
            lbTotalTime.Text = totalTime;
            if (sbTiempo.Value >= sbTiempo.Maximum - 2)
            { siguiente(); }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            var tfile = TagLib.File.Create(rutas[trackList.SelectedIndex]);

            foreach (string s in tfile.Tag.Performers)
            {
                MessageBox.Show(s);
            }
        }

        private void pbAlbum_Click(object sender, EventArgs e)
        {

        }
    private void aleatorio()
        {
            trackList.Items.Clear();
            Random rand1 = new Random();
            try
            { rutas = rutas.OrderBy(x => rand1.Next()).ToArray(); }
            catch (Exception)
            { }

            for (int y = 0; y < rutas.Length; y++)
            {
                archivos[y] = Path.GetFileName(rutas[y]);
                trackList.Items.Add(archivos[y]);
            }
        }
        private void librarySetVlc()
        { this.vlcControl1.VlcLibDirectory = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "libvlc\\win-x86")); }
    }
}
