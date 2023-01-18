namespace Nsf._2018.Modulo2.DB.Genio
{
    partial class frmInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvDesejos = new System.Windows.Forms.DataGridView();
            this.txtDesejo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvDesejos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDesejos
            // 
            this.gvDesejos.AllowUserToAddRows = false;
            this.gvDesejos.AllowUserToDeleteRows = false;
            this.gvDesejos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.gvDesejos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDesejos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDesejos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Waltograph UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDesejos.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvDesejos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.gvDesejos.Location = new System.Drawing.Point(7, 321);
            this.gvDesejos.Name = "gvDesejos";
            this.gvDesejos.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(7)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Waltograph UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(7)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDesejos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvDesejos.RowHeadersVisible = false;
            this.gvDesejos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.gvDesejos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Waltograph UI", 10F);
            this.gvDesejos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gvDesejos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.gvDesejos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvDesejos.Size = new System.Drawing.Size(284, 122);
            this.gvDesejos.TabIndex = 9;
            // 
            // txtDesejo
            // 
            this.txtDesejo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDesejo.Location = new System.Drawing.Point(7, 286);
            this.txtDesejo.Name = "txtDesejo";
            this.txtDesejo.Size = new System.Drawing.Size(284, 25);
            this.txtDesejo.TabIndex = 8;
            this.txtDesejo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDesejo_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Waltograph UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(59, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "maiores desejos?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Waltograph UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(69, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quais são seus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Nsf._2018.Modulo2.DB.Genio.Properties.Resources.genio;
            this.pictureBox1.Location = new System.Drawing.Point(69, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.ForeColor = System.Drawing.Color.Tomato;
            this.lblSair.Location = new System.Drawing.Point(275, 5);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(19, 18);
            this.lblSair.TabIndex = 10;
            this.lblSair.Text = "x";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Desejo";
            this.Column1.HeaderText = "Desejo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nsf._2018.Modulo2.DB.Genio.Properties.Resources.bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(298, 449);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.gvDesejos);
            this.Controls.Add(this.txtDesejo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Waltograph UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus Desejos";
            ((System.ComponentModel.ISupportInitialize)(this.gvDesejos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDesejos;
        private System.Windows.Forms.TextBox txtDesejo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

