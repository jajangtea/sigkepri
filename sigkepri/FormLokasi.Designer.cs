namespace sigkepri
{
    partial class FormLokasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLokasi));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.idLokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKabKota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatLokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latKabKota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longKabKota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detilLokasi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NamaLokasiTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbbKabKota = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLokasi,
            this.namaKabKota,
            this.alamatLokasi,
            this.latKabKota,
            this.longKabKota,
            this.detilLokasi});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.Location = new System.Drawing.Point(211, 150);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(621, 210);
            this.dgvList.TabIndex = 33;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // idLokasi
            // 
            this.idLokasi.DataPropertyName = "idLokasi";
            this.idLokasi.HeaderText = "idLokasi";
            this.idLokasi.Name = "idLokasi";
            this.idLokasi.ReadOnly = true;
            this.idLokasi.Visible = false;
            this.idLokasi.Width = 76;
            // 
            // namaKabKota
            // 
            this.namaKabKota.DataPropertyName = "namaKabKota";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.namaKabKota.DefaultCellStyle = dataGridViewCellStyle2;
            this.namaKabKota.HeaderText = "Nama Kab/Kota";
            this.namaKabKota.Name = "namaKabKota";
            this.namaKabKota.ReadOnly = true;
            this.namaKabKota.Width = 109;
            // 
            // alamatLokasi
            // 
            this.alamatLokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.alamatLokasi.DataPropertyName = "alamatLokasi";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alamatLokasi.DefaultCellStyle = dataGridViewCellStyle3;
            this.alamatLokasi.HeaderText = "Alamat Lokasi";
            this.alamatLokasi.Name = "alamatLokasi";
            this.alamatLokasi.ReadOnly = true;
            this.alamatLokasi.Width = 200;
            // 
            // latKabKota
            // 
            this.latKabKota.DataPropertyName = "latKabKota";
            this.latKabKota.HeaderText = "Latitude";
            this.latKabKota.Name = "latKabKota";
            this.latKabKota.ReadOnly = true;
            this.latKabKota.Width = 78;
            // 
            // longKabKota
            // 
            this.longKabKota.DataPropertyName = "longKabKota";
            this.longKabKota.HeaderText = "Longitude";
            this.longKabKota.Name = "longKabKota";
            this.longKabKota.ReadOnly = true;
            this.longKabKota.Width = 88;
            // 
            // detilLokasi
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.detilLokasi.DefaultCellStyle = dataGridViewCellStyle4;
            this.detilLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detilLokasi.HeaderText = "Detil Lokasi";
            this.detilLokasi.Name = "detilLokasi";
            this.detilLokasi.ReadOnly = true;
            this.detilLokasi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detilLokasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detilLokasi.Text = "Detil Lokasi";
            this.detilLokasi.UseColumnTextForButtonValue = true;
            this.detilLokasi.Width = 88;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(12, 211);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(181, 46);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Form berikut digunakan untuk mengelola data perizinan yang dilayani oleh dinas pe" +
    "rtambangan provinsi Kepri.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(210, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(154, 25);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Input Data Lokasi";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Yellow;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Navy;
            this.btnHapus.Location = new System.Drawing.Point(11, 343);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(182, 30);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Yellow;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Navy;
            this.btnTambah.Location = new System.Drawing.Point(11, 275);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(182, 30);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(210, 367);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(675, 30);
            this.btnSimpan.TabIndex = 34;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Navy;
            this.btnEdit.Location = new System.Drawing.Point(11, 309);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 30);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.btnHapus);
            this.Panel1.Controls.Add(this.btnTambah);
            this.Panel1.Controls.Add(this.btnEdit);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(204, 400);
            this.Panel1.TabIndex = 36;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(25, 76);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(140, 123);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(42, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Data Lokasi";
            // 
            // NamaLokasiTextBox
            // 
            this.NamaLokasiTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaLokasiTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLokasiTextBox.ForeColor = System.Drawing.Color.Black;
            this.NamaLokasiTextBox.HintForeColor = System.Drawing.Color.Black;
            this.NamaLokasiTextBox.HintText = "";
            this.NamaLokasiTextBox.isPassword = false;
            this.NamaLokasiTextBox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.NamaLokasiTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NamaLokasiTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NamaLokasiTextBox.LineThickness = 2;
            this.NamaLokasiTextBox.Location = new System.Drawing.Point(210, 110);
            this.NamaLokasiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NamaLokasiTextBox.Name = "NamaLokasiTextBox";
            this.NamaLokasiTextBox.Size = new System.Drawing.Size(622, 33);
            this.NamaLokasiTextBox.TabIndex = 32;
            this.NamaLokasiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbbKabKota
            // 
            this.cbbKabKota.BackColor = System.Drawing.Color.White;
            this.cbbKabKota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKabKota.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKabKota.FormattingEnabled = true;
            this.cbbKabKota.Location = new System.Drawing.Point(210, 63);
            this.cbbKabKota.Name = "cbbKabKota";
            this.cbbKabKota.Size = new System.Drawing.Size(622, 25);
            this.cbbKabKota.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Kabupaten / Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "ALamat Lengkap";
            // 
            // FormLokasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbKabKota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.NamaLokasiTextBox);
            this.MaximizeBox = false;
            this.Name = "FormLokasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLokasi";
            this.Load += new System.EventHandler(this.FormLokasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox NamaLokasiTextBox;
        internal System.Windows.Forms.ComboBox cbbKabKota;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKabKota;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatLokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn latKabKota;
        private System.Windows.Forms.DataGridViewTextBoxColumn longKabKota;
        private System.Windows.Forms.DataGridViewButtonColumn detilLokasi;
    }
}