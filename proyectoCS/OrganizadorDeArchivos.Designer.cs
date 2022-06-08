namespace proyectoCS
{
    partial class Organizador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizador));
            this.tvArchivos = new System.Windows.Forms.TreeView();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.pbCopiar = new System.Windows.Forms.PictureBox();
            this.pbMover = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvArchivos
            // 
            this.tvArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tvArchivos.Location = new System.Drawing.Point(12, 64);
            this.tvArchivos.Name = "tvArchivos";
            this.tvArchivos.Size = new System.Drawing.Size(236, 302);
            this.tvArchivos.TabIndex = 1;
            this.tvArchivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArchivos_AfterSelect);
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtRuta.Location = new System.Drawing.Point(68, 26);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(304, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // pbCopiar
            // 
            this.pbCopiar.Image = ((System.Drawing.Image)(resources.GetObject("pbCopiar.Image")));
            this.pbCopiar.InitialImage = null;
            this.pbCopiar.Location = new System.Drawing.Point(308, 120);
            this.pbCopiar.Name = "pbCopiar";
            this.pbCopiar.Size = new System.Drawing.Size(55, 55);
            this.pbCopiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCopiar.TabIndex = 6;
            this.pbCopiar.TabStop = false;
            this.pbCopiar.Click += new System.EventHandler(this.pbCopiar_Click);
            // 
            // pbMover
            // 
            this.pbMover.Image = ((System.Drawing.Image)(resources.GetObject("pbMover.Image")));
            this.pbMover.Location = new System.Drawing.Point(308, 229);
            this.pbMover.Name = "pbMover";
            this.pbMover.Size = new System.Drawing.Size(55, 55);
            this.pbMover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMover.TabIndex = 7;
            this.pbMover.TabStop = false;
            this.pbMover.Click += new System.EventHandler(this.pbMover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(264, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Organizar (copiar)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(263, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Organizar (mover)";
            // 
            // Organizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMover);
            this.Controls.Add(this.pbCopiar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.tvArchivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Organizador";
            this.Text = "Organizador";
            ((System.ComponentModel.ISupportInitialize)(this.pbCopiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tvArchivos;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.PictureBox pbCopiar;
        private System.Windows.Forms.PictureBox pbMover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

