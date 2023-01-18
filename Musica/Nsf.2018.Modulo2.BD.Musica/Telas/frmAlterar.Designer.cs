namespace Nsf._2018.Modulo2.BD.Musica
{
    partial class frmAlterar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.nudDuracao = new System.Windows.Forms.NumericUpDown();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.dtpLancamento = new System.Windows.Forms.DateTimePicker();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtBanda = new System.Windows.Forms.TextBox();
            this.txtMusica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Lobster", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(1)))));
            this.btnSalvar.Location = new System.Drawing.Point(268, 411);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(240, 56);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Alterar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(263, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 25);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "0";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.Location = new System.Drawing.Point(268, 186);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Size = new System.Drawing.Size(241, 33);
            this.txtCaminho.TabIndex = 3;
            // 
            // nudDuracao
            // 
            this.nudDuracao.DecimalPlaces = 2;
            this.nudDuracao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuracao.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDuracao.Location = new System.Drawing.Point(268, 304);
            this.nudDuracao.Name = "nudDuracao";
            this.nudDuracao.Size = new System.Drawing.Size(240, 33);
            this.nudDuracao.TabIndex = 5;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(267, 258);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(241, 33);
            this.cboGenero.TabIndex = 4;
            // 
            // dtpLancamento
            // 
            this.dtpLancamento.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLancamento.Location = new System.Drawing.Point(267, 346);
            this.dtpLancamento.Name = "dtpLancamento";
            this.dtpLancamento.Size = new System.Drawing.Size(241, 33);
            this.dtpLancamento.TabIndex = 6;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbum.Location = new System.Drawing.Point(268, 146);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(241, 33);
            this.txtAlbum.TabIndex = 2;
            // 
            // txtBanda
            // 
            this.txtBanda.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanda.Location = new System.Drawing.Point(268, 107);
            this.txtBanda.Name = "txtBanda";
            this.txtBanda.Size = new System.Drawing.Size(241, 33);
            this.txtBanda.TabIndex = 1;
            // 
            // txtMusica
            // 
            this.txtMusica.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusica.Location = new System.Drawing.Point(268, 68);
            this.txtMusica.Name = "txtMusica";
            this.txtMusica.Size = new System.Drawing.Size(241, 33);
            this.txtMusica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Caminho:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label6.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(143, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Duração:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label5.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(158, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Gênero:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label4.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(128, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lançamento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label3.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "Albúm:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label2.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Banda:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label8.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(117, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "Música:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label7.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(107, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 30);
            this.label7.TabIndex = 36;
            this.label7.Text = "Id:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.nudDuracao);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.dtpLancamento);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtBanda);
            this.Controls.Add(this.txtMusica);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Kristen ITC", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmAlterar";
            this.Size = new System.Drawing.Size(670, 500);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.NumericUpDown nudDuracao;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.DateTimePicker dtpLancamento;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtBanda;
        private System.Windows.Forms.TextBox txtMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
