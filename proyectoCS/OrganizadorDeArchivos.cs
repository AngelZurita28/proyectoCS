﻿using System;
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
            {
                LlenarArbol(sdi, nodo.Nodes);
            }
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
            //foreach (FileInfo file in folderInfo.GetFiles())
            //{ File.Move(file.FullName, di + "\\Carpeta Organizada\\" + file); }
            //foreach (DirectoryInfo directoryInfo in folderInfo.GetDirectories())
            //{
            //    MoverArchivos(directoryInfo);
            //}
            foreach (FileInfo file in archivos)
            {

                {
                    try
                    {
                        //File.Move(file.FullName, di + "\\Carpeta Organizada\\" + file);
                        FileSystem.MoveFile(file.FullName, di + "\\Carpeta Organizada\\" + file, UIOption.AllDialogs);
                    }
                    catch (Exception ex)
                    { }
                }
            }
        }

        private void CopiarArchivos(DirectoryInfo di)
        {
            foreach (FileInfo file in archivos)
            {

                {
                    try
                    {

                        //File.Move(file.FullName, di + "\\Carpeta Organizada\\" + file);
                        FileSystem.CopyFile(file.FullName, di + "\\Carpeta Organizada\\" + file, UIOption.AllDialogs);
                    }
                    catch (Exception ex)
                    {

                    }
                }
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
