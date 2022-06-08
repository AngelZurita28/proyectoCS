namespace proyectoCS
{
    partial class Documentos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documentos));
            this.richTextWord = new System.Windows.Forms.RichTextBox();
            this.exploradorArchivos = new System.Windows.Forms.OpenFileDialog();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.pbAbrir = new System.Windows.Forms.PictureBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextWord
            // 
            this.richTextWord.Location = new System.Drawing.Point(8, 64);
            this.richTextWord.Margin = new System.Windows.Forms.Padding(2);
            this.richTextWord.Name = "richTextWord";
            this.richTextWord.Size = new System.Drawing.Size(519, 380);
            this.richTextWord.TabIndex = 1;
            this.richTextWord.Text = "";
            // 
            // exploradorArchivos
            // 
            this.exploradorArchivos.FileName = "exploradorArchivos";
            // 
            // pbGuardar
            // 
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(497, 8);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(30, 30);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 3;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // pbAbrir
            // 
            this.pbAbrir.Image = ((System.Drawing.Image)(resources.GetObject("pbAbrir.Image")));
            this.pbAbrir.Location = new System.Drawing.Point(8, 9);
            this.pbAbrir.Name = "pbAbrir";
            this.pbAbrir.Size = new System.Drawing.Size(25, 25);
            this.pbAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbrir.TabIndex = 4;
            this.pbAbrir.TabStop = false;
            this.pbAbrir.Click += new System.EventHandler(this.pbAbrir_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArchivo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtArchivo.Location = new System.Drawing.Point(39, 12);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(336, 20);
            this.txtArchivo.TabIndex = 5;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(537, 455);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.pbAbrir);
            this.Controls.Add(this.pbGuardar);
            this.Controls.Add(this.richTextWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Documentos";
            this.Text = "Documento de Word";
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextWord;
        private System.Windows.Forms.OpenFileDialog exploradorArchivos;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.PictureBox pbAbrir;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}

