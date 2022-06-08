using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyectoCS
{
    public partial class reproductordevideo : Form
    {
        int minimumWidth;
        public reproductordevideo()
        {
            InitializeComponent();
            CambiarTamano();
            minimumWidth = sbVolumen.Width + label2.Width * 2 + btnPause.Width + 20;
        }

        private void reproductorDeVideo_SizeChanged(object sender, EventArgs eventArgs)
        {
            if (this.Width > minimumWidth)
            { CambiarTamano(); }
            else
            { TamanoMinimo(); }

        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Videos | *.mp4; *.mov; *.wmv; *.avi; *.mkv;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { vlcControl1.Play(new Uri(openFileDialog.FileName)); }
            timer1.Start();
            vlcControl1.Audio.Volume = 50;
            sbVolumen.Value = 50;
        }

        private void btnPause_Click(object sender, EventArgs e)
        { vlcControl1.Pause(); }

        private void sbTiempo_Scroll(object sender, ScrollEventArgs e)
        { vlcControl1.Time = sbTiempo.Value * 1000; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                sbTiempo.Maximum = (int)vlcControl1.Length / 1000;
                sbTiempo.Value = (int)vlcControl1.Time / 1000;
            }

            TimeSpan t = TimeSpan.FromMilliseconds(vlcControl1.Time);
            string time = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
            label1.Text = time;
            TimeSpan t2 = TimeSpan.FromMilliseconds(vlcControl1.Length);
            string totalTime = string.Format("{0:D2}:{1:D2}", t2.Minutes, t2.Seconds);
            label2.Text = totalTime;

        }
        private void sbVolumen_Scroll(object sender, ScrollEventArgs e)
        {
            int nuevoValor = sbVolumen.Value;
            vlcControl1.Audio.Volume = nuevoValor;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            maximizar();
        }


        //PROPIEDADES
        private void CambiarTamano()
        {
            vlcControl1.Height = vlcControl1.Width / 16 * 9;
            btnAbrir.Location = new Point(0, vlcControl1.Height - 23);
            label1.Location = new Point(0, vlcControl1.Height);
            label2.Location = new Point(vlcControl1.Width - label2.Width, vlcControl1.Height);
            sbTiempo.Width = vlcControl1.Width - label2.Width * 2;
            sbTiempo.Location = new Point(label1.Width, vlcControl1.Height);
            sbVolumen.Location = new Point(label1.Width, vlcControl1.Height + sbTiempo.Height + 2);
            btnPause.Location = new Point(vlcControl1.Width - label2.Width - btnPause.Width, vlcControl1.Height + sbTiempo.Height);
            btnMaximizar.Location = new Point(vlcControl1.Width - btnMaximizar.Width, vlcControl1.Height - 23);
            this.Height = vlcControl1.Height + 80;

            if (vlcControl1.Video.FullScreen)
            {
                sbTiempo.Width = this.Width - btnAbrir.Width * 3 - 30 - sbVolumen.Width;
                sbTiempo.Location = new Point(btnAbrir.Width + btnPause.Width + 10, vlcControl1.Height - 20);
                btnPause.Location = new Point(btnAbrir.Width + 5, vlcControl1.Height - 23);
                sbVolumen.Location = new Point(btnAbrir.Width + btnPause.Width + sbTiempo.Width + 20, vlcControl1.Height - 20);
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                vlcControl1.Video.FullScreen = false;
                maximizar();
            }
        }
        private void TamanoMinimo()
        {
            this.Width = minimumWidth;
            this.Height = vlcControl1.Height + 80;
        }
        private void maximizar()
        {
            if (!vlcControl1.Video.FullScreen)
            {
                this.Dock = DockStyle.Fill;
                //this.WindowState = FormWindowState.Maximized;
                vlcControl1.Video.FullScreen = true;
                FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(0, 0);
                this.TopMost = true;
                Screen currentScreen = Screen.FromHandle(this.Handle);
                this.Size = new Size(currentScreen.Bounds.Width, currentScreen.Bounds.Height);

            }
            else
            {
                this.Size = new Size(820, 261);
                this.CenterToScreen();
                this.TopMost = false;
                this.Dock = DockStyle.None;
                this.WindowState = FormWindowState.Normal;
                vlcControl1.Video.FullScreen = false;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void form_closing(object sender, FormClosingEventArgs eventArgs)
        { }
        private void librarySetVlc()
        { this.vlcControl1.VlcLibDirectory = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "libvlc\\win-x86")); }
    }
}