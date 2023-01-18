namespace Nsf._2018.Modulo2.BD.Musica
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblMusica = new System.Windows.Forms.Label();
            this.lblBanda = new System.Windows.Forms.Label();
            this.btnAntes = new System.Windows.Forms.PictureBox();
            this.btnProximo = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAntes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.imgLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 664);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(161, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 664);
            this.panel5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Novo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.search2;
            this.btnBuscar.Location = new System.Drawing.Point(32, 425);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 87);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.add2;
            this.btnNovo.Location = new System.Drawing.Point(32, 267);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 87);
            this.btnNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovo.TabIndex = 9;
            this.btnNovo.TabStop = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.bg6;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(162, 164);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblCaminho);
            this.panel1.Controls.Add(this.mediaPlayer);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.lblDuracao);
            this.panel1.Controls.Add(this.lblAlbum);
            this.panel1.Controls.Add(this.lblMusica);
            this.panel1.Controls.Add(this.lblBanda);
            this.panel1.Controls.Add(this.btnAntes);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(162, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 164);
            this.panel1.TabIndex = 3;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminho.ForeColor = System.Drawing.Color.White;
            this.lblCaminho.Location = new System.Drawing.Point(368, 124);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(12, 18);
            this.lblCaminho.TabIndex = 10;
            this.lblCaminho.Text = "-";
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(38, 31);
            this.mediaPlayer.TabIndex = 9;
            this.mediaPlayer.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(644, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 22);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDuracao
            // 
            this.lblDuracao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.ForeColor = System.Drawing.Color.White;
            this.lblDuracao.Location = new System.Drawing.Point(126, 129);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(98, 18);
            this.lblDuracao.TabIndex = 7;
            this.lblDuracao.Text = "-";
            this.lblDuracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.White;
            this.lblAlbum.Location = new System.Drawing.Point(363, 64);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(20, 25);
            this.lblAlbum.TabIndex = 6;
            this.lblAlbum.Text = "-";
            // 
            // lblMusica
            // 
            this.lblMusica.AutoSize = true;
            this.lblMusica.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusica.ForeColor = System.Drawing.Color.White;
            this.lblMusica.Location = new System.Drawing.Point(363, 41);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(20, 25);
            this.lblMusica.TabIndex = 5;
            this.lblMusica.Text = "-";
            // 
            // lblBanda
            // 
            this.lblBanda.AutoSize = true;
            this.lblBanda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanda.ForeColor = System.Drawing.Color.White;
            this.lblBanda.Location = new System.Drawing.Point(365, 90);
            this.lblBanda.Name = "lblBanda";
            this.lblBanda.Size = new System.Drawing.Size(16, 21);
            this.lblBanda.TabIndex = 4;
            this.lblBanda.Text = "-";
            // 
            // btnAntes
            // 
            this.btnAntes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntes.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.before;
            this.btnAntes.Location = new System.Drawing.Point(50, 55);
            this.btnAntes.Name = "btnAntes";
            this.btnAntes.Size = new System.Drawing.Size(70, 56);
            this.btnAntes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAntes.TabIndex = 3;
            this.btnAntes.TabStop = false;
            // 
            // btnProximo
            // 
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.next;
            this.btnProximo.Location = new System.Drawing.Point(230, 55);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(70, 56);
            this.btnProximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProximo.TabIndex = 2;
            this.btnProximo.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(126, 39);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 87);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.pause2;
            this.btnPause.Location = new System.Drawing.Point(126, 39);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(98, 87);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackgroundImage = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.bg;
            this.panelConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(162, 164);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(670, 500);
            this.panelConteudo.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(832, 664);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freitify";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAntes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.PictureBox btnAntes;
        private System.Windows.Forms.PictureBox btnProximo;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.Label lblBanda;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.PictureBox btnNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCaminho;
    }
}

