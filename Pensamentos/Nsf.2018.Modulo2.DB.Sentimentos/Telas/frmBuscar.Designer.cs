namespace Nsf._2018.Modulo2.DB.Sentimentos.Telas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvPensamentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvPensamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPensamentos
            // 
            this.gvPensamentos.AllowUserToAddRows = false;
            this.gvPensamentos.AllowUserToDeleteRows = false;
            this.gvPensamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(84)))));
            this.gvPensamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPensamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lithos Pro Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPensamentos.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvPensamentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvPensamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(84)))));
            this.gvPensamentos.Location = new System.Drawing.Point(0, 32);
            this.gvPensamentos.Name = "gvPensamentos";
            this.gvPensamentos.ReadOnly = true;
            this.gvPensamentos.RowHeadersVisible = false;
            this.gvPensamentos.Size = new System.Drawing.Size(358, 237);
            this.gvPensamentos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nick:";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(59, 3);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(250, 25);
            this.txtNick.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Nsf._2018.Modulo2.DB.Sentimentos.Properties.Resources.search2;
            this.btnBuscar.Location = new System.Drawing.Point(315, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 30);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblErro
            // 
            this.lblErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(84)))));
            this.lblErro.Font = new System.Drawing.Font("Lithos Pro Regular", 10F, System.Drawing.FontStyle.Bold);
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(3, 243);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(352, 23);
            this.lblErro.TabIndex = 5;
            this.lblErro.Text = "Erro";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "GpoSocial";
            this.Column2.HeaderText = "Grupo Social";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Pensamento";
            this.Column3.HeaderText = "Pensamento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvPensamentos);
            this.Font = new System.Drawing.Font("Lithos Pro Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmBuscar";
            this.Size = new System.Drawing.Size(358, 269);
            ((System.ComponentModel.ISupportInitialize)(this.gvPensamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPensamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
