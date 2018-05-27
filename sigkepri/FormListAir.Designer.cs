namespace sigkepri
{
    partial class FormListAir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListAir));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pelaporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.cadanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumen = new System.Windows.Forms.ToolStripMenuItem();
            this.wIUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmWiup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sumberDayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.btnTutup = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbbPerusahaan = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.idIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglKadaluarsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaBerlaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.cmWiup.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pelaporanToolStripMenuItem
            // 
            this.pelaporanToolStripMenuItem.Name = "pelaporanToolStripMenuItem";
            this.pelaporanToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.pelaporanToolStripMenuItem.Text = "Pelaporan";
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
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Controls.Add(this.LabelInfo);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1079, 35);
            this.Panel2.TabIndex = 35;
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.LabelInfo.ForeColor = System.Drawing.Color.White;
            this.LabelInfo.Location = new System.Drawing.Point(30, 5);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(36, 25);
            this.LabelInfo.TabIndex = 0;
            this.LabelInfo.Text = "---";
            // 
            // cadanganToolStripMenuItem
            // 
            this.cadanganToolStripMenuItem.Name = "cadanganToolStripMenuItem";
            this.cadanganToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.cadanganToolStripMenuItem.Text = "Cadangan";
            // 
            // dokumen
            // 
            this.dokumen.Name = "dokumen";
            this.dokumen.Size = new System.Drawing.Size(170, 26);
            this.dokumen.Text = "Dokumen";
            this.dokumen.Click += new System.EventHandler(this.dokumen_Click);
            // 
            // wIUPToolStripMenuItem
            // 
            this.wIUPToolStripMenuItem.Name = "wIUPToolStripMenuItem";
            this.wIUPToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.wIUPToolStripMenuItem.Text = "Perizinan";
            // 
            // cmWiup
            // 
            this.cmWiup.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmWiup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wIUPToolStripMenuItem,
            this.dokumen,
            this.sumberDayaToolStripMenuItem,
            this.cadanganToolStripMenuItem,
            this.pelaporanToolStripMenuItem});
            this.cmWiup.Name = "contextMenuStrip1";
            this.cmWiup.Size = new System.Drawing.Size(171, 134);
            // 
            // sumberDayaToolStripMenuItem
            // 
            this.sumberDayaToolStripMenuItem.Name = "sumberDayaToolStripMenuItem";
            this.sumberDayaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.sumberDayaToolStripMenuItem.Text = "Sumber Daya";
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
            // Panel4
            // 
            this.Panel4.Controls.Add(this.btnTutup);
            this.Panel4.Controls.Add(this.btnRefresh);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.cbbPerusahaan);
            this.Panel4.Controls.Add(this.btnTambah);
            this.Panel4.Controls.Add(this.btnCari);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1079, 39);
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
            // cbbPerusahaan
            // 
            this.cbbPerusahaan.BackColor = System.Drawing.Color.White;
            this.cbbPerusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPerusahaan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.cbbPerusahaan.FormattingEnabled = true;
            this.cbbPerusahaan.Location = new System.Drawing.Point(128, 7);
            this.cbbPerusahaan.Name = "cbbPerusahaan";
            this.cbbPerusahaan.Size = new System.Drawing.Size(241, 25);
            this.cbbPerusahaan.TabIndex = 32;
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
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.dgvList);
            this.Panel3.Controls.Add(this.Panel4);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 35);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1079, 449);
            this.Panel3.TabIndex = 36;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIzin,
            this.namaPerusahaan,
            this.noIzin,
            this.tglIzin,
            this.tglKadaluarsa,
            this.masaBerlaku,
            this.lokasi,
            this.ubah,
            this.hapus});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvList.Location = new System.Drawing.Point(0, 39);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1079, 410);
            this.dgvList.TabIndex = 30;
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // idIzin
            // 
            this.idIzin.DataPropertyName = "idIzinPerusahaanAir";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.idIzin.DefaultCellStyle = dataGridViewCellStyle2;
            this.idIzin.HeaderText = "idIzin";
            this.idIzin.Name = "idIzin";
            this.idIzin.ReadOnly = true;
            this.idIzin.Visible = false;
            this.idIzin.Width = 67;
            // 
            // namaPerusahaan
            // 
            this.namaPerusahaan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.namaPerusahaan.DataPropertyName = "namaPerusahaan";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.namaPerusahaan.DefaultCellStyle = dataGridViewCellStyle3;
            this.namaPerusahaan.HeaderText = "Nama Perusahaan";
            this.namaPerusahaan.Name = "namaPerusahaan";
            this.namaPerusahaan.ReadOnly = true;
            this.namaPerusahaan.Width = 150;
            // 
            // noIzin
            // 
            this.noIzin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.noIzin.DataPropertyName = "nomorSK";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.noIzin.DefaultCellStyle = dataGridViewCellStyle4;
            this.noIzin.HeaderText = "Nomor SK";
            this.noIzin.Name = "noIzin";
            this.noIzin.ReadOnly = true;
            this.noIzin.Width = 180;
            // 
            // tglIzin
            // 
            this.tglIzin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tglIzin.DataPropertyName = "tglBerlaku";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tglIzin.DefaultCellStyle = dataGridViewCellStyle5;
            this.tglIzin.HeaderText = "Tanggal Berlaku";
            this.tglIzin.Name = "tglIzin";
            this.tglIzin.ReadOnly = true;
            this.tglIzin.Width = 85;
            // 
            // tglKadaluarsa
            // 
            this.tglKadaluarsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tglKadaluarsa.DataPropertyName = "tglKadaluwarsa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.tglKadaluarsa.DefaultCellStyle = dataGridViewCellStyle6;
            this.tglKadaluarsa.HeaderText = "Tanggal Kadaluarsa";
            this.tglKadaluarsa.Name = "tglKadaluarsa";
            this.tglKadaluarsa.ReadOnly = true;
            this.tglKadaluarsa.Width = 85;
            // 
            // masaBerlaku
            // 
            this.masaBerlaku.DataPropertyName = "masaBerlaku";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            this.masaBerlaku.DefaultCellStyle = dataGridViewCellStyle7;
            this.masaBerlaku.HeaderText = "Masa Berlaku (Bulan)";
            this.masaBerlaku.Name = "masaBerlaku";
            this.masaBerlaku.ReadOnly = true;
            this.masaBerlaku.Width = 150;
            // 
            // lokasi
            // 
            this.lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lokasi.DataPropertyName = "alamatLokasi";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lokasi.DefaultCellStyle = dataGridViewCellStyle8;
            this.lokasi.HeaderText = "Lokasi";
            this.lokasi.Name = "lokasi";
            this.lokasi.ReadOnly = true;
            this.lokasi.Width = 180;
            // 
            // ubah
            // 
            this.ubah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ubah.ContextMenuStrip = this.cmWiup;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.ubah.DefaultCellStyle = dataGridViewCellStyle9;
            this.ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah.HeaderText = "";
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.Text = "Edit";
            this.ubah.ToolTipText = "Edit";
            this.ubah.UseColumnTextForButtonValue = true;
            this.ubah.Width = 80;
            // 
            // hapus
            // 
            this.hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.hapus.DefaultCellStyle = dataGridViewCellStyle10;
            this.hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus.HeaderText = "";
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.ToolTipText = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 80;
            // 
            // FormListAir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 484);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListAir";
            this.Text = "FormListAir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListAir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.cmWiup.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem pelaporanToolStripMenuItem;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.ToolStripMenuItem cadanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumen;
        private System.Windows.Forms.ToolStripMenuItem wIUPToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmWiup;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button btnTutup;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbbPerusahaan;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn noIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglKadaluarsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaBerlaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasi;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.ToolStripMenuItem sumberDayaToolStripMenuItem;
    }
}