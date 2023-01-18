namespace Nsf._2018.Modulo2.BD.Musica
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
            this.gvMusicas = new System.Windows.Forms.DataGridView();
            this.txtMusica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusicas)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMusicas
            // 
            this.gvMusicas.AllowUserToAddRows = false;
            this.gvMusicas.AllowUserToDeleteRows = false;
            this.gvMusicas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvMusicas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMusicas.ColumnHeadersHeight = 50;
            this.gvMusicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lobster", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMusicas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMusicas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvMusicas.Location = new System.Drawing.Point(0, 144);
            this.gvMusicas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gvMusicas.Name = "gvMusicas";
            this.gvMusicas.ReadOnly = true;
            this.gvMusicas.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.gvMusicas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMusicas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMusicas.RowTemplate.Height = 28;
            this.gvMusicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMusicas.Size = new System.Drawing.Size(670, 356);
            this.gvMusicas.TabIndex = 11;
            this.gvMusicas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMusicas_CellContentClick);
            this.gvMusicas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMusicas_CellDoubleClick);
            // 
            // txtMusica
            // 
            this.txtMusica.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusica.Location = new System.Drawing.Point(115, 98);
            this.txtMusica.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMusica.Name = "txtMusica";
            this.txtMusica.Size = new System.Drawing.Size(210, 33);
            this.txtMusica.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label1.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Música:";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(444, 97);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(148, 33);
            this.cboGenero.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.label5.Font = new System.Drawing.Font("Lobster", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(342, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gênero:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(21)))), ((int)(((byte)(15)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Lithos Pro Regular", 15.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(1)))));
            this.btnBuscar.Location = new System.Drawing.Point(600, 97);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 35);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Album";
            this.Column2.HeaderText = "Albúm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Banda";
            this.Column3.HeaderText = "Banda";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.play;
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
            this.Column6.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.edit2;
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
            this.Column7.Image = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.remove2;
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 25;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nsf._2018.Modulo2.BD.Musica.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMusica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvMusicas);
            this.Font = new System.Drawing.Font("Lobster", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmBuscar";
            this.Size = new System.Drawing.Size(670, 500);
            ((System.ComponentModel.ISupportInitialize)(this.gvMusicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMusicas;
        private System.Windows.Forms.TextBox txtMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGenero;
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
