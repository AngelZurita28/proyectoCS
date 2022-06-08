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
using SautinSoft.Document;
using Aspose.Words;

namespace proyectoCS

{
    public partial class Doc : Form
    {
        public Doc()
        {
            InitializeComponent();
        }
        private void pbAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog exploradorArchivo = new OpenFileDialog();
            exploradorArchivo.Filter = "Word Document|*.Docx|" +
                " Word 97-2003 Document|*.doc| Texto|*.txt;*.cs;*."; 
            {
                if (exploradorArchivo.ShowDialog() == DialogResult.OK)
                {
                    if (exploradorArchivo.FileName.EndsWith(".txt") || exploradorArchivo.FileName.EndsWith(".cs"))
                    {
                        richTextWord.Clear();
                        StreamReader lector = new StreamReader(exploradorArchivo.FileName);
                        richTextWord.Text = lector.ReadToEnd();
                        lector.Close();
                    }
                    else
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
        }
        private void pbGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word | *.docx; | Txt|*.txt; | CS | *.cs;";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith("docx"))
                {
                    //File.Delete(@"C:\Users\Hector Peña\Desktop\PROYECTO\musica\Carpeta Organizada\Testdoc.rtf");
                    richTextWord.SaveFile(Environment.CurrentDirectory + @"\Testdoc.rtf");
                    var newdoc = new Document(Environment.CurrentDirectory + @"\Testdoc.rtf");
                    newdoc.Save(saveFileDialog.FileName);
                }
                else
                {
                    StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                    sw.Write(richTextWord.Text);
                }
            }
        }
    }
}
