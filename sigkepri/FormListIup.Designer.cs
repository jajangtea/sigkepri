﻿namespace sigkepri
{
    partial class FormListIup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListIup));
            this.btnCari = new System.Windows.Forms.Button();
            this.komoditi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luasWilayahPenunjang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.btnTutup = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbbKategori = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tglKadaluarsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPerizinan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.idWiup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCari = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
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
            // komoditi
            // 
            this.komoditi.DataPropertyName = "namaBahanGalian";
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.komoditi.DefaultCellStyle = dataGridViewCellStyle13;
            this.komoditi.HeaderText = "Komoditi";
            this.komoditi.Name = "komoditi";
            this.komoditi.ReadOnly = true;
            // 
            // luasWilayahPenunjang
            // 
            this.luasWilayahPenunjang.DataPropertyName = "luasWilayahPenunjang";
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.luasWilayahPenunjang.DefaultCellStyle = dataGridViewCellStyle14;
            this.luasWilayahPenunjang.HeaderText = "Luas Wil. Penunjang (ha)";
            this.luasWilayahPenunjang.Name = "luasWilayahPenunjang";
            this.luasWilayahPenunjang.ReadOnly = true;
            this.luasWilayahPenunjang.Width = 50;
            // 
            // luas
            // 
            this.luas.DataPropertyName = "luasWilayahTambang";
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.luas.DefaultCellStyle = dataGridViewCellStyle15;
            this.luas.HeaderText = "Luas Wil. Tambang (ha)";
            this.luas.Name = "luas";
            this.luas.ReadOnly = true;
            this.luas.Width = 50;
            // 
            // lokasi
            // 
            this.lokasi.DataPropertyName = "namaLokasi";
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.lokasi.DefaultCellStyle = dataGridViewCellStyle16;
            this.lokasi.HeaderText = "Lokasi";
            this.lokasi.Name = "lokasi";
            this.lokasi.ReadOnly = true;
            this.lokasi.Width = 200;
            // 
            // ubah
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            this.ubah.DefaultCellStyle = dataGridViewCellStyle17;
            this.ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah.HeaderText = "";
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.Text = "Edit";
            this.ubah.ToolTipText = "Edit";
            this.ubah.UseColumnTextForButtonValue = true;
            this.ubah.Width = 50;
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
            // hapus
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            this.hapus.DefaultCellStyle = dataGridViewCellStyle18;
            this.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus.HeaderText = "";
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.ToolTipText = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 50;
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
            this.btnTutup.TabIndex = 36;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
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
            // tglKadaluarsa
            // 
            this.tglKadaluarsa.DataPropertyName = "tglKadaluwarsa";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.tglKadaluarsa.DefaultCellStyle = dataGridViewCellStyle19;
            this.tglKadaluarsa.HeaderText = "Tanggal Kadaluarsa";
            this.tglKadaluarsa.Name = "tglKadaluarsa";
            this.tglKadaluarsa.ReadOnly = true;
            this.tglKadaluarsa.Width = 80;
            // 
            // tglIzin
            // 
            this.tglIzin.DataPropertyName = "tglBerlaku";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.tglIzin.DefaultCellStyle = dataGridViewCellStyle20;
            this.tglIzin.HeaderText = "Tanggal Berlaku";
            this.tglIzin.Name = "tglIzin";
            this.tglIzin.ReadOnly = true;
            this.tglIzin.Width = 80;
            // 
            // namaPerizinan
            // 
            this.namaPerizinan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namaPerizinan.DataPropertyName = "namaPerizinan";
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.namaPerizinan.DefaultCellStyle = dataGridViewCellStyle21;
            this.namaPerizinan.HeaderText = "Nama Perizinan";
            this.namaPerizinan.Name = "namaPerizinan";
            this.namaPerizinan.ReadOnly = true;
            this.namaPerizinan.Width = 97;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(34, 6);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(196, 25);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Input Data Perusahaan";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.dgvList);
            this.Panel3.Controls.Add(this.Panel4);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 35);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1095, 452);
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
            this.namaPerizinan,
            this.tglIzin,
            this.tglKadaluarsa,
            this.lokasi,
            this.luas,
            this.luasWilayahPenunjang,
            this.komoditi,
            this.ubah,
            this.hapus});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 39);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1095, 413);
            this.dgvList.TabIndex = 30;
            // 
            // idWiup
            // 
            this.idWiup.DataPropertyName = "idIzinPerusahaan";
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            this.idWiup.DefaultCellStyle = dataGridViewCellStyle22;
            this.idWiup.HeaderText = "idWiup";
            this.idWiup.Name = "idWiup";
            this.idWiup.ReadOnly = true;
            this.idWiup.Visible = false;
            // 
            // namaPerusahaan
            // 
            this.namaPerusahaan.DataPropertyName = "namaPerusahaan";
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            this.namaPerusahaan.DefaultCellStyle = dataGridViewCellStyle23;
            this.namaPerusahaan.HeaderText = "Nama Perusahaan";
            this.namaPerusahaan.Name = "namaPerusahaan";
            this.namaPerusahaan.ReadOnly = true;
            this.namaPerusahaan.Width = 150;
            // 
            // noIzin
            // 
            this.noIzin.DataPropertyName = "nomorSK";
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.noIzin.DefaultCellStyle = dataGridViewCellStyle24;
            this.noIzin.HeaderText = "Nomor SK";
            this.noIzin.Name = "noIzin";
            this.noIzin.ReadOnly = true;
            this.noIzin.Width = 150;
            // 
            // lbCari
            // 
            this.lbCari.AutoSize = true;
            this.lbCari.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.lbCari.ForeColor = System.Drawing.Color.White;
            this.lbCari.Location = new System.Drawing.Point(30, 5);
            this.lbCari.Name = "lbCari";
            this.lbCari.Size = new System.Drawing.Size(36, 25);
            this.lbCari.TabIndex = 0;
            this.lbCari.Text = "---";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Controls.Add(this.lbCari);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1095, 35);
            this.Panel2.TabIndex = 32;
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
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 487);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1095, 36);
            this.Panel1.TabIndex = 33;
            // 
            // FormListIup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 523);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormListIup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListIup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.DataGridViewTextBoxColumn komoditi;
        internal System.Windows.Forms.DataGridViewTextBoxColumn luasWilayahPenunjang;
        internal System.Windows.Forms.DataGridViewTextBoxColumn luas;
        internal System.Windows.Forms.DataGridViewTextBoxColumn lokasi;
        internal System.Windows.Forms.DataGridViewButtonColumn ubah;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.DataGridViewButtonColumn hapus;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbbKategori;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.DataGridViewTextBoxColumn tglKadaluarsa;
        internal System.Windows.Forms.DataGridViewTextBoxColumn tglIzin;
        internal System.Windows.Forms.DataGridViewTextBoxColumn namaPerizinan;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.DataGridViewTextBoxColumn idWiup;
        internal System.Windows.Forms.DataGridViewTextBoxColumn namaPerusahaan;
        internal System.Windows.Forms.DataGridViewTextBoxColumn noIzin;
        internal System.Windows.Forms.Label lbCari;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnTutup;
    }
}