namespace sigkepri
{
    partial class FormWiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWiup));
            this.Label6 = new System.Windows.Forms.Label();
            this.tglPicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtLuas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NoIzinTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bdKomoditi = new System.Windows.Forms.ComboBox();
            this.bdLokasi = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.bdPerusahaan = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label6.Location = new System.Drawing.Point(231, 133);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 17);
            this.Label6.TabIndex = 44;
            this.Label6.Text = "Tanggal ";
            // 
            // tglPicker
            // 
            this.tglPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.tglPicker.BorderRadius = 0;
            this.tglPicker.ForeColor = System.Drawing.Color.White;
            this.tglPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tglPicker.FormatCustom = null;
            this.tglPicker.Location = new System.Drawing.Point(231, 157);
            this.tglPicker.Name = "tglPicker";
            this.tglPicker.Size = new System.Drawing.Size(485, 28);
            this.tglPicker.TabIndex = 43;
            this.tglPicker.Value = new System.DateTime(2018, 4, 15, 23, 7, 38, 907);
            // 
            // txtLuas
            // 
            this.txtLuas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuas.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuas.ForeColor = System.Drawing.Color.Black;
            this.txtLuas.HintForeColor = System.Drawing.Color.Black;
            this.txtLuas.HintText = "Luas";
            this.txtLuas.isPassword = false;
            this.txtLuas.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtLuas.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLuas.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.txtLuas.LineThickness = 2;
            this.txtLuas.Location = new System.Drawing.Point(231, 249);
            this.txtLuas.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuas.Name = "txtLuas";
            this.txtLuas.Size = new System.Drawing.Size(485, 33);
            this.txtLuas.TabIndex = 42;
            this.txtLuas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NoIzinTextBox
            // 
            this.NoIzinTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NoIzinTextBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoIzinTextBox.ForeColor = System.Drawing.Color.Black;
            this.NoIzinTextBox.HintForeColor = System.Drawing.Color.Black;
            this.NoIzinTextBox.HintText = "No Izin";
            this.NoIzinTextBox.isPassword = false;
            this.NoIzinTextBox.LineFocusedColor = System.Drawing.Color.Crimson;
            this.NoIzinTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NoIzinTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.NoIzinTextBox.LineThickness = 2;
            this.NoIzinTextBox.Location = new System.Drawing.Point(231, 93);
            this.NoIzinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoIzinTextBox.Name = "NoIzinTextBox";
            this.NoIzinTextBox.Size = new System.Drawing.Size(485, 33);
            this.NoIzinTextBox.TabIndex = 41;
            this.NoIzinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bdKomoditi
            // 
            this.bdKomoditi.BackColor = System.Drawing.Color.White;
            this.bdKomoditi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bdKomoditi.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdKomoditi.FormattingEnabled = true;
            this.bdKomoditi.Location = new System.Drawing.Point(231, 309);
            this.bdKomoditi.Name = "bdKomoditi";
            this.bdKomoditi.Size = new System.Drawing.Size(485, 28);
            this.bdKomoditi.TabIndex = 39;
            // 
            // bdLokasi
            // 
            this.bdLokasi.BackColor = System.Drawing.Color.White;
            this.bdLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bdLokasi.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdLokasi.FormattingEnabled = true;
            this.bdLokasi.Location = new System.Drawing.Point(231, 216);
            this.bdLokasi.Name = "bdLokasi";
            this.bdLokasi.Size = new System.Drawing.Size(485, 28);
            this.bdLokasi.TabIndex = 40;
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
            this.Label7.Location = new System.Drawing.Point(231, 287);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(57, 17);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "Komoditi";
            // 
            // bdPerusahaan
            // 
            this.bdPerusahaan.BackColor = System.Drawing.Color.White;
            this.bdPerusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bdPerusahaan.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdPerusahaan.FormattingEnabled = true;
            this.bdPerusahaan.Location = new System.Drawing.Point(231, 60);
            this.bdPerusahaan.Name = "bdPerusahaan";
            this.bdPerusahaan.Size = new System.Drawing.Size(485, 28);
            this.bdPerusahaan.TabIndex = 38;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label5.Location = new System.Drawing.Point(231, 194);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(45, 17);
            this.Label5.TabIndex = 36;
            this.Label5.Text = "Lokasi ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.Label4.Location = new System.Drawing.Point(231, 38);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 17);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Perusahaan ";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Crimson;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(231, 346);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(488, 35);
            this.btnSimpan.TabIndex = 32;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(58, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Data WIUP";
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
            this.Panel1.Size = new System.Drawing.Size(217, 392);
            this.Panel1.TabIndex = 34;
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
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Label1.Location = new System.Drawing.Point(229, 2);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(148, 25);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Input Data WIUP";
            // 
            // FormWiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 392);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.tglPicker);
            this.Controls.Add(this.txtLuas);
            this.Controls.Add(this.NoIzinTextBox);
            this.Controls.Add(this.bdKomoditi);
            this.Controls.Add(this.bdLokasi);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.bdPerusahaan);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.Name = "FormWiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWiup";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal Bunifu.Framework.UI.BunifuDatepicker tglPicker;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtLuas;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox NoIzinTextBox;
        internal System.Windows.Forms.ComboBox bdKomoditi;
        internal System.Windows.Forms.ComboBox bdLokasi;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox bdPerusahaan;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
    }
}