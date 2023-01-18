namespace Nsf._2018.Modulo2.DB.Filosofia.Telas
{
    partial class frmBuscar
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.AnimacaoTimer = new System.Windows.Forms.Timer(this.components);
            this.rdnTodos = new System.Windows.Forms.RadioButton();
            this.rdnNossos = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.PictureBox();
            this.btnEmail = new System.Windows.Forms.PictureBox();
            this.btnProximo = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.rdnSocrates = new System.Windows.Forms.RadioButton();
            this.rdnMachado = new System.Windows.Forms.RadioButton();
            this.rdnBuda = new System.Windows.Forms.RadioButton();
            this.rdnJesus = new System.Windows.Forms.RadioButton();
            this.rdnEinstein = new System.Windows.Forms.RadioButton();
            this.rdnRousseau = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.HotPink;
            this.lblMessage.Location = new System.Drawing.Point(19, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(403, 341);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnimacaoTimer
            // 
            this.AnimacaoTimer.Interval = 10;
            this.AnimacaoTimer.Tick += new System.EventHandler(this.AnimacaoTimer_Tick);
            // 
            // rdnTodos
            // 
            this.rdnTodos.BackColor = System.Drawing.Color.Black;
            this.rdnTodos.Checked = true;
            this.rdnTodos.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnTodos.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.rdnTodos.Location = new System.Drawing.Point(676, 3);
            this.rdnTodos.Name = "rdnTodos";
            this.rdnTodos.Size = new System.Drawing.Size(150, 27);
            this.rdnTodos.TabIndex = 21;
            this.rdnTodos.TabStop = true;
            this.rdnTodos.Text = "Todos";
            this.rdnTodos.UseVisualStyleBackColor = false;
            this.rdnTodos.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // rdnNossos
            // 
            this.rdnNossos.BackColor = System.Drawing.Color.Black;
            this.rdnNossos.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnNossos.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.rdnNossos.Location = new System.Drawing.Point(676, 30);
            this.rdnNossos.Name = "rdnNossos";
            this.rdnNossos.Size = new System.Drawing.Size(150, 27);
            this.rdnNossos.TabIndex = 22;
            this.rdnNossos.Text = "Nossos";
            this.rdnNossos.UseVisualStyleBackColor = false;
            this.rdnNossos.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(132, 378);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 25);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.confirm2;
            this.btnEnviar.Location = new System.Drawing.Point(392, 378);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(30, 25);
            this.btnEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEnviar.TabIndex = 26;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmail.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.email;
            this.btnEmail.Location = new System.Drawing.Point(96, 378);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(30, 25);
            this.btnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmail.TabIndex = 24;
            this.btnEmail.TabStop = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.forward2;
            this.btnProximo.Location = new System.Drawing.Point(50, 378);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(20, 25);
            this.btnProximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProximo.TabIndex = 6;
            this.btnProximo.TabStop = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.Image = global::Nsf._2018.Modulo2.DB.Filosofia.Properties.Resources.back1;
            this.btnAnterior.Location = new System.Drawing.Point(24, 378);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(20, 25);
            this.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // rdnSocrates
            // 
            this.rdnSocrates.BackColor = System.Drawing.Color.Black;
            this.rdnSocrates.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnSocrates.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.rdnSocrates.Location = new System.Drawing.Point(676, 84);
            this.rdnSocrates.Name = "rdnSocrates";
            this.rdnSocrates.Size = new System.Drawing.Size(150, 27);
            this.rdnSocrates.TabIndex = 28;
            this.rdnSocrates.Text = "Sócrates";
            this.rdnSocrates.UseVisualStyleBackColor = false;
            this.rdnSocrates.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // rdnMachado
            // 
            this.rdnMachado.BackColor = System.Drawing.Color.Black;
            this.rdnMachado.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnMachado.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.rdnMachado.Location = new System.Drawing.Point(676, 57);
            this.rdnMachado.Name = "rdnMachado";
            this.rdnMachado.Size = new System.Drawing.Size(150, 27);
            this.rdnMachado.TabIndex = 27;
            this.rdnMachado.Text = "M. de Assis";
            this.rdnMachado.UseVisualStyleBackColor = false;
            this.rdnMachado.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // rdnBuda
            // 
            this.rdnBuda.BackColor = System.Drawing.Color.Black;
            this.rdnBuda.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnBuda.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rdnBuda.Location = new System.Drawing.Point(676, 138);
            this.rdnBuda.Name = "rdnBuda";
            this.rdnBuda.Size = new System.Drawing.Size(150, 27);
            this.rdnBuda.TabIndex = 30;
            this.rdnBuda.Text = "Buda";
            this.rdnBuda.UseVisualStyleBackColor = false;
            this.rdnBuda.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // rdnJesus
            // 
            this.rdnJesus.BackColor = System.Drawing.Color.Black;
            this.rdnJesus.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnJesus.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rdnJesus.Location = new System.Drawing.Point(676, 111);
            this.rdnJesus.Name = "rdnJesus";
            this.rdnJesus.Size = new System.Drawing.Size(150, 27);
            this.rdnJesus.TabIndex = 29;
            this.rdnJesus.Text = "Jesus Cristo";
            this.rdnJesus.UseVisualStyleBackColor = false;
            this.rdnJesus.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // rdnEinstein
            // 
            this.rdnEinstein.BackColor = System.Drawing.Color.Black;
            this.rdnEinstein.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnEinstein.ForeColor = System.Drawing.Color.LightCyan;
            this.rdnEinstein.Location = new System.Drawing.Point(676, 192);
            this.rdnEinstein.Name = "rdnEinstein";
            this.rdnEinstein.Size = new System.Drawing.Size(150, 27);
            this.rdnEinstein.TabIndex = 32;
            this.rdnEinstein.Text = "Einstein";
            this.rdnEinstein.UseVisualStyleBackColor = false;
            this.rdnEinstein.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // rdnRousseau
            // 
            this.rdnRousseau.BackColor = System.Drawing.Color.Black;
            this.rdnRousseau.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdnRousseau.ForeColor = System.Drawing.Color.LightCyan;
            this.rdnRousseau.Location = new System.Drawing.Point(676, 165);
            this.rdnRousseau.Name = "rdnRousseau";
            this.rdnRousseau.Size = new System.Drawing.Size(150, 27);
            this.rdnRousseau.TabIndex = 31;
            this.rdnRousseau.Text = "J.J. Rousseau";
            this.rdnRousseau.UseVisualStyleBackColor = false;
            this.rdnRousseau.CheckedChanged += new System.EventHandler(this.btnRadioButtons_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdnEinstein);
            this.Controls.Add(this.rdnRousseau);
            this.Controls.Add(this.rdnBuda);
            this.Controls.Add(this.rdnJesus);
            this.Controls.Add(this.rdnSocrates);
            this.Controls.Add(this.rdnMachado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.rdnNossos);
            this.Controls.Add(this.rdnTodos);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmBuscar";
            this.Size = new System.Drawing.Size(826, 438);
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox btnProximo;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.Timer AnimacaoTimer;
        private System.Windows.Forms.RadioButton rdnTodos;
        private System.Windows.Forms.RadioButton rdnNossos;
        private System.Windows.Forms.PictureBox btnEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox btnEnviar;
        private System.Windows.Forms.RadioButton rdnSocrates;
        private System.Windows.Forms.RadioButton rdnMachado;
        private System.Windows.Forms.RadioButton rdnBuda;
        private System.Windows.Forms.RadioButton rdnJesus;
        private System.Windows.Forms.RadioButton rdnEinstein;
        private System.Windows.Forms.RadioButton rdnRousseau;
    }
}
