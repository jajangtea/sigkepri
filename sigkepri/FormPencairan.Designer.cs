namespace sigkepri
{
    partial class FormPencairan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPencairan));
            this.tglCair = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtJmlCair = new System.Windows.Forms.MaskedTextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.idJaminan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSisa = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tglCair
            // 
            this.tglCair.BackColor = System.Drawing.Color.SeaGreen;
            this.tglCair.BorderRadius = 0;
            this.tglCair.ForeColor = System.Drawing.Color.White;
            this.tglCair.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglCair.FormatCustom = null;
            this.tglCair.Location = new System.Drawing.Point(275, 67);
            this.tglCair.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tglCair.Name = "tglCair";
            this.tglCair.Size = new System.Drawing.Size(370, 34);
            this.tglCair.TabIndex = 0;
            this.tglCair.Value = new System.DateTime(2018, 5, 11, 2, 33, 55, 650);
            // 
            // txtJmlCair
            // 
            this.txtJmlCair.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJmlCair.Location = new System.Drawing.Point(275, 127);
            this.txtJmlCair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJmlCair.Name = "txtJmlCair";
            this.txtJmlCair.Size = new System.Drawing.Size(370, 27);
            this.txtJmlCair.TabIndex = 1;
            this.txtJmlCair.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJmlCair_KeyDown);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJaminan,
            this.bank,
            this.jumlah});
            this.dgvList.Location = new System.Drawing.Point(275, 162);
            this.dgvList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(370, 234);
            this.dgvList.TabIndex = 34;
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // idJaminan
            // 
            this.idJaminan.DataPropertyName = "idPencairan";
            this.idJaminan.HeaderText = "idPencairan";
            this.idJaminan.Name = "idJaminan";
            this.idJaminan.ReadOnly = true;
            this.idJaminan.Visible = false;
            this.idJaminan.Width = 105;
            // 
            // bank
            // 
            this.bank.DataPropertyName = "tglPencairan";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.bank.DefaultCellStyle = dataGridViewCellStyle1;
            this.bank.HeaderText = "Tanggal";
            this.bank.Name = "bank";
            this.bank.ReadOnly = true;
            this.bank.Width = 77;
            // 
            // jumlah
            // 
            this.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.jumlah.DataPropertyName = "pencairan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jumlah.DefaultCellStyle = dataGridViewCellStyle2;
            this.jumlah.HeaderText = "Pencairan";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            this.jumlah.Width = 200;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.lbSisa);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.btnHapus);
            this.Panel1.Controls.Add(this.btnTambah);
            this.Panel1.Controls.Add(this.btnEdit);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(269, 434);
            this.Panel1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(1, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sisa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSisa
            // 
            this.lbSisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSisa.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSisa.ForeColor = System.Drawing.Color.White;
            this.lbSisa.Location = new System.Drawing.Point(1, 245);
            this.lbSisa.Name = "lbSisa";
            this.lbSisa.Size = new System.Drawing.Size(266, 30);
            this.lbSisa.TabIndex = 18;
            this.lbSisa.Text = "Rp.1000.0000.000";
            this.lbSisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(16, 182);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(230, 33);
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
            this.btnHapus.Location = new System.Drawing.Point(44, 363);
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
            this.btnTambah.Location = new System.Drawing.Point(44, 295);
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
            this.btnEdit.Location = new System.Drawing.Point(44, 329);
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
            this.PictureBox1.Location = new System.Drawing.Point(86, 71);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(96, 96);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(75, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Data Pencairan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.label5.Location = new System.Drawing.Point(275, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Input Data Jaminan";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(275, 401);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(370, 30);
            this.btnSimpan.TabIndex = 39;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(276, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Jml. Pencairan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label6.Location = new System.Drawing.Point(276, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Jml. Tanggal";
            // 
            // FormPencairan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.txtJmlCair);
            this.Controls.Add(this.tglCair);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPencairan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPencairan";
            this.Load += new System.EventHandler(this.FormPencairan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker tglCair;
        private System.Windows.Forms.MaskedTextBox txtJmlCair;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lbSisa;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJaminan;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
    }
}