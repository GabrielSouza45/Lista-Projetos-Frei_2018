namespace Nsf._2018.Modulo2.BD.Video
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.gvfilmes = new System.Windows.Forms.DataGridView();
            this.txtfilme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvfilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // gvfilmes
            // 
            this.gvfilmes.AllowUserToAddRows = false;
            this.gvfilmes.AllowUserToDeleteRows = false;
            this.gvfilmes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvfilmes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvfilmes.ColumnHeadersHeight = 50;
            this.gvfilmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvfilmes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvfilmes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvfilmes.Location = new System.Drawing.Point(0, 124);
            this.gvfilmes.Name = "gvfilmes";
            this.gvfilmes.ReadOnly = true;
            this.gvfilmes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.gvfilmes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvfilmes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvfilmes.RowTemplate.Height = 28;
            this.gvfilmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvfilmes.Size = new System.Drawing.Size(832, 370);
            this.gvfilmes.TabIndex = 11;
            this.gvfilmes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvfilmes_CellContentClick);
            this.gvfilmes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvfilmes_CellDoubleClick);
            // 
            // txtfilme
            // 
            this.txtfilme.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilme.Location = new System.Drawing.Point(92, 83);
            this.txtfilme.Name = "txtfilme";
            this.txtfilme.Size = new System.Drawing.Size(307, 33);
            this.txtfilme.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filme:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(522, 82);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(218, 33);
            this.cboCategoria.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(411, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gênero:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(1)))));
            this.btnBuscar.Location = new System.Drawing.Point(746, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 36);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Filme";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Categoria";
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Avaliacao";
            this.Column3.HeaderText = "Avaliacao";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Image = ((System.Drawing.Image)(resources.GetObject("Column4.Image")));
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 25;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TotalBruto";
            this.Column6.HeaderText = "";
            this.Column6.Image = global::Nsf._2018.Modulo2.BD.Video.Properties.Resources.edit2;
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TotalLiquido";
            this.Column7.HeaderText = "";
            this.Column7.Image = global::Nsf._2018.Modulo2.BD.Video.Properties.Resources.remove2;
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 25;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfilme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvfilmes);
            this.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBuscar";
            this.Size = new System.Drawing.Size(832, 494);
            ((System.ComponentModel.ISupportInitialize)(this.gvfilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvfilmes;
        private System.Windows.Forms.TextBox txtfilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
    }
}
