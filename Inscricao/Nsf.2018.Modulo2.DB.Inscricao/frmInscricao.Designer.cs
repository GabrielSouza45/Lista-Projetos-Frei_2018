namespace Nsf._2018.Modulo2.DB.Inscricao
{
    partial class frmInscricao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFaculdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInscricoes = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(6, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 331);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 29);
            this.txtNome.TabIndex = 1;
            // 
            // txtFaculdade
            // 
            this.txtFaculdade.Location = new System.Drawing.Point(105, 367);
            this.txtFaculdade.Name = "txtFaculdade";
            this.txtFaculdade.Size = new System.Drawing.Size(198, 29);
            this.txtFaculdade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(6, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faculdade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(6, 402);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(297, 39);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Inscrever";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(-3, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 131);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvInscricoes
            // 
            this.dgvInscricoes.AllowUserToAddRows = false;
            this.dgvInscricoes.AllowUserToDeleteRows = false;
            this.dgvInscricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscricoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvInscricoes.Location = new System.Drawing.Point(445, 5);
            this.dgvInscricoes.Name = "dgvInscricoes";
            this.dgvInscricoes.ReadOnly = true;
            this.dgvInscricoes.Size = new System.Drawing.Size(347, 172);
            this.dgvInscricoes.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Gold;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(445, 181);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(347, 39);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Ver inscritos";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(438, -6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 231);
            this.label4.TabIndex = 8;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Faculdade";
            this.Column2.HeaderText = "Faculdade";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nsf._2018.Modulo2.DB.Inscricao.Properties.Resources.simpsons;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvInscricoes);
            this.Controls.Add(this.txtFaculdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInscricao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrições 2019";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscricoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFaculdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInscricoes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

