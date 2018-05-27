namespace sigkepri
{
    partial class FormJaminan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJaminan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnPencairan = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtJumlah = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSisa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbBank = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbJenisJaminan = new System.Windows.Forms.ComboBox();
            this.idJaminan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaJenisJaminan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJaminan,
            this.namaJenisJaminan,
            this.bank,
            this.jumlah,
            this.sisa});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvList.Location = new System.Drawing.Point(271, 148);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(480, 298);
            this.dgvList.TabIndex = 33;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(15, 246);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(254, 46);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Form berikut digunakan untuk mengelola data perizinan yang dilayani oleh dinas pe" +
    "rtambangan provinsi Kepri.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(278, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(169, 25);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Input Data Jaminan";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Yellow;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Navy;
            this.btnHapus.Location = new System.Drawing.Point(43, 400);
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
            this.btnTambah.Location = new System.Drawing.Point(43, 332);
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
            this.btnSimpan.Location = new System.Drawing.Point(272, 452);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(479, 30);
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
            this.btnEdit.Location = new System.Drawing.Point(43, 366);
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
            this.Panel1.Controls.Add(this.btnPencairan);
            this.Panel1.Controls.Add(this.btnHapus);
            this.Panel1.Controls.Add(this.btnTambah);
            this.Panel1.Controls.Add(this.btnEdit);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(269, 488);
            this.Panel1.TabIndex = 36;
            // 
            // btnPencairan
            // 
            this.btnPencairan.BackColor = System.Drawing.Color.Aqua;
            this.btnPencairan.FlatAppearance.BorderSize = 0;
            this.btnPencairan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencairan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPencairan.ForeColor = System.Drawing.Color.Black;
            this.btnPencairan.Location = new System.Drawing.Point(43, 434);
            this.btnPencairan.Name = "btnPencairan";
            this.btnPencairan.Size = new System.Drawing.Size(182, 30);
            this.btnPencairan.TabIndex = 1;
            this.btnPencairan.Text = "Pencairan";
            this.btnPencairan.UseVisualStyleBackColor = false;
            this.btnPencairan.Click += new System.EventHandler(this.btnPencairan_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(65, 101);
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
            this.Label2.Location = new System.Drawing.Point(74, 53);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Data Jaminan";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.ForeColor = System.Drawing.Color.Black;
            this.txtJumlah.HintForeColor = System.Drawing.Color.Black;
            this.txtJumlah.HintText = "";
            this.txtJumlah.isPassword = false;
            this.txtJumlah.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtJumlah.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtJumlah.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtJumlah.LineThickness = 2;
            this.txtJumlah.Location = new System.Drawing.Point(526, 59);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(209, 33);
            this.txtJumlah.TabIndex = 32;
            this.txtJumlah.Text = " 0";
            this.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJumlah_KeyDown);
            // 
            // txtSisa
            // 
            this.txtSisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSisa.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSisa.ForeColor = System.Drawing.Color.Black;
            this.txtSisa.HintForeColor = System.Drawing.Color.Black;
            this.txtSisa.HintText = "";
            this.txtSisa.isPassword = false;
            this.txtSisa.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtSisa.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtSisa.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtSisa.LineThickness = 2;
            this.txtSisa.Location = new System.Drawing.Point(526, 109);
            this.txtSisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSisa.Name = "txtSisa";
            this.txtSisa.Size = new System.Drawing.Size(209, 33);
            this.txtSisa.TabIndex = 32;
            this.txtSisa.Text = " 0";
            this.txtSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label4.Location = new System.Drawing.Point(523, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Sisa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label5.Location = new System.Drawing.Point(523, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Jumlah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label7.Location = new System.Drawing.Point(280, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Bank";
            // 
            // cbbBank
            // 
            this.cbbBank.BackColor = System.Drawing.Color.White;
            this.cbbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBank.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBank.FormattingEnabled = true;
            this.cbbBank.Location = new System.Drawing.Point(276, 64);
            this.cbbBank.Name = "cbbBank";
            this.cbbBank.Size = new System.Drawing.Size(226, 23);
            this.cbbBank.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label6.Location = new System.Drawing.Point(280, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Jenis Jaminan";
            // 
            // cbbJenisJaminan
            // 
            this.cbbJenisJaminan.BackColor = System.Drawing.Color.White;
            this.cbbJenisJaminan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJenisJaminan.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbJenisJaminan.FormattingEnabled = true;
            this.cbbJenisJaminan.Location = new System.Drawing.Point(276, 119);
            this.cbbJenisJaminan.Name = "cbbJenisJaminan";
            this.cbbJenisJaminan.Size = new System.Drawing.Size(226, 23);
            this.cbbJenisJaminan.TabIndex = 44;
            // 
            // idJaminan
            // 
            this.idJaminan.DataPropertyName = "idJaminan";
            this.idJaminan.HeaderText = "idJaminan";
            this.idJaminan.Name = "idJaminan";
            this.idJaminan.ReadOnly = true;
            this.idJaminan.Visible = false;
            this.idJaminan.Width = 97;
            // 
            // namaJenisJaminan
            // 
            this.namaJenisJaminan.DataPropertyName = "namaJenisJaminan";
            this.namaJenisJaminan.HeaderText = "Jenis Jaminan";
            this.namaJenisJaminan.Name = "namaJenisJaminan";
            this.namaJenisJaminan.ReadOnly = true;
            this.namaJenisJaminan.Width = 120;
            // 
            // bank
            // 
            this.bank.DataPropertyName = "namaBank";
            this.bank.HeaderText = "Bank";
            this.bank.Name = "bank";
            this.bank.ReadOnly = true;
            this.bank.Width = 63;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = "0";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jumlah.DefaultCellStyle = dataGridViewCellStyle14;
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            this.jumlah.Width = 78;
            // 
            // sisa
            // 
            this.sisa.DataPropertyName = "sisa";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = "0";
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sisa.DefaultCellStyle = dataGridViewCellStyle15;
            this.sisa.HeaderText = "Sisa";
            this.sisa.Name = "sisa";
            this.sisa.ReadOnly = true;
            this.sisa.Width = 57;
            // 
            // FormJaminan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 488);
            this.Controls.Add(this.cbbJenisJaminan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbBank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.txtSisa);
            this.Controls.Add(this.txtJumlah);
            this.MaximizeBox = false;
            this.Name = "FormJaminan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJaminan";
            this.Load += new System.EventHandler(this.FormJaminan_Load);
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
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtJumlah;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtSisa;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cbbBank;
        internal System.Windows.Forms.Button btnPencairan;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cbbJenisJaminan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJaminan;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaJenisJaminan;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisa;
    }
}