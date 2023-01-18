namespace Nsf._2018.Modulo2.BD.Chat.Telas
{
    partial class frmRecebida
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.White;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(51, 30);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(273, 51);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Esse é apenas um exemplo de texto mais ou menos grande que alguém pode enviar.";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.White;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHorario.Location = new System.Drawing.Point(333, 58);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(39, 17);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "19:34";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nsf._2018.Modulo2.BD.Chat.Properties.Resources.chatreceivebg;
            this.pictureBox1.Location = new System.Drawing.Point(10, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(52, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(136, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Informática A - Fulano";
            // 
            // frmRecebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRecebida";
            this.Size = new System.Drawing.Size(624, 106);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
    }
}
