namespace Nsf._2018.Modulo2.BD.Chat.Telas
{
    partial class frmEnviado
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
            this.lblHorario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(198)))));
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHorario.Location = new System.Drawing.Point(506, 67);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(39, 17);
            this.lblHorario.TabIndex = 0;
            this.lblHorario.Text = "19:34";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nsf._2018.Modulo2.BD.Chat.Properties.Resources.chatbgsent;
            this.pictureBox1.Location = new System.Drawing.Point(181, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(198)))));
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(203, 33);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(292, 44);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Esse é apenas um exemplo de texto mais ou menos grande que alguém pode enviar.";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmEnviado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmEnviado";
            this.Size = new System.Drawing.Size(624, 106);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMensagem;
    }
}
