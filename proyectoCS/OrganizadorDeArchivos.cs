using System;
using System.Collections;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;

namespace proyectoCS
{

    public partial class Organizador : Form
    {
        public Organizador()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
        DirectoryInfo folderInfo;
        private void ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                tvArchivos.AfterSelect += tvArchivos_AfterSelect;
                txtRuta.Text = folderInfo.FullName;
                LlenarArbol(folderInfo, tvArchivos.Nodes);
            }
        }

        private void tvArchivos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtRuta.Text = e.Node.Name;
        }

        ArrayList archivos = new ArrayList();
        private void LlenarArbol(DirectoryInfo di, TreeNodeCollection node)
        {
            TreeNode nodo = node.Add(di.Name);
            foreach (FileInfo archivo in di.GetFiles())
            {
                nodo.Nodes.Add(archivo.FullName, archivo.Name);
                archivos.Add(archivo);
            }
            foreach (DirectoryInfo sdi in di.GetDirectories())
            { LlenarArbol(sdi, nodo.Nodes); }
        }

        private void OrganizarMover()
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            MessageBox.Show("Selecciona donde se creara la nueva carpeta organizada");
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\Carpeta Organizada");
                DirectoryInfo carpetaOrganizadaInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                MoverArchivos(carpetaOrganizadaInfo);
            }
        }
        private void OrganizarCopiar()
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            MessageBox.Show("Selecciona donde se creara la nueva carpeta organizada");
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\Carpeta Organizada");
                DirectoryInfo carpetaOrganizadaInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                CopiarArchivos(carpetaOrganizadaInfo);
            }
        }
        private void MoverArchivos(DirectoryInfo di)
        {
            foreach (FileInfo file in archivos)
            {
                try
                {
                    if (file.Extension == ".jpg" || file.Extension == ".jpeg" || file.Extension == ".png")
                    { FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Imagenes\\" + file, UIOption.AllDialogs); }
                    else if (file.Extension == ".mp3" || file.Extension == ".wav" || file.Extension == ".m4a" || file.Extension == ".flac")
                    { FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Audio\\" + file, UIOption.AllDialogs); }
                    else if (file.Extension == ".mp4" || file.Extension == ".mov")
                    { FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Video\\" + file, UIOption.AllDialogs); }
                    else if (file.Extension == ".cs" || file.Extension == ".txt" || file.Extension == ".docx" || file.Extension == ".pptx"
                        || file.Extension == ".pdf" || file.Extension == ".PDF" || file.Extension == ".xlsx")
                    { FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Documentos\\" + file, UIOption.AllDialogs); }
                    else
                    { FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Archivos\\" + file, UIOption.AllDialogs); }
                }
                catch (Exception)
                { }
            }
        }
        private void CopiarArchivos(DirectoryInfo di)
        {
            foreach (FileInfo file in archivos)
            {
                try
                {
                    if (file.Extension == ".jpg" || file.Extension == ".jpeg" || file.Extension == ".png")
                    { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Imagenes\\" + file, UIOption.AllDialogs); }
                    else if (file.Extension == ".mp3" || file.Extension == ".wav" || file.Extension == ".m4a" || file.Extension == ".flac")
                    { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Audio\\" + file, UIOption.AllDialogs); }
                    else if (file.Extension == ".mp4" || file.Extension == ".mov")
                    { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Video\\" + file, UIOption.AllDialogs); }
                    else if (file.Extension == ".cs" || file.Extension == ".txt" || file.Extension == ".docx" || file.Extension == ".pptx"
                        || file.Extension == ".pdf" || file.Extension == ".xlsx")
                    { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Documentos\\" + file, UIOption.AllDialogs); }
                    else
                    { FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\Carpeta Organizada Archivos\\" + file, UIOption.AllDialogs); }
                }
                catch (Exception)
                { }
            }
        }
        private void pbCopiar_Click(object sender, EventArgs e)
        {
            OrganizarCopiar();
        }

        private void pbMover_Click(object sender, EventArgs e)
        {
            OrganizarMover();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
    }
}