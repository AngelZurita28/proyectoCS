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
    public partial class Documentos : Form
    {
        public Documentos()
        {
            InitializeComponent();
        }
        private void pbAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog exploradorArchivo = new OpenFileDialog() { Filter = "Word Document|*.Docx| Word 97-2003 Document|*.doc" })
            {
                if (exploradorArchivo.ShowDialog() == DialogResult.OK)
                {
                    txtArchivo.Text = exploradorArchivo.FileName;
                    try
                    {
                        object readOnly = true;
                        object visible = true;
                        object save = false;
                        object fileName = exploradorArchivo.FileName;
                        object missing = Type.Missing;
                        object newTemplate = false;
                        object docType = 0;

                        Microsoft.Office.Interop.Word._Document documento = null;
                        Microsoft.Office.Interop.Word._Application aplicacionWord = new Microsoft.Office.Interop.Word.Application()
                        { Visible = false };

                        documento = aplicacionWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing,
                            ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref visible,
                            ref missing, ref missing, ref missing, ref missing);

                        documento.ActiveWindow.Selection.WholeStory();
                        documento.ActiveWindow.Selection.Copy();
                        IDataObject contenidoWord = Clipboard.GetDataObject();
                        richTextWord.Rtf = contenidoWord.GetData(DataFormats.Rtf).ToString();
                        aplicacionWord.Quit(ref missing, ref missing, ref missing);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        private void pbGuardar_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de texto |*.txt";
            guardar.Title = "Guardar richTextWord";
            guardar.FileName = "Sin titulo 1";
            //var resultado = guardar.ShowDialog();
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);

                foreach (object line in richTextWord.Lines)
                {
                    escribir.WriteLine(line);
                }

            }
            
        }

        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
