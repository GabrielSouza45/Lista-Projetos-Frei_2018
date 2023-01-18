namespace Nsf._2018.Modulo2.DB.Filosofia
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.AnimacaoTimer = new System.Windows.Forms.Timer(this.components);
            this.btnNovo = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.btnExpand = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.HotPink;
            this.lblMessage.Location = new System.Drawing.Point(52, 44);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(230, 147);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Qual seu\r\npropósito\r\nde vida?";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnimacaoTimer
            // 
            this.AnimacaoTimer.Interval = 1;
            this.AnimacaoTimer.Tick += new System.EventHandler(this.AnimacaoTimer_Tick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.add2;
            this.btnNovo.Location = new System.Drawing.Point(12, 535);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(60, 53);
            this.btnNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNovo.TabIndex = 3;
            this.btnNovo.TabStop = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.search2;
            this.btnBuscar.Location = new System.Drawing.Point(78, 535);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 53);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.Transparent;
            this.panelConteudo.Controls.Add(this.btnExpand);
            this.panelConteudo.Location = new System.Drawing.Point(12, 12);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(826, 438);
            this.panelConteudo.TabIndex = 5;
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.Transparent;
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.expand;
            this.btnExpand.Location = new System.Drawing.Point(276, 178);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(30, 30);
            this.btnExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpand.TabIndex = 3;
            this.btnExpand.TabStop = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(806, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "sair";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.man_in_universe_800;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panelConteudo);
            this.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 150);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frei-Losofia";
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer AnimacaoTimer;
        private System.Windows.Forms.PictureBox btnNovo;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox btnExpand;
        private System.Windows.Forms.Label label1;
    }
}

