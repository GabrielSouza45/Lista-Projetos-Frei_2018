namespace Nsf._2018.Modulo2.BD.Video
{
    partial class frmNovo
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
            this.txtfilme = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.dtpLancamento = new System.Windows.Forms.DateTimePicker();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.nudDuracao = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkMaioridade = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAvaliacao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQtdTemp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvaliacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfilme
            // 
            this.txtfilme.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilme.Location = new System.Drawing.Point(197, 62);
            this.txtfilme.Name = "txtfilme";
            this.txtfilme.Size = new System.Drawing.Size(241, 33);
            this.txtfilme.TabIndex = 0;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopse.Location = new System.Drawing.Point(197, 248);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(578, 96);
            this.txtSinopse.TabIndex = 1;
            // 
            // dtpLancamento
            // 
            this.dtpLancamento.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLancamento.Location = new System.Drawing.Point(628, 176);
            this.dtpLancamento.Name = "dtpLancamento";
            this.dtpLancamento.Size = new System.Drawing.Size(147, 33);
            this.dtpLancamento.TabIndex = 6;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(197, 101);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(241, 33);
            this.cboCategoria.TabIndex = 4;
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
            this.nudDuracao.Location = new System.Drawing.Point(628, 60);
            this.nudDuracao.Name = "nudDuracao";
            this.nudDuracao.Size = new System.Drawing.Size(146, 33);
            this.nudDuracao.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Gold;
            this.btnSalvar.Location = new System.Drawing.Point(325, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(241, 56);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.Location = new System.Drawing.Point(197, 141);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Size = new System.Drawing.Size(241, 33);
            this.txtCaminho.TabIndex = 3;
            this.txtCaminho.Click += new System.EventHandler(this.txtCaminho_Click);
            this.txtCaminho.Enter += new System.EventHandler(this.txtCaminho_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "Caminho:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(466, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 30);
            this.label6.TabIndex = 42;
            this.label6.Text = "Duração:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "Categoria:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(466, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Lançamento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 40);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sinopse:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 30);
            this.label8.TabIndex = 37;
            this.label8.Text = "Filme:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkMaioridade
            // 
            this.chkMaioridade.AutoSize = true;
            this.chkMaioridade.BackColor = System.Drawing.Color.Black;
            this.chkMaioridade.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkMaioridade.ForeColor = System.Drawing.Color.White;
            this.chkMaioridade.Location = new System.Drawing.Point(197, 180);
            this.chkMaioridade.Name = "chkMaioridade";
            this.chkMaioridade.Size = new System.Drawing.Size(177, 29);
            this.chkMaioridade.TabIndex = 44;
            this.chkMaioridade.Text = "Maior de 18 anos";
            this.chkMaioridade.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(466, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 30);
            this.label7.TabIndex = 46;
            this.label7.Text = "Avaliação:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAvaliacao
            // 
            this.nudAvaliacao.DecimalPlaces = 2;
            this.nudAvaliacao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAvaliacao.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAvaliacao.Location = new System.Drawing.Point(628, 100);
            this.nudAvaliacao.Name = "nudAvaliacao";
            this.nudAvaliacao.Size = new System.Drawing.Size(146, 33);
            this.nudAvaliacao.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Qtd Temp:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudQtdTemp
            // 
            this.nudQtdTemp.DecimalPlaces = 2;
            this.nudQtdTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdTemp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudQtdTemp.Location = new System.Drawing.Point(628, 138);
            this.nudQtdTemp.Name = "nudQtdTemp";
            this.nudQtdTemp.Size = new System.Drawing.Size(146, 33);
            this.nudQtdTemp.TabIndex = 47;
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudQtdTemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudAvaliacao);
            this.Controls.Add(this.chkMaioridade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nudDuracao);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.dtpLancamento);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.txtfilme);
            this.Font = new System.Drawing.Font("Kristen ITC", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmNovo";
            this.Size = new System.Drawing.Size(827, 494);
            ((System.ComponentModel.ISupportInitialize  )(this.nudDuracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvaliacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtfilme;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.DateTimePicker dtpLancamento;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.NumericUpDown nudDuracao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkMaioridade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAvaliacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQtdTemp;
    }
}
