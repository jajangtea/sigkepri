namespace sigkepri
{
    partial class FormDokumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDokumen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.NamaDokumenTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cbbJenisDokumen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idDokumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDokumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDokumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
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
            this.Panel1.Size = new System.Drawing.Size(269, 387);
            this.Panel1.TabIndex = 36;
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
            this.Label2.Location = new System.Drawing.Point(67, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(135, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Data Dokumen";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(278, 349);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(458, 30);
            this.btnSimpan.TabIndex = 34;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(278, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(182, 25);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Input Data Dokumen";
            // 
            // NamaDokumenTextBox
            // 
            this.NamaDokumenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaDokumenTextBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaDokumenTextBox.ForeColor = System.Drawing.Color.Black;
            this.NamaDokumenTextBox.HintForeColor = System.Drawing.Color.Black;
            this.NamaDokumenTextBox.HintText = "";
            this.NamaDokumenTextBox.isPassword = false;
            this.NamaDokumenTextBox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.NamaDokumenTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NamaDokumenTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NamaDokumenTextBox.LineThickness = 2;
            this.NamaDokumenTextBox.Location = new System.Drawing.Point(279, 51);
            this.NamaDokumenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NamaDokumenTextBox.Name = "NamaDokumenTextBox";
            this.NamaDokumenTextBox.Size = new System.Drawing.Size(457, 33);
            this.NamaDokumenTextBox.TabIndex = 32;
            this.NamaDokumenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDokumen,
            this.namaDokumen,
            this.jenisDokumen});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.Location = new System.Drawing.Point(278, 141);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(458, 201);
            this.dgvList.TabIndex = 33;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // cbbJenisDokumen
            // 
            this.cbbJenisDokumen.BackColor = System.Drawing.Color.White;
            this.cbbJenisDokumen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJenisDokumen.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbJenisDokumen.FormattingEnabled = true;
            this.cbbJenisDokumen.Location = new System.Drawing.Point(278, 110);
            this.cbbJenisDokumen.Name = "cbbJenisDokumen";
            this.cbbJenisDokumen.Size = new System.Drawing.Size(458, 25);
            this.cbbJenisDokumen.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Jenis Dokumen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nama Dokumen";
            // 
            // idDokumen
            // 
            this.idDokumen.DataPropertyName = "idDokumen";
            this.idDokumen.HeaderText = "idDokumen";
            this.idDokumen.Name = "idDokumen";
            this.idDokumen.ReadOnly = true;
            this.idDokumen.Visible = false;
            // 
            // namaDokumen
            // 
            this.namaDokumen.DataPropertyName = "namaDokumen";
            this.namaDokumen.HeaderText = "Nama Dokumen";
            this.namaDokumen.Name = "namaDokumen";
            this.namaDokumen.ReadOnly = true;
            this.namaDokumen.Width = 180;
            // 
            // jenisDokumen
            // 
            this.jenisDokumen.DataPropertyName = "namaJenisDokumen";
            this.jenisDokumen.HeaderText = "Jenis Dokumen";
            this.jenisDokumen.Name = "jenisDokumen";
            this.jenisDokumen.ReadOnly = true;
            this.jenisDokumen.Width = 200;
            // 
            // FormDokumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbJenisDokumen);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.NamaDokumenTextBox);
            this.Controls.Add(this.dgvList);
            this.MaximizeBox = false;
            this.Name = "FormDokumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokumen";
            this.Load += new System.EventHandler(this.FormDokumen_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnTambah;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox NamaDokumenTextBox;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.ComboBox cbbJenisDokumen;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDokumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDokumen;
    }
}