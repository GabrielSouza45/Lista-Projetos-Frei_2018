namespace Nsf._2018.Modulo2.BD.Chat
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
            this.btnFechar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelMensagens = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblErro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelConteudo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Location = new System.Drawing.Point(806, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 22);
            this.btnFechar.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 525);
            this.panel1.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(42, 134);
            this.panel7.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(666, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 525);
            this.panel2.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(42, 132);
            this.panel9.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(42, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 36);
            this.panel4.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel11.Controls.Add(this.cboTurma);
            this.panel11.Controls.Add(this.txtNome);
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(42, 36);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(624, 50);
            this.panel11.TabIndex = 7;
            // 
            // cboTurma
            // 
            this.cboTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cboTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTurma.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Items.AddRange(new object[] {
            "Selecione a Turma",
            "Informática A",
            "Informática B",
            "Informática C",
            "Informática D",
            "PV",
            "Yasmin"});
            this.cboTurma.Location = new System.Drawing.Point(378, 9);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(239, 33);
            this.cboTurma.TabIndex = 10;
            this.cboTurma.SelectedIndexChanged += new System.EventHandler(this.cboTurma_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(54, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 32);
            this.txtNome.TabIndex = 9;
            this.txtNome.Text = "Seu nome aqui";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nsf._2018.Modulo2.BD.Chat.Properties.Resources.student_hat;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.Transparent;
            this.panelConteudo.BackgroundImage = global::Nsf._2018.Modulo2.BD.Chat.Properties.Resources.bg;
            this.panelConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelConteudo.Controls.Add(this.panelMensagens);
            this.panelConteudo.Controls.Add(this.panel5);
            this.panelConteudo.Controls.Add(this.panel3);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(42, 86);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(624, 439);
            this.panelConteudo.TabIndex = 8;
            // 
            // panelMensagens
            // 
            this.panelMensagens.AutoScroll = true;
            this.panelMensagens.BackColor = System.Drawing.Color.Transparent;
            this.panelMensagens.Location = new System.Drawing.Point(19, 17);
            this.panelMensagens.Name = "panelMensagens";
            this.panelMensagens.Size = new System.Drawing.Size(583, 352);
            this.panelMensagens.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.panel5.Controls.Add(this.txtMensagem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 367);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(624, 45);
            this.panel5.TabIndex = 19;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(6, 8);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(608, 28);
            this.txtMensagem.TabIndex = 1;
            this.txtMensagem.Text = "Digite a mensagem aqui";
            this.txtMensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMensagem_KeyUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.lblErro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 27);
            this.panel3.TabIndex = 18;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(172, 3);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(312, 21);
            this.lblErro.TabIndex = 0;
            this.lblErro.Text = "Ocorreu um erro ao carregar as mensagens";
            this.lblErro.Visible = false;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 525);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreiFlix";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelConteudo.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMensagens;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblErro;
    }
}

