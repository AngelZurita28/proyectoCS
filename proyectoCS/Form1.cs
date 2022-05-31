using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imagenesPB_Click(object sender, EventArgs e)
        {
            Form VisualizadorDeImagenes = new VisualizadorDeImagenes();
            VisualizadorDeImagenes.Show();
        }

        private void videosPB_Click(object sender, EventArgs e)
        {
            Form rm = new reproductordevideo();
            rm.Show();
        }

        private void musicaPB_Click(object sender, EventArgs e)
        {
            Form mus = new ReproductorMusica();
            mus.Show();
        }

        private void documentosPB_Click(object sender, EventArgs e)
        {
            //Form doc = new ();
            //.Show();
        }

        private void ordenadorPB_Click(object sender, EventArgs e)
        {
            Form organizadordearchivos = new Organizador();
            organizadordearchivos.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form editor = new EditorDeImagenes();
            editor.Show();
        }
    }
}
