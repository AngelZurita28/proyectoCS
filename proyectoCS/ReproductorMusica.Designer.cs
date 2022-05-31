namespace proyectoCS
{
    partial class ReproductorMusica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReproductorMusica));
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.trackList = new System.Windows.Forms.ListBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.sbTiempo = new System.Windows.Forms.HScrollBar();
            this.sbVolumen = new System.Windows.Forms.HScrollBar();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(10, 12);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(65, 65);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(98, 56);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Location = new System.Drawing.Point(423, 57);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnPlaylist.TabIndex = 2;
            this.btnPlaylist.Text = "Ver Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.trackList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(10, 99);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(650, 82);
            this.trackList.TabIndex = 3;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(179, 57);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(260, 57);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(341, 57);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(505, 57);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnAleatorio.TabIndex = 7;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // sbTiempo
            // 
            this.sbTiempo.Location = new System.Drawing.Point(141, 26);
            this.sbTiempo.Name = "sbTiempo";
            this.sbTiempo.Size = new System.Drawing.Size(357, 20);
            this.sbTiempo.TabIndex = 8;
            this.sbTiempo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbTiempo_Scroll);
            // 
            // sbVolumen
            // 
            this.sbVolumen.Location = new System.Drawing.Point(543, 26);
            this.sbVolumen.Maximum = 200;
            this.sbVolumen.Name = "sbVolumen";
            this.sbVolumen.Size = new System.Drawing.Size(118, 20);
            this.sbVolumen.TabIndex = 9;
            this.sbVolumen.Value = 50;
            this.sbVolumen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVolumen_Scroll);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(100, 26);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(38, 16);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "00:00";
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTotalTime.Location = new System.Drawing.Point(502, 26);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(38, 16);
            this.lbTotalTime.TabIndex = 11;
            this.lbTotalTime.Text = "00:00";
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(587, 57);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(75, 23);
            this.btnInformacion.TabIndex = 12;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(10, 12);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(75, 75);
            this.pbAlbum.TabIndex = 13;
            this.pbAlbum.TabStop = false;
            // 
            // ReproductorMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(673, 193);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.lbTotalTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.sbVolumen);
            this.Controls.Add(this.sbTiempo);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.vlcControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReproductorMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.HScrollBar sbTiempo;
        private System.Windows.Forms.HScrollBar sbVolumen;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.PictureBox pbAlbum;
    }
}

