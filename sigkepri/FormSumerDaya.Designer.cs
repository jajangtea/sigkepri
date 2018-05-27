namespace sigkepri
{
    partial class FormSumerDaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSumerDaya));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtHipotetik = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTereka = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTerunjuk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTerukur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTahun = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDeskripsi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idSdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hipotetik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tereka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terunjuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terukur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
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
            this.Panel1.Size = new System.Drawing.Size(269, 385);
            this.Panel1.TabIndex = 37;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(14, 221);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(254, 46);
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
            this.btnHapus.Location = new System.Drawing.Point(43, 343);
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
            this.btnTambah.Location = new System.Drawing.Point(43, 275);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(182, 30);
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
            this.btnEdit.Location = new System.Drawing.Point(43, 309);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 30);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(64, 76);
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
            this.Label2.Location = new System.Drawing.Point(73, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Sumber Daya";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSdc,
            this.tahun,
            this.hipotetik,
            this.tereka,
            this.terunjuk,
            this.terukur,
            this.deskripsi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.Location = new System.Drawing.Point(275, 184);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(574, 158);
            this.dgvList.TabIndex = 39;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(275, 349);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(574, 30);
            this.btnSimpan.TabIndex = 40;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(275, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(169, 25);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Input Sumber Daya";
            // 
            // txtHipotetik
            // 
            this.txtHipotetik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHipotetik.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHipotetik.ForeColor = System.Drawing.Color.Black;
            this.txtHipotetik.HintForeColor = System.Drawing.Color.Black;
            this.txtHipotetik.HintText = "";
            this.txtHipotetik.isPassword = false;
            this.txtHipotetik.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtHipotetik.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtHipotetik.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtHipotetik.LineThickness = 2;
            this.txtHipotetik.Location = new System.Drawing.Point(275, 96);
            this.txtHipotetik.Margin = new System.Windows.Forms.Padding(4);
            this.txtHipotetik.Name = "txtHipotetik";
            this.txtHipotetik.Size = new System.Drawing.Size(305, 33);
            this.txtHipotetik.TabIndex = 38;
            this.txtHipotetik.Text = "0";
            this.txtHipotetik.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTereka
            // 
            this.txtTereka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTereka.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTereka.ForeColor = System.Drawing.Color.Black;
            this.txtTereka.HintForeColor = System.Drawing.Color.Black;
            this.txtTereka.HintText = "";
            this.txtTereka.isPassword = false;
            this.txtTereka.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtTereka.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTereka.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTereka.LineThickness = 2;
            this.txtTereka.Location = new System.Drawing.Point(275, 144);
            this.txtTereka.Margin = new System.Windows.Forms.Padding(4);
            this.txtTereka.Name = "txtTereka";
            this.txtTereka.Size = new System.Drawing.Size(305, 33);
            this.txtTereka.TabIndex = 38;
            this.txtTereka.Text = "0";
            this.txtTereka.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTerunjuk
            // 
            this.txtTerunjuk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTerunjuk.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerunjuk.ForeColor = System.Drawing.Color.Black;
            this.txtTerunjuk.HintForeColor = System.Drawing.Color.Black;
            this.txtTerunjuk.HintText = "";
            this.txtTerunjuk.isPassword = false;
            this.txtTerunjuk.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtTerunjuk.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerunjuk.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerunjuk.LineThickness = 2;
            this.txtTerunjuk.Location = new System.Drawing.Point(599, 44);
            this.txtTerunjuk.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerunjuk.Name = "txtTerunjuk";
            this.txtTerunjuk.Size = new System.Drawing.Size(238, 33);
            this.txtTerunjuk.TabIndex = 38;
            this.txtTerunjuk.Text = "0";
            this.txtTerunjuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTerukur
            // 
            this.txtTerukur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTerukur.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerukur.ForeColor = System.Drawing.Color.Black;
            this.txtTerukur.HintForeColor = System.Drawing.Color.Black;
            this.txtTerukur.HintText = "";
            this.txtTerukur.isPassword = false;
            this.txtTerukur.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtTerukur.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerukur.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtTerukur.LineThickness = 2;
            this.txtTerukur.Location = new System.Drawing.Point(599, 96);
            this.txtTerukur.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerukur.Name = "txtTerukur";
            this.txtTerukur.Size = new System.Drawing.Size(238, 33);
            this.txtTerukur.TabIndex = 38;
            this.txtTerukur.Text = "0";
            this.txtTerukur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 50;
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
            this.cbbTahun.Location = new System.Drawing.Point(275, 48);
            this.cbbTahun.Name = "cbbTahun";
            this.cbbTahun.Size = new System.Drawing.Size(305, 25);
            this.cbbTahun.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Terunjuk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Terukur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Hipotetik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tereka";
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
            this.cbbDeskripsi.Location = new System.Drawing.Point(599, 152);
            this.cbbDeskripsi.Name = "cbbDeskripsi";
            this.cbbDeskripsi.Size = new System.Drawing.Size(238, 25);
            this.cbbDeskripsi.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(602, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = "Deskripsi";
            // 
            // idSdc
            // 
            this.idSdc.DataPropertyName = "idSdc";
            this.idSdc.HeaderText = "idSdc";
            this.idSdc.Name = "idSdc";
            this.idSdc.ReadOnly = true;
            this.idSdc.Visible = false;
            // 
            // tahun
            // 
            this.tahun.DataPropertyName = "tahun";
            this.tahun.HeaderText = "Tahun";
            this.tahun.Name = "tahun";
            this.tahun.ReadOnly = true;
            // 
            // hipotetik
            // 
            this.hipotetik.DataPropertyName = "hipotetik";
            this.hipotetik.HeaderText = "Hipotetik";
            this.hipotetik.Name = "hipotetik";
            this.hipotetik.ReadOnly = true;
            this.hipotetik.Width = 80;
            // 
            // tereka
            // 
            this.tereka.DataPropertyName = "tereka";
            this.tereka.HeaderText = "Tereka";
            this.tereka.Name = "tereka";
            this.tereka.ReadOnly = true;
            this.tereka.Width = 80;
            // 
            // terunjuk
            // 
            this.terunjuk.DataPropertyName = "terunjuk";
            this.terunjuk.HeaderText = "Terunjuk";
            this.terunjuk.Name = "terunjuk";
            this.terunjuk.ReadOnly = true;
            this.terunjuk.Width = 80;
            // 
            // terukur
            // 
            this.terukur.DataPropertyName = "terukur";
            this.terukur.HeaderText = "Terukur";
            this.terukur.Name = "terukur";
            this.terukur.ReadOnly = true;
            this.terukur.Width = 80;
            // 
            // deskripsi
            // 
            this.deskripsi.DataPropertyName = "deskripsi";
            this.deskripsi.HeaderText = "Deskripsi";
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.ReadOnly = true;
            // 
            // FormSumerDaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 385);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbDeskripsi);
            this.Controls.Add(this.cbbTahun);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtTerukur);
            this.Controls.Add(this.txtTerunjuk);
            this.Controls.Add(this.txtTereka);
            this.Controls.Add(this.txtHipotetik);
            this.Controls.Add(this.Panel1);
            this.Name = "FormSumerDaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumber Daya";
            this.Load += new System.EventHandler(this.FormSumerDaya_Load);
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
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtHipotetik;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTereka;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTerunjuk;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTerukur;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cbbTahun;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cbbDeskripsi;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSdc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn hipotetik;
        private System.Windows.Forms.DataGridViewTextBoxColumn tereka;
        private System.Windows.Forms.DataGridViewTextBoxColumn terunjuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn terukur;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
    }
}