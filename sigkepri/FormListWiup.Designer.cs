namespace sigkepri
{
    partial class FormListWiup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListWiup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.komoditi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbbKategori = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.luas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tglIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.noIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.namaPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.idWiup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // komoditi
            // 
            this.komoditi.DataPropertyName = "namaBahanGalian";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.komoditi.DefaultCellStyle = dataGridViewCellStyle1;
            this.komoditi.HeaderText = "Komoditi";
            this.komoditi.Name = "komoditi";
            this.komoditi.ReadOnly = true;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.btnTutup);
            this.Panel4.Controls.Add(this.btnRefresh);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.cbbKategori);
            this.Panel4.Controls.Add(this.btnTambah);
            this.Panel4.Controls.Add(this.btnCari);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1095, 39);
            this.Panel4.TabIndex = 32;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.Red;
            this.btnTutup.FlatAppearance.BorderSize = 0;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.ForeColor = System.Drawing.Color.White;
            this.btnTutup.Location = new System.Drawing.Point(617, 4);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(86, 30);
            this.btnTutup.TabIndex = 35;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(443, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 30);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Crimson;
            this.Label3.Location = new System.Drawing.Point(3, 7);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(124, 25);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "Perusahaan  : ";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbKategori
            // 
            this.cbbKategori.BackColor = System.Drawing.Color.White;
            this.cbbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKategori.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKategori.FormattingEnabled = true;
            this.cbbKategori.Location = new System.Drawing.Point(128, 5);
            this.cbbKategori.Name = "cbbKategori";
            this.cbbKategori.Size = new System.Drawing.Size(241, 28);
            this.cbbKategori.TabIndex = 32;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(530, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(86, 30);
            this.btnTambah.TabIndex = 31;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Crimson;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(370, 4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(72, 30);
            this.btnCari.TabIndex = 31;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // luas
            // 
            this.luas.DataPropertyName = "luas";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.luas.DefaultCellStyle = dataGridViewCellStyle2;
            this.luas.HeaderText = "Luas";
            this.luas.Name = "luas";
            this.luas.ReadOnly = true;
            // 
            // ubah
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.ubah.DefaultCellStyle = dataGridViewCellStyle3;
            this.ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah.HeaderText = "";
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.Text = "Edit";
            this.ubah.ToolTipText = "Edit";
            this.ubah.UseColumnTextForButtonValue = true;
            this.ubah.Width = 50;
            // 
            // lokasi
            // 
            this.lokasi.DataPropertyName = "namaLokasi";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.lokasi.DefaultCellStyle = dataGridViewCellStyle4;
            this.lokasi.HeaderText = "Lokasi";
            this.lokasi.Name = "lokasi";
            this.lokasi.ReadOnly = true;
            this.lokasi.Width = 300;
            // 
            // hapus
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.hapus.DefaultCellStyle = dataGridViewCellStyle5;
            this.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus.HeaderText = "";
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.ToolTipText = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 50;
            // 
            // tglIzin
            // 
            this.tglIzin.DataPropertyName = "tglIzin";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.tglIzin.DefaultCellStyle = dataGridViewCellStyle6;
            this.tglIzin.HeaderText = "Tanggal ";
            this.tglIzin.Name = "tglIzin";
            this.tglIzin.ReadOnly = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(33, 35);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // noIzin
            // 
            this.noIzin.DataPropertyName = "noIzin";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.noIzin.DefaultCellStyle = dataGridViewCellStyle7;
            this.noIzin.HeaderText = "Nomor Izin";
            this.noIzin.Name = "noIzin";
            this.noIzin.ReadOnly = true;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1095, 35);
            this.Panel2.TabIndex = 32;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(30, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(184, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Pencarian Data WIUP";
            // 
            // namaPerusahaan
            // 
            this.namaPerusahaan.DataPropertyName = "namaPerusahaan";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.namaPerusahaan.DefaultCellStyle = dataGridViewCellStyle8;
            this.namaPerusahaan.HeaderText = "Nama Perusahaan";
            this.namaPerusahaan.Name = "namaPerusahaan";
            this.namaPerusahaan.ReadOnly = true;
            this.namaPerusahaan.Width = 200;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.dgvList);
            this.Panel3.Controls.Add(this.Panel4);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 35);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1095, 488);
            this.Panel3.TabIndex = 34;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWiup,
            this.namaPerusahaan,
            this.noIzin,
            this.tglIzin,
            this.lokasi,
            this.luas,
            this.komoditi,
            this.ubah,
            this.hapus});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 39);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1095, 449);
            this.dgvList.TabIndex = 30;
            // 
            // idWiup
            // 
            this.idWiup.DataPropertyName = "idWiup";
            this.idWiup.HeaderText = "idWiup";
            this.idWiup.Name = "idWiup";
            this.idWiup.ReadOnly = true;
            this.idWiup.Visible = false;
            // 
            // FormListWiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 523);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormListWiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListWiup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridViewTextBoxColumn komoditi;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbbKategori;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.DataGridViewTextBoxColumn luas;
        internal System.Windows.Forms.DataGridViewButtonColumn ubah;
        internal System.Windows.Forms.DataGridViewTextBoxColumn lokasi;
        internal System.Windows.Forms.DataGridViewButtonColumn hapus;
        internal System.Windows.Forms.DataGridViewTextBoxColumn tglIzin;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn noIzin;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn namaPerusahaan;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.DataGridViewTextBoxColumn idWiup;
        internal System.Windows.Forms.Button btnTutup;
    }
}