namespace sigkepri
{
    partial class FormCadangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadangan));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTahun = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTerkira = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTerbukti = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbDeskripsi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idCadangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terkira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terbukti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Terbukti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Terkira";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tahun";
            // 
            // cbbTahun
            // 
            this.cbbTahun.BackColor = System.Drawing.Color.White;
            this.cbbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTahun.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTahun.FormattingEnabled = true;
            this.cbbTahun.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbbTahun.Location = new System.Drawing.Point(208, 51);
            this.cbbTahun.Name = "cbbTahun";
            this.cbbTahun.Size = new System.Drawing.Size(229, 25);
            this.cbbTahun.TabIndex = 59;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCadangan,
            this.tahun,
            this.terkira,
            this.terbukti,
            this.deskripsi});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.Location = new System.Drawing.Point(208, 130);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(451, 207);
            this.dgvList.TabIndex = 56;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(208, 343);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(451, 30);
            this.btnSimpan.TabIndex = 57;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(208, 2);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(187, 25);
            this.Label1.TabIndex = 58;
            this.Label1.Text = "Input Data Cadangan";
            // 
            // txtTerkira
            // 
            this.txtTerkira.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTerkira.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerkira.ForeColor = System.Drawing.Color.Black;
            this.txtTerkira.HintForeColor = System.Drawing.Color.Black;
            this.txtTerkira.HintText = "";
            this.txtTerkira.isPassword = false;
            this.txtTerkira.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtTerkira.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerkira.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerkira.LineThickness = 2;
            this.txtTerkira.Location = new System.Drawing.Point(456, 44);
            this.txtTerkira.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerkira.Name = "txtTerkira";
            this.txtTerkira.Size = new System.Drawing.Size(203, 33);
            this.txtTerkira.TabIndex = 53;
            this.txtTerkira.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTerbukti
            // 
            this.txtTerbukti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTerbukti.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerbukti.ForeColor = System.Drawing.Color.Black;
            this.txtTerbukti.HintForeColor = System.Drawing.Color.Black;
            this.txtTerbukti.HintText = "";
            this.txtTerbukti.isPassword = false;
            this.txtTerbukti.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtTerbukti.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerbukti.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerbukti.LineThickness = 2;
            this.txtTerbukti.Location = new System.Drawing.Point(456, 90);
            this.txtTerbukti.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerbukti.Name = "txtTerbukti";
            this.txtTerbukti.Size = new System.Drawing.Size(203, 33);
            this.txtTerbukti.TabIndex = 55;
            this.txtTerbukti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(23, 215);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(157, 46);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Form berikut digunakan untuk mengelola data perizinan yang dilayani oleh dinas pe" +
    "rtambangan provinsi Kepri.";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Yellow;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Navy;
            this.btnHapus.Location = new System.Drawing.Point(38, 332);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(128, 30);
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
            this.btnTambah.Location = new System.Drawing.Point(38, 264);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(128, 30);
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
            this.btnEdit.Location = new System.Drawing.Point(38, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 30);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(14, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(175, 63);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Data Sumber Daya Cadangan";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Panel1.Size = new System.Drawing.Size(202, 385);
            this.Panel1.TabIndex = 51;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(58, 116);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(86, 83);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // cbbDeskripsi
            // 
            this.cbbDeskripsi.BackColor = System.Drawing.Color.White;
            this.cbbDeskripsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeskripsi.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDeskripsi.FormattingEnabled = true;
            this.cbbDeskripsi.Items.AddRange(new object[] {
            "Mineral",
            "Batuan"});
            this.cbbDeskripsi.Location = new System.Drawing.Point(208, 99);
            this.cbbDeskripsi.Name = "cbbDeskripsi";
            this.cbbDeskripsi.Size = new System.Drawing.Size(229, 25);
            this.cbbDeskripsi.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "Deskripsi";
            // 
            // idCadangan
            // 
            this.idCadangan.DataPropertyName = "idCadangan";
            this.idCadangan.HeaderText = "idCadangan";
            this.idCadangan.Name = "idCadangan";
            this.idCadangan.ReadOnly = true;
            this.idCadangan.Visible = false;
            // 
            // tahun
            // 
            this.tahun.DataPropertyName = "tahun";
            this.tahun.HeaderText = "Tahun";
            this.tahun.Name = "tahun";
            this.tahun.ReadOnly = true;
            // 
            // terkira
            // 
            this.terkira.DataPropertyName = "terkira";
            this.terkira.HeaderText = "Terkira";
            this.terkira.Name = "terkira";
            this.terkira.ReadOnly = true;
            this.terkira.Width = 80;
            // 
            // terbukti
            // 
            this.terbukti.DataPropertyName = "terbukti";
            this.terbukti.HeaderText = "Terbukti";
            this.terbukti.Name = "terbukti";
            this.terbukti.ReadOnly = true;
            this.terbukti.Width = 80;
            // 
            // deskripsi
            // 
            this.deskripsi.DataPropertyName = "deskripsi";
            this.deskripsi.HeaderText = "Deskripsi";
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.ReadOnly = true;
            // 
            // FormCadangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 385);
            this.Controls.Add(this.cbbDeskripsi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbTahun);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtTerkira);
            this.Controls.Add(this.txtTerbukti);
            this.Controls.Add(this.Panel1);
            this.Name = "FormCadangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadangan";
            this.Load += new System.EventHandler(this.FormCadangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cbbTahun;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTerkira;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTerbukti;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox cbbDeskripsi;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCadangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn terkira;
        private System.Windows.Forms.DataGridViewTextBoxColumn terbukti;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
    }
}