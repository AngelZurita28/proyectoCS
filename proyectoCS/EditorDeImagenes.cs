using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace proyectoCS

{
    public partial class EditorDeImagenes : Form
    {

        public EditorDeImagenes()
        {
            InitializeComponent();
        }
        Image file;
        Boolean opened = false;
        void openImage()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
                MostrarImagen(openFileDialog1.FileName);
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
                opened = true;
                pbGuardar.Visible = true;
            }
        }
        private void MostrarImagen(string s)
        {
            try
            {
                Bitmap NewBMP;
                Graphics graphicTemp;
                Bitmap bmp = new Bitmap(s);

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
        private void MostrarImagen(Bitmap bmp)
        {
            try
            {
                Bitmap NewBMP;
                Graphics graphicTemp;
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
        void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else { MessageBox.Show("No se ha seleccionado ninguna imagen, agregela desde el apartado >editor de imagenes>seleccionar arrchivo"); }
        }
        void grayscale()
        {
            if (!opened)
            {
                MessageBox.Show("Abre una imagen y aplica los cambios");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);
            }
        }
        void flash()
        {
            if (!opened)
            {
                MessageBox.Show("Abre una imagen y aplica los cambios");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
            new float[]{0, 1+1.5f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);

            }
        }
        void redscale()
        {
            if (!opened)
            {
                MessageBox.Show("Abre una imagen y aplica los cambios");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);

            }
        }
        void filter1()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
                    new float[]{.769f, .686f+0.5f, .534f, 0, 0},
                    new float[]{.189f+2.3f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);

            }
        }
        void filter2()
        {
            if (!opened)
            {
                MessageBox.Show("Abre una imagen y aplica los cambios");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);

            }
        }
        void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f+0.2f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.9f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);

            }
        }
        void Winter()
        {
            if (!opened)
            {
                MessageBox.Show("Abre una imagen y aplica los cambios");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);

            }
        }
        void reload()
        {
            if (!opened)
            {

            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    MostrarImagen(openFileDialog1.FileName);
                    opened = true;
                }

            }
        }
        void Frozen()
        {

            if (!opened)
            {
                MessageBox.Show("Abre una imagen y aplica los cambios");
            }
            else
            {


                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0f, 0, 0, 0},
                    new float[]{0, 0, 1+5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();

            }

        }
        void fog()
        {

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {


                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0.7f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);
            }
        }
        void hue()
        {
            float changered = trackBar1.Value * 0.1f;
            float changegreen = trackBar2.Value * 0.1f;
            float changeblue = trackBar3.Value * 0.1f;
            reload();
            if (!opened)
            {
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+changered, 0, 0, 0, 0},
                    new float[]{0, 1+changegreen, 0, 0, 0},
                    new float[]{0, 0, 1+changeblue, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                //pictureBox1.Image = bmpInverted;
                MostrarImagen(bmpInverted);

            }
        }
        private void btnGray_Click(object sender, EventArgs e)
        {
            reload();
            grayscale();
        }
        private void btnSepia_Click(object sender, EventArgs e)
        {
            reload();
            redscale();
        }
        private void btnFrozen_Click_1(object sender, EventArgs e)
        {
            reload();
            Winter();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            saveImage();
        }
        private void redbar_Scroll_1(object sender, EventArgs e)
        {
            hue();
        }
        private void greenbar_Scroll(object sender, EventArgs e)
        {
            hue();
        }
        private void bluebar_Scroll(object sender, EventArgs e)
        {
            hue();
        }
        private void btnNone_Click(object sender, EventArgs e)
        {
            trackBar2.Value = 0;
            trackBar1.Value = 0;
            trackBar3.Value = 0;
            reload();
        }
        private void btnArtistic_Click(object sender, EventArgs e)
        {
            reload();
            Winter();
        }
        private void btnSpike_Click(object sender, EventArgs e)
        {
            reload();
            fog();
        }
        private void btnFlash_Click(object sender, EventArgs e)
        {
            reload();
            flash();
        }
        private void btnFrozen_Click(object sender, EventArgs e)
        {
            reload();
            Frozen();
        }
        private void btnSuji_Click(object sender, EventArgs e)
        {
            reload();
            filter2();
        }
        private void btnDramatic_Click(object sender, EventArgs e)
        {
            reload();
            filter3();
        }
        private void btnKakao_Click(object sender, EventArgs e)
        {
            reload();
            filter1();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            hue();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            hue();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            hue();
        }
        private void pbAbrir_Click(object sender, EventArgs e)
        {
            openImage();
        }
        private void pbGuardar_Click(object sender, EventArgs e)
        {
            saveImage();
        }
    }

}
