
namespace proyectoCS

{
    partial class EditorDeImagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorDeImagenes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblEfectos = new System.Windows.Forms.Label();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnArtistic = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnSpike = new System.Windows.Forms.Button();
            this.btnFlash = new System.Windows.Forms.Button();
            this.btnFrozen = new System.Windows.Forms.Button();
            this.btnSuji = new System.Windows.Forms.Button();
            this.btnDramatic = new System.Windows.Forms.Button();
            this.btnKakao = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblAjustar = new System.Windows.Forms.Label();
            this.pbAbrir = new System.Windows.Forms.PictureBox();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(181, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 350);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblEfectos
            // 
            this.lblEfectos.AutoSize = true;
            this.lblEfectos.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEfectos.Location = new System.Drawing.Point(795, 70);
            this.lblEfectos.Name = "lblEfectos";
            this.lblEfectos.Size = new System.Drawing.Size(78, 25);
            this.lblEfectos.TabIndex = 5;
            this.lblEfectos.Text = "Efectos";
            this.lblEfectos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(798, 98);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(75, 23);
            this.btnNone.TabIndex = 6;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnArtistic
            // 
            this.btnArtistic.Location = new System.Drawing.Point(798, 156);
            this.btnArtistic.Name = "btnArtistic";
            this.btnArtistic.Size = new System.Drawing.Size(75, 23);
            this.btnArtistic.TabIndex = 7;
            this.btnArtistic.Text = "Artistic";
            this.btnArtistic.UseVisualStyleBackColor = true;
            this.btnArtistic.Click += new System.EventHandler(this.btnArtistic_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.Location = new System.Drawing.Point(798, 127);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(75, 23);
            this.btnSepia.TabIndex = 8;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.UseVisualStyleBackColor = true;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(798, 185);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 9;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnSpike
            // 
            this.btnSpike.Location = new System.Drawing.Point(798, 215);
            this.btnSpike.Name = "btnSpike";
            this.btnSpike.Size = new System.Drawing.Size(75, 23);
            this.btnSpike.TabIndex = 10;
            this.btnSpike.Text = "Spike";
            this.btnSpike.UseVisualStyleBackColor = true;
            this.btnSpike.Click += new System.EventHandler(this.btnSpike_Click);
            // 
            // btnFlash
            // 
            this.btnFlash.Location = new System.Drawing.Point(798, 244);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(75, 23);
            this.btnFlash.TabIndex = 11;
            this.btnFlash.Text = "Flash";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // btnFrozen
            // 
            this.btnFrozen.Location = new System.Drawing.Point(798, 273);
            this.btnFrozen.Name = "btnFrozen";
            this.btnFrozen.Size = new System.Drawing.Size(75, 23);
            this.btnFrozen.TabIndex = 12;
            this.btnFrozen.Text = "Frozen";
            this.btnFrozen.UseVisualStyleBackColor = true;
            this.btnFrozen.Click += new System.EventHandler(this.btnFrozen_Click);
            // 
            // btnSuji
            // 
            this.btnSuji.Location = new System.Drawing.Point(798, 302);
            this.btnSuji.Name = "btnSuji";
            this.btnSuji.Size = new System.Drawing.Size(75, 23);
            this.btnSuji.TabIndex = 13;
            this.btnSuji.Text = "Suji";
            this.btnSuji.UseVisualStyleBackColor = true;
            this.btnSuji.Click += new System.EventHandler(this.btnSuji_Click);
            // 
            // btnDramatic
            // 
            this.btnDramatic.Location = new System.Drawing.Point(798, 331);
            this.btnDramatic.Name = "btnDramatic";
            this.btnDramatic.Size = new System.Drawing.Size(75, 23);
            this.btnDramatic.TabIndex = 14;
            this.btnDramatic.Text = "Dramatic";
            this.btnDramatic.UseVisualStyleBackColor = true;
            this.btnDramatic.Click += new System.EventHandler(this.btnDramatic_Click);
            // 
            // btnKakao
            // 
            this.btnKakao.Location = new System.Drawing.Point(798, 360);
            this.btnKakao.Name = "btnKakao";
            this.btnKakao.Size = new System.Drawing.Size(75, 23);
            this.btnKakao.TabIndex = 15;
            this.btnKakao.Text = "Kakao";
            this.btnKakao.UseVisualStyleBackColor = true;
            this.btnKakao.Click += new System.EventHandler(this.btnKakao_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(60, 141);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(60, 229);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(60, 328);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 18;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblR.Location = new System.Drawing.Point(23, 141);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(24, 25);
            this.lblR.TabIndex = 19;
            this.lblR.Text = "R";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblG.Location = new System.Drawing.Point(23, 229);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(26, 25);
            this.lblG.TabIndex = 20;
            this.lblG.Text = "G";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblB.Location = new System.Drawing.Point(21, 324);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 25);
            this.lblB.TabIndex = 21;
            this.lblB.Text = "B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAjustar
            // 
            this.lblAjustar.AutoSize = true;
            this.lblAjustar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAjustar.Location = new System.Drawing.Point(62, 94);
            this.lblAjustar.Name = "lblAjustar";
            this.lblAjustar.Size = new System.Drawing.Size(76, 25);
            this.lblAjustar.TabIndex = 22;
            this.lblAjustar.Text = "Ajustar";
            this.lblAjustar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbAbrir
            // 
            this.pbAbrir.Image = ((System.Drawing.Image)(resources.GetObject("pbAbrir.Image")));
            this.pbAbrir.Location = new System.Drawing.Point(88, 12);
            this.pbAbrir.Name = "pbAbrir";
            this.pbAbrir.Size = new System.Drawing.Size(50, 50);
            this.pbAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbrir.TabIndex = 23;
            this.pbAbrir.TabStop = false;
            this.pbAbrir.Click += new System.EventHandler(this.pbAbrir_Click);
            // 
            // pbGuardar
            // 
            this.pbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pbGuardar.Image")));
            this.pbGuardar.Location = new System.Drawing.Point(811, 399);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(50, 50);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardar.TabIndex = 24;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(181, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 20);
            this.textBox1.TabIndex = 25;
            // 
            // EditorDeImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(882, 456);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbGuardar);
            this.Controls.Add(this.pbAbrir);
            this.Controls.Add(this.lblAjustar);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnKakao);
            this.Controls.Add(this.btnDramatic);
            this.Controls.Add(this.btnSuji);
            this.Controls.Add(this.btnFrozen);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.btnSpike);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.btnArtistic);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.lblEfectos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorDeImagenes";
            this.Text = "Editor de Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblEfectos;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnArtistic;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnSpike;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.Button btnFrozen;
        private System.Windows.Forms.Button btnSuji;
        private System.Windows.Forms.Button btnDramatic;
        private System.Windows.Forms.Button btnKakao;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblAjustar;
        private System.Windows.Forms.PictureBox pbAbrir;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

