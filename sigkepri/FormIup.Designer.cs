namespace sigkepri
{
    partial class FormIup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIup));
            this.Label9 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.tk = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tb = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtLuasPenunjang = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLuasTambang = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomorSK = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbbKomoditi = new System.Windows.Forms.ComboBox();
            this.cbbLokasi = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.cbbJenisPerizinan = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.cbbPerusahaan = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label9.Location = new System.Drawing.Point(520, 105);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(119, 17);
            this.Label9.TabIndex = 62;
            this.Label9.Text = "Tanggal Kadaluwarsa";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label11.Location = new System.Drawing.Point(520, 40);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(93, 17);
            this.Label11.TabIndex = 61;
            this.Label11.Text = "Tanggal Berlaku";
            // 
            // tk
            // 
            this.tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.tk.BorderRadius = 0;
            this.tk.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.tk.ForeColor = System.Drawing.Color.White;
            this.tk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tk.FormatCustom = null;
            this.tk.Location = new System.Drawing.Point(520, 132);
            this.tk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(269, 28);
            this.tk.TabIndex = 60;
            this.tk.Value = new System.DateTime(2018, 4, 15, 23, 7, 38, 907);
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.tb.BorderRadius = 0;
            this.tb.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.tb.ForeColor = System.Drawing.Color.White;
            this.tb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tb.FormatCustom = null;
            this.tb.Location = new System.Drawing.Point(520, 67);
            this.tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(269, 28);
            this.tb.TabIndex = 59;
            this.tb.Value = new System.DateTime(2018, 4, 15, 23, 7, 38, 907);
            // 
            // txtLuasPenunjang
            // 
            this.txtLuasPenunjang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuasPenunjang.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuasPenunjang.ForeColor = System.Drawing.Color.Black;
            this.txtLuasPenunjang.HintForeColor = System.Drawing.Color.Black;
            this.txtLuasPenunjang.HintText = "Luas Wilayah Penunjang";
            this.txtLuasPenunjang.isPassword = false;
            this.txtLuasPenunjang.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtLuasPenunjang.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLuasPenunjang.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLuasPenunjang.LineThickness = 2;
            this.txtLuasPenunjang.Location = new System.Drawing.Point(520, 238);
            this.txtLuasPenunjang.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuasPenunjang.Name = "txtLuasPenunjang";
            this.txtLuasPenunjang.Size = new System.Drawing.Size(269, 30);
            this.txtLuasPenunjang.TabIndex = 58;
            this.txtLuasPenunjang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLuasTambang
            // 
            this.txtLuasTambang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuasTambang.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuasTambang.ForeColor = System.Drawing.Color.Black;
            this.txtLuasTambang.HintForeColor = System.Drawing.Color.Black;
            this.txtLuasTambang.HintText = "Luas Wilayah Tambang";
            this.txtLuasTambang.isPassword = false;
            this.txtLuasTambang.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtLuasTambang.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLuasTambang.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLuasTambang.LineThickness = 2;
            this.txtLuasTambang.Location = new System.Drawing.Point(520, 170);
            this.txtLuasTambang.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuasTambang.Name = "txtLuasTambang";
            this.txtLuasTambang.Size = new System.Drawing.Size(269, 33);
            this.txtLuasTambang.TabIndex = 57;
            this.txtLuasTambang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNomorSK
            // 
            this.txtNomorSK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomorSK.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomorSK.ForeColor = System.Drawing.Color.Black;
            this.txtNomorSK.HintForeColor = System.Drawing.Color.Black;
            this.txtNomorSK.HintText = "Nomor SK";
            this.txtNomorSK.isPassword = false;
            this.txtNomorSK.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtNomorSK.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtNomorSK.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtNomorSK.LineThickness = 2;
            this.txtNomorSK.Location = new System.Drawing.Point(231, 170);
            this.txtNomorSK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomorSK.Name = "txtNomorSK";
            this.txtNomorSK.Size = new System.Drawing.Size(269, 33);
            this.txtNomorSK.TabIndex = 56;
            this.txtNomorSK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbbKomoditi
            // 
            this.cbbKomoditi.BackColor = System.Drawing.Color.White;
            this.cbbKomoditi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKomoditi.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKomoditi.FormattingEnabled = true;
            this.cbbKomoditi.Location = new System.Drawing.Point(231, 305);
            this.cbbKomoditi.Name = "cbbKomoditi";
            this.cbbKomoditi.Size = new System.Drawing.Size(269, 28);
            this.cbbKomoditi.TabIndex = 54;
            // 
            // cbbLokasi
            // 
            this.cbbLokasi.BackColor = System.Drawing.Color.White;
            this.cbbLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLokasi.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLokasi.FormattingEnabled = true;
            this.cbbLokasi.Location = new System.Drawing.Point(231, 240);
            this.cbbLokasi.Name = "cbbLokasi";
            this.cbbLokasi.Size = new System.Drawing.Size(269, 28);
            this.cbbLokasi.TabIndex = 55;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(36, 210);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(157, 33);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Form berikut digunakan untuk mengelola data perusahaan.";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label7.Location = new System.Drawing.Point(231, 278);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(57, 17);
            this.Label7.TabIndex = 48;
            this.Label7.Text = "Komoditi";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label6.Location = new System.Drawing.Point(231, 213);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(45, 17);
            this.Label6.TabIndex = 49;
            this.Label6.Text = "Lokasi ";
            // 
            // cbbJenisPerizinan
            // 
            this.cbbJenisPerizinan.BackColor = System.Drawing.Color.White;
            this.cbbJenisPerizinan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJenisPerizinan.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbJenisPerizinan.FormattingEnabled = true;
            this.cbbJenisPerizinan.Location = new System.Drawing.Point(231, 132);
            this.cbbJenisPerizinan.Name = "cbbJenisPerizinan";
            this.cbbJenisPerizinan.Size = new System.Drawing.Size(269, 28);
            this.cbbJenisPerizinan.TabIndex = 53;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(217, 391);
            this.Panel1.TabIndex = 47;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(55, 89);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(107, 102);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(58, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Data IUP";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(233, 346);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(578, 35);
            this.btnSimpan.TabIndex = 45;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // cbbPerusahaan
            // 
            this.cbbPerusahaan.BackColor = System.Drawing.Color.White;
            this.cbbPerusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPerusahaan.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPerusahaan.FormattingEnabled = true;
            this.cbbPerusahaan.Location = new System.Drawing.Point(231, 67);
            this.cbbPerusahaan.Name = "cbbPerusahaan";
            this.cbbPerusahaan.Size = new System.Drawing.Size(269, 28);
            this.cbbPerusahaan.TabIndex = 52;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label4.Location = new System.Drawing.Point(231, 105);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 17);
            this.Label4.TabIndex = 50;
            this.Label4.Text = "Jenis Izin";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label8.Location = new System.Drawing.Point(231, 40);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(73, 17);
            this.Label8.TabIndex = 51;
            this.Label8.Text = "Perusahaan ";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.LabelTitle.Location = new System.Drawing.Point(231, 2);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(131, 25);
            this.LabelTitle.TabIndex = 46;
            this.LabelTitle.Text = "Input Data IUP";
            // 
            // FormIup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 391);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.txtLuasPenunjang);
            this.Controls.Add(this.txtLuasTambang);
            this.Controls.Add(this.txtNomorSK);
            this.Controls.Add(this.cbbKomoditi);
            this.Controls.Add(this.cbbLokasi);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cbbJenisPerizinan);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cbbPerusahaan);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.LabelTitle);
            this.MaximizeBox = false;
            this.Name = "FormIup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIup";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label11;
        internal Bunifu.Framework.UI.BunifuDatepicker tk;
        internal Bunifu.Framework.UI.BunifuDatepicker tb;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtLuasPenunjang;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtLuasTambang;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNomorSK;
        internal System.Windows.Forms.ComboBox cbbKomoditi;
        internal System.Windows.Forms.ComboBox cbbLokasi;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cbbJenisPerizinan;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.ComboBox cbbPerusahaan;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label LabelTitle;
    }
}