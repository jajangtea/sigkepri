namespace sigkepri
{
    partial class FormPerusahaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerusahaan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtCari = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.idPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlpTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NamaPerusahaanTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AlamatTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel1.Controls.Add(this.txtCari);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.btnHapus);
            this.Panel1.Controls.Add(this.btnRefresh);
            this.Panel1.Controls.Add(this.btnCari);
            this.Panel1.Controls.Add(this.btnTambah);
            this.Panel1.Controls.Add(this.btnEdit);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.lblStatus);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(260, 506);
            this.Panel1.TabIndex = 21;
            // 
            // txtCari
            // 
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.White;
            this.txtCari.HintForeColor = System.Drawing.Color.White;
            this.txtCari.HintText = "Nama Perusahaan";
            this.txtCari.isPassword = false;
            this.txtCari.LineFocusedColor = System.Drawing.Color.Yellow;
            this.txtCari.LineIdleColor = System.Drawing.Color.White;
            this.txtCari.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCari.LineThickness = 2;
            this.txtCari.Location = new System.Drawing.Point(12, 285);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(237, 33);
            this.txtCari.TabIndex = 22;
            this.txtCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCari.OnValueChanged += new System.EventHandler(this.txtCari_OnValueChanged);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(12, 239);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(236, 46);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Form berikut digunakan untuk mengelola data perusahaan.";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Yellow;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Navy;
            this.btnHapus.Location = new System.Drawing.Point(35, 437);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(189, 30);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(133, 325);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Aqua;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.Navy;
            this.btnCari.Location = new System.Drawing.Point(35, 325);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(92, 30);
            this.btnCari.TabIndex = 0;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Yellow;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Navy;
            this.btnTambah.Location = new System.Drawing.Point(35, 369);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(189, 30);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Navy;
            this.btnEdit.Location = new System.Drawing.Point(35, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(189, 30);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(60, 90);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(140, 133);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(33, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(194, 25);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "DATA PERUSAHAAN";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(271, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(196, 25);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Input Data Perusahaan";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPerusahaan,
            this.namaPerusahaan,
            this.tlp,
            this.alamat});
            this.dgvList.Location = new System.Drawing.Point(266, 175);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(711, 288);
            this.dgvList.TabIndex = 18;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // idPerusahaan
            // 
            this.idPerusahaan.DataPropertyName = "idPerusahaan";
            this.idPerusahaan.HeaderText = "id";
            this.idPerusahaan.Name = "idPerusahaan";
            this.idPerusahaan.ReadOnly = true;
            this.idPerusahaan.Visible = false;
            this.idPerusahaan.Width = 40;
            // 
            // namaPerusahaan
            // 
            this.namaPerusahaan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.namaPerusahaan.DataPropertyName = "namaPerusahaan";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.namaPerusahaan.DefaultCellStyle = dataGridViewCellStyle1;
            this.namaPerusahaan.HeaderText = "Nama";
            this.namaPerusahaan.Name = "namaPerusahaan";
            this.namaPerusahaan.ReadOnly = true;
            this.namaPerusahaan.Width = 160;
            // 
            // tlp
            // 
            this.tlp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tlp.DataPropertyName = "tlp";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tlp.DefaultCellStyle = dataGridViewCellStyle2;
            this.tlp.HeaderText = "Telepon";
            this.tlp.Name = "tlp";
            this.tlp.ReadOnly = true;
            this.tlp.Width = 150;
            // 
            // alamat
            // 
            this.alamat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.alamat.DataPropertyName = "alamat";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alamat.DefaultCellStyle = dataGridViewCellStyle3;
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 330;
            // 
            // TlpTextBox
            // 
            this.TlpTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TlpTextBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TlpTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TlpTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.TlpTextBox.HintText = "Telepon / HP";
            this.TlpTextBox.isPassword = false;
            this.TlpTextBox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.TlpTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.TlpTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.TlpTextBox.LineThickness = 2;
            this.TlpTextBox.Location = new System.Drawing.Point(271, 92);
            this.TlpTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TlpTextBox.Name = "TlpTextBox";
            this.TlpTextBox.Size = new System.Drawing.Size(706, 33);
            this.TlpTextBox.TabIndex = 16;
            this.TlpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NamaPerusahaanTextBox
            // 
            this.NamaPerusahaanTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaPerusahaanTextBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPerusahaanTextBox.ForeColor = System.Drawing.Color.Black;
            this.NamaPerusahaanTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.NamaPerusahaanTextBox.HintText = "Nama Perusahaan";
            this.NamaPerusahaanTextBox.isPassword = false;
            this.NamaPerusahaanTextBox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.NamaPerusahaanTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NamaPerusahaanTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NamaPerusahaanTextBox.LineThickness = 2;
            this.NamaPerusahaanTextBox.Location = new System.Drawing.Point(271, 52);
            this.NamaPerusahaanTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NamaPerusahaanTextBox.Name = "NamaPerusahaanTextBox";
            this.NamaPerusahaanTextBox.Size = new System.Drawing.Size(706, 33);
            this.NamaPerusahaanTextBox.TabIndex = 15;
            this.NamaPerusahaanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AlamatTextBox
            // 
            this.AlamatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AlamatTextBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlamatTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AlamatTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.AlamatTextBox.HintText = "Alamat";
            this.AlamatTextBox.isPassword = false;
            this.AlamatTextBox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.AlamatTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.AlamatTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.AlamatTextBox.LineThickness = 2;
            this.AlamatTextBox.Location = new System.Drawing.Point(271, 132);
            this.AlamatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlamatTextBox.Name = "AlamatTextBox";
            this.AlamatTextBox.Size = new System.Drawing.Size(706, 36);
            this.AlamatTextBox.TabIndex = 17;
            this.AlamatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(266, 469);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(711, 30);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormPerusahaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 506);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.TlpTextBox);
            this.Controls.Add(this.NamaPerusahaanTextBox);
            this.Controls.Add(this.AlamatTextBox);
            this.Controls.Add(this.btnSimpan);
            this.MaximizeBox = false;
            this.Name = "FormPerusahaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perusahaan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPerusahaan_FormClosing);
            this.Load += new System.EventHandler(this.FormPerusahaan_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgvList;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox TlpTextBox;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox NamaPerusahaanTextBox;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox AlamatTextBox;
        internal System.Windows.Forms.Button btnSimpan;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCari;
        internal System.Windows.Forms.Button btnCari;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}