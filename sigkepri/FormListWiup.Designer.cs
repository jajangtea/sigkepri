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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListWiup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.cbbPerusahaan = new System.Windows.Forms.ComboBox();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cmWiup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wIUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.idWiup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komoditi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmWiup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.cbbPerusahaan);
            this.Panel4.Controls.Add(this.btnTutup);
            this.Panel4.Controls.Add(this.btnRefresh);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.btnTambah);
            this.Panel4.Controls.Add(this.btnCari);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1095, 39);
            this.Panel4.TabIndex = 32;
            // 
            // cbbPerusahaan
            // 
            this.cbbPerusahaan.BackColor = System.Drawing.Color.White;
            this.cbbPerusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPerusahaan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPerusahaan.FormattingEnabled = true;
            this.cbbPerusahaan.Location = new System.Drawing.Point(119, 5);
            this.cbbPerusahaan.Name = "cbbPerusahaan";
            this.cbbPerusahaan.Size = new System.Drawing.Size(247, 25);
            this.cbbPerusahaan.TabIndex = 41;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.Red;
            this.btnTutup.FlatAppearance.BorderSize = 0;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(370, 4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(72, 30);
            this.btnCari.TabIndex = 31;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
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
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(30, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(173, 21);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Pencarian Data WIUP";
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
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.Gray;
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
            this.idWiup,
            this.namaPerusahaan,
            this.noIzin,
            this.tglIzin,
            this.lokasi,
            this.luas,
            this.komoditi,
            this.Edit,
            this.delete});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvList.Location = new System.Drawing.Point(0, 39);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1095, 449);
            this.dgvList.TabIndex = 30;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // cmWiup
            // 
            this.cmWiup.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmWiup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wIUPToolStripMenuItem});
            this.cmWiup.Name = "contextMenuStrip1";
            this.cmWiup.Size = new System.Drawing.Size(118, 30);
            // 
            // wIUPToolStripMenuItem
            // 
            this.wIUPToolStripMenuItem.Name = "wIUPToolStripMenuItem";
            this.wIUPToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.wIUPToolStripMenuItem.Text = "WIUP";
            this.wIUPToolStripMenuItem.Click += new System.EventHandler(this.wIUPToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // idWiup
            // 
            this.idWiup.DataPropertyName = "idWiup";
            this.idWiup.HeaderText = "idWiup";
            this.idWiup.Name = "idWiup";
            this.idWiup.ReadOnly = true;
            this.idWiup.Visible = false;
            this.idWiup.Width = 78;
            // 
            // namaPerusahaan
            // 
            this.namaPerusahaan.DataPropertyName = "namaPerusahaan";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.namaPerusahaan.DefaultCellStyle = dataGridViewCellStyle2;
            this.namaPerusahaan.FillWeight = 87.8327F;
            this.namaPerusahaan.HeaderText = "Nama Perusahaan";
            this.namaPerusahaan.Name = "namaPerusahaan";
            this.namaPerusahaan.ReadOnly = true;
            this.namaPerusahaan.Width = 132;
            // 
            // noIzin
            // 
            this.noIzin.DataPropertyName = "noIzin";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.noIzin.DefaultCellStyle = dataGridViewCellStyle3;
            this.noIzin.FillWeight = 87.3511F;
            this.noIzin.HeaderText = "Nomor Izin";
            this.noIzin.Name = "noIzin";
            this.noIzin.ReadOnly = true;
            this.noIzin.Width = 94;
            // 
            // tglIzin
            // 
            this.tglIzin.DataPropertyName = "tglIzin";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.tglIzin.DefaultCellStyle = dataGridViewCellStyle4;
            this.tglIzin.FillWeight = 102.6489F;
            this.tglIzin.HeaderText = "Tanggal ";
            this.tglIzin.Name = "tglIzin";
            this.tglIzin.ReadOnly = true;
            this.tglIzin.Width = 86;
            // 
            // lokasi
            // 
            this.lokasi.DataPropertyName = "alamatLokasi";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.lokasi.DefaultCellStyle = dataGridViewCellStyle5;
            this.lokasi.FillWeight = 103.9231F;
            this.lokasi.HeaderText = "Lokasi";
            this.lokasi.Name = "lokasi";
            this.lokasi.ReadOnly = true;
            this.lokasi.Width = 72;
            // 
            // luas
            // 
            this.luas.DataPropertyName = "luas";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.luas.DefaultCellStyle = dataGridViewCellStyle6;
            this.luas.FillWeight = 103.2089F;
            this.luas.HeaderText = "Luas";
            this.luas.Name = "luas";
            this.luas.ReadOnly = true;
            this.luas.Width = 61;
            // 
            // komoditi
            // 
            this.komoditi.DataPropertyName = "namaBahanGalian";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.komoditi.DefaultCellStyle = dataGridViewCellStyle7;
            this.komoditi.FillWeight = 174.708F;
            this.komoditi.HeaderText = "Komoditi";
            this.komoditi.Name = "komoditi";
            this.komoditi.ReadOnly = true;
            this.komoditi.Width = 90;
            // 
            // Edit
            // 
            this.Edit.ContextMenuStrip = this.cmWiup;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle8;
            this.Edit.FillWeight = 40.32725F;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 19;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.delete.FillWeight = 40.32725F;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 75;
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
            this.Load += new System.EventHandler(this.FormListWiup_Load);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmWiup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.ContextMenuStrip cmWiup;
        private System.Windows.Forms.ToolStripMenuItem wIUPToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.ComboBox cbbPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWiup;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn noIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn luas;
        private System.Windows.Forms.DataGridViewTextBoxColumn komoditi;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}