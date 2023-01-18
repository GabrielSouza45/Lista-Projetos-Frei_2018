namespace Nsf._2018.Modulo2.DB.Sentimentos.Telas
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
            this.cboPensamento = new System.Windows.Forms.ComboBox();
            this.cboGpoSocial = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPensamento
            // 
            this.cboPensamento.BackColor = System.Drawing.Color.Black;
            this.cboPensamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPensamento.Font = new System.Drawing.Font("Lithos Pro Regular", 13F);
            this.cboPensamento.ForeColor = System.Drawing.Color.White;
            this.cboPensamento.FormattingEnabled = true;
            this.cboPensamento.Location = new System.Drawing.Point(81, 87);
            this.cboPensamento.Name = "cboPensamento";
            this.cboPensamento.Size = new System.Drawing.Size(202, 28);
            this.cboPensamento.TabIndex = 0;
            // 
            // cboGpoSocial
            // 
            this.cboGpoSocial.BackColor = System.Drawing.Color.Black;
            this.cboGpoSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGpoSocial.Font = new System.Drawing.Font("Lithos Pro Regular", 13F);
            this.cboGpoSocial.ForeColor = System.Drawing.Color.White;
            this.cboGpoSocial.FormattingEnabled = true;
            this.cboGpoSocial.Location = new System.Drawing.Point(81, 120);
            this.cboGpoSocial.Name = "cboGpoSocial";
            this.cboGpoSocial.Size = new System.Drawing.Size(202, 28);
            this.cboGpoSocial.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = global::Nsf._2018.Modulo2.DB.Sentimentos.Properties.Resources.send;
            this.btnSalvar.Location = new System.Drawing.Point(143, 150);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 80);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNick.Font = new System.Drawing.Font("Lithos Pro Regular", 13F);
            this.txtNick.Location = new System.Drawing.Point(81, 55);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(202, 28);
            this.txtNick.TabIndex = 3;
            this.txtNick.Text = "Seu nick aqui";
            // 
            // lblErro
            // 
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Lithos Pro Regular", 10F, System.Drawing.FontStyle.Bold);
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(3, 246);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(352, 23);
            this.lblErro.TabIndex = 4;
            this.lblErro.Text = "Erro";
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nsf._2018.Modulo2.DB.Sentimentos.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboGpoSocial);
            this.Controls.Add(this.cboPensamento);
            this.Name = "frmNovo";
            this.Size = new System.Drawing.Size(358, 269);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPensamento;
        private System.Windows.Forms.ComboBox cboGpoSocial;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblErro;
    }
}
