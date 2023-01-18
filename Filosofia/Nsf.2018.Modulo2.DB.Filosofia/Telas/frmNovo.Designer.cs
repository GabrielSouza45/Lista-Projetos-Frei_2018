namespace Nsf._2018.Modulo2.DB.Filosofia.Telas
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.HotPink;
            this.lblMessage.Location = new System.Drawing.Point(148, 112);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(66, 25);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Autor:";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(104, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensagem:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(230, 147);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(431, 260);
            this.txtMensagem.TabIndex = 6;
            this.txtMensagem.WordWrap = false;
            // 
            // cboAutor
            // 
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAutor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Items.AddRange(new object[] {
            "Selecione",
            "Nossos",
            "M. de Assis",
            "Sócrates",
            "Jesus Cristo",
            "Buda",
            "J.J. Rousseau",
            "Einstein"});
            this.cboAutor.Location = new System.Drawing.Point(230, 111);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(431, 29);
            this.cboAutor.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.confirm3;
            this.btnSalvar.Location = new System.Drawing.Point(667, 367);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmNovo";
            this.Size = new System.Drawing.Size(826, 438);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.PictureBox btnSalvar;
    }
}
