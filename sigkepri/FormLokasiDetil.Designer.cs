namespace sigkepri
{
    partial class FormLokasiDetil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLokasiDetil));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtLongitude = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLatitude = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.idLokasiDetil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(89, 90);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(82, 86);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(63, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(134, 25);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "DETIL LOKASI";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.button1);
            this.Panel1.Controls.Add(this.btnImport);
            this.Panel1.Controls.Add(this.btnHapus);
            this.Panel1.Controls.Add(this.btnTambah);
            this.Panel1.Controls.Add(this.btnEdit);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.lblStatus);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(260, 506);
            this.Panel1.TabIndex = 28;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(8, 198);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(245, 46);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Form berikut digunakan untuk mengelola data perusahaan.";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Crimson;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(163, 376);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(62, 30);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Simpan ";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Yellow;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Navy;
            this.btnHapus.Location = new System.Drawing.Point(36, 329);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(189, 30);
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
            this.btnTambah.Location = new System.Drawing.Point(36, 261);
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
            this.btnEdit.Location = new System.Drawing.Point(36, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(189, 30);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLokasiDetil,
            this.idLokasi,
            this.plat,
            this.pLong});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvList.Location = new System.Drawing.Point(270, 132);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(280, 335);
            this.dgvList.TabIndex = 25;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(270, 469);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(280, 30);
            this.btnSimpan.TabIndex = 26;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongitude.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLongitude.HintForeColor = System.Drawing.Color.Empty;
            this.txtLongitude.HintText = "Longitude";
            this.txtLongitude.isPassword = false;
            this.txtLongitude.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtLongitude.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLongitude.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLongitude.LineThickness = 2;
            this.txtLongitude.Location = new System.Drawing.Point(273, 92);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(275, 33);
            this.txtLongitude.TabIndex = 23;
            this.txtLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLatitude.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.ForeColor = System.Drawing.Color.Black;
            this.txtLatitude.HintForeColor = System.Drawing.Color.Empty;
            this.txtLatitude.HintText = "Latitude";
            this.txtLatitude.isPassword = false;
            this.txtLatitude.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtLatitude.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLatitude.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLatitude.LineThickness = 2;
            this.txtLatitude.Location = new System.Drawing.Point(273, 52);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(275, 33);
            this.txtLatitude.TabIndex = 22;
            this.txtLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(273, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(168, 25);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Input Data Polygon";
            // 
            // ofdSelect
            // 
            this.ofdSelect.FileName = "openFileDialog1";
            this.ofdSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSelect_FileOk);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(36, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import File Excell";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idLokasiDetil
            // 
            this.idLokasiDetil.DataPropertyName = "idLokasiDetil";
            this.idLokasiDetil.HeaderText = "id";
            this.idLokasiDetil.Name = "idLokasiDetil";
            this.idLokasiDetil.ReadOnly = true;
            this.idLokasiDetil.Visible = false;
            this.idLokasiDetil.Width = 45;
            // 
            // idLokasi
            // 
            this.idLokasi.DataPropertyName = "idLokasi";
            this.idLokasi.HeaderText = "idLokasi";
            this.idLokasi.Name = "idLokasi";
            this.idLokasi.ReadOnly = true;
            this.idLokasi.Visible = false;
            this.idLokasi.Width = 84;
            // 
            // plat
            // 
            this.plat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.plat.DataPropertyName = "plat";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plat.DefaultCellStyle = dataGridViewCellStyle18;
            this.plat.HeaderText = "Latitude (Y)";
            this.plat.Name = "plat";
            this.plat.ReadOnly = true;
            // 
            // pLong
            // 
            this.pLong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pLong.DataPropertyName = "pLong";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pLong.DefaultCellStyle = dataGridViewCellStyle19;
            this.pLong.HeaderText = "Longitude (X)";
            this.pLong.Name = "pLong";
            this.pLong.ReadOnly = true;
            // 
            // FormLokasiDetil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 506);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLokasiDetil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLokasiDetil";
            this.Load += new System.EventHandler(this.FormLokasiDetil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.Button btnSimpan;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtLongitude;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtLatitude;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ofdSelect;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLokasiDetil;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn plat;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLong;
    }
}