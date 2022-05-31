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

    public partial class VisualizadorDeImagenes : Form
    {
        bool toggle = true;
        bool toggletimer = true;
        bool toggleBtns = true;
        List<string> listaimagenes = new List<string>();
        public VisualizadorDeImagenes()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }


        //METODOS DE EVENTOS
        private void Imagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Focus();
            if (toggle)
            {
                btnAnterior.Location = new Point(145, 41 + pictureBox1.Height - btnAnterior.Height);
                btnSiguiente.Location = new Point(145 + pictureBox1.Width - btnSiguiente.Width, 41 + pictureBox1.Height - btnSiguiente.Height);
            }
            else
            {
                Screen currentscreen = Screen.FromHandle(this.Handle);
                btnAnterior.Location = new Point(currentscreen.Bounds.Width / 2 - 10 - btnPlay.Width / 2 - btnAnterior.Width, currentscreen.Bounds.Height - btnAnterior.Height - 5);
                btnPlay.Location = new Point(currentscreen.Bounds.Width / 2 - 5 - btnPlay.Width / 2, currentscreen.Bounds.Height - btnPlay.Height - 5);
                btnSiguiente.Location = new Point(currentscreen.Bounds.Width / 2 + btnPlay.Width / 2, currentscreen.Bounds.Height - btnSiguiente.Height - 5);
            }

            if (this.Width < 639)
            {

                this.Width = 639;
            }
            else
                MostrarImagen(Imagenes.SelectedIndex);
            if (this.Height < 350)
                this.Height = 350;
            else
                MostrarImagen(Imagenes.SelectedIndex);
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs eventArgs)
        { Minimizar(); }
        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                LlenarLista(di);
                Imagenes.SelectedIndex = 0;
            }
        }
        private void btnArchivos_Click(object sender, EventArgs e)
        {
            string[] archivos, rutas;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes | *.png; *.jpg; *.jpeg";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutas = openFileDialog.FileNames;
                archivos = openFileDialog.SafeFileNames;
                for (int i = 0; i < archivos.Length; i++)
                {
                    listaimagenes.Add(rutas[i]);
                    Imagenes.Items.Add(archivos[i]);
                }
                Imagenes.SelectedIndex = 0;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        { Play(); }
        private void btnSiguiente_Click(object sender, EventArgs e)
        { Siguiente(); }
        private void btnAnterior_Click(object sender, EventArgs e)
        { Anterior(); }
        private void timer1_Tick(object sender, EventArgs e)
        { Siguiente(); }


        //FUNCIONES
        private void LlenarLista(DirectoryInfo di)
        {
            foreach (FileInfo fi in di.GetFiles())
            {
                string nombre = fi.Name.ToLower();
                if (nombre.EndsWith("jpg") || nombre.EndsWith("png") || nombre.EndsWith("jpeg"))
                {
                    if (listaimagenes.Contains(fi.FullName))
                    { }
                    else
                    {
                        listaimagenes.Add(fi.FullName);
                        Imagenes.Items.Add(fi.Name);
                    }

                }
            }
        }
        private void MostrarImagen(int i)
        {
            try
            {
                Bitmap NewBMP;
                Graphics graphicTemp;
                Bitmap bmp = new Bitmap(listaimagenes[i]);

                int iWidth;
                int iHeight;
                int FinalWidth = pictureBox1.Width;
                int FinalHeight = pictureBox1.Height;

                if (FinalHeight >= FinalWidth)
                { FinalHeight = 0; }
                else
                { FinalWidth = 0; }

                if ((FinalHeight == 0) && (FinalWidth != 0))
                {
                    iWidth = FinalWidth;
                    iHeight = (bmp.Size.Height * iWidth / bmp.Size.Width);
                }
                else if ((FinalHeight != 0) && (FinalWidth == 0))
                {
                    iHeight = FinalHeight;
                    iWidth = (bmp.Size.Width * iHeight / bmp.Size.Height);
                }
                else
                {
                    iWidth = FinalWidth;
                    iHeight = FinalHeight;
                }
                NewBMP = new Bitmap(256, 256);
                try
                { NewBMP = new System.Drawing.Bitmap(iWidth, iHeight); }
                catch (Exception)
                { }
                graphicTemp = Graphics.FromImage(NewBMP);
                graphicTemp.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                graphicTemp.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphicTemp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphicTemp.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphicTemp.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                graphicTemp.DrawImage(bmp, 0, 0, iWidth, iHeight);
                graphicTemp.Dispose();
                System.Drawing.Imaging.EncoderParameters encoderParams = new System.Drawing.Imaging.EncoderParameters();
                System.Drawing.Imaging.EncoderParameter encoderParam = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 0);
                encoderParams.Param[0] = encoderParam;
                System.Drawing.Imaging.ImageCodecInfo[] arrayICI = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();
                pictureBox1.Image = NewBMP;
            }
            catch (Exception)
            { }
        }
        private void Anterior()
        {
            if (listaimagenes.Count > 0)
            {
                int count = Imagenes.SelectedIndex;
                if (count == 0)
                    count = Imagenes.Items.Count - 1;
                else
                    count = count - 1;

                Imagenes.SelectedIndex = count;
            }

        }
        private void Siguiente()
        {
            if (listaimagenes.Count > 0)
            {
                pictureBox1.Focus();
                int count = Imagenes.SelectedIndex;

                if (count <= listaimagenes.Count)
                {
                    count++;

                    if (count == listaimagenes.Count)
                        count = 0;
                }

                Imagenes.SelectedIndex = count;
            }

        }

        private void Minimizar()
        {
            if (toggle)
            {
                Screen currentscreen = Screen.FromHandle(this.Handle);
                btnCarpeta.Hide();
                btnArchivos.Hide();
                Imagenes.Hide();
                label1.Hide();
                label2.Hide();
                pictureBox1.BackColor = Color.Black;
                pictureBox1.Dock = DockStyle.Fill;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                btnAnterior.Location = new Point(currentscreen.Bounds.Width / 2 - 10 - btnPlay.Width / 2 - btnAnterior.Width, currentscreen.Bounds.Height - btnAnterior.Height - 5);
                btnPlay.Location = new Point(currentscreen.Bounds.Width / 2 - 5 - btnPlay.Width / 2, currentscreen.Bounds.Height - btnPlay.Height - 5);
                btnSiguiente.Location = new Point(currentscreen.Bounds.Width / 2 + btnPlay.Width / 2, currentscreen.Bounds.Height - btnSiguiente.Height - 5);

            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                btnCarpeta.Show();
                btnArchivos.Show();
                Imagenes.Show();
                label1.Show();
                label2.Show();
                pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
                pictureBox1.Size = new Size(468, 323);
                pictureBox1.Location = new Point(145, 41);
                pictureBox1.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
                btnAnterior.Location = new Point(145, 41 + pictureBox1.Height - btnAnterior.Height);
                btnSiguiente.Location = new Point(145 + pictureBox1.Width - btnSiguiente.Width, 41 + pictureBox1.Height - btnSiguiente.Height);
            }
            toggle = !toggle;
            toggleBtns = !toggleBtns;
        }

        private void Play()
        {
            if (toggletimer)
            {
                btnPlay.Text = "Pause";
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                btnPlay.Text = "Play";
            }
            toggletimer = !toggletimer;
        }
        private void Tecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Minimizar();
            if (e.KeyCode == Keys.Space)
                Play();
            if (e.KeyCode == Keys.A)
                Anterior();
            if (e.KeyCode == Keys.D)
                Siguiente();
        }
    }
}
