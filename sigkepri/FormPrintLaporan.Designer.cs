namespace sigkepri
{
    partial class FormPrintLaporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintLaporan));
            this.cbbTahapKegiatan = new System.Windows.Forms.ComboBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTahapKegiatan
            // 
            this.cbbTahapKegiatan.FormattingEnabled = true;
            this.cbbTahapKegiatan.Location = new System.Drawing.Point(12, 75);
            this.cbbTahapKegiatan.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTahapKegiatan.Name = "cbbTahapKegiatan";
            this.cbbTahapKegiatan.Size = new System.Drawing.Size(332, 25);
            this.cbbTahapKegiatan.TabIndex = 0;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbbStatus.Location = new System.Drawing.Point(12, 127);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(332, 25);
            this.cbbStatus.TabIndex = 0;
            this.cbbStatus.Text = "Pilih";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Crimson;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Image = ((System.Drawing.Image)(resources.GetObject("btnCari.Image")));
            this.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCari.Location = new System.Drawing.Point(272, 160);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(72, 30);
            this.btnCari.TabIndex = 35;
            this.btnCari.Text = "    Batal ";
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tahap Kegiatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(185, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "    Cetak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(104)))), ((int)(((byte)(116)))));
            this.Panel2.Controls.Add(this.LabelInfo);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(362, 35);
            this.Panel2.TabIndex = 39;
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.LabelInfo.ForeColor = System.Drawing.Color.White;
            this.LabelInfo.Location = new System.Drawing.Point(88, 5);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(187, 25);
            this.LabelInfo.TabIndex = 1;
            this.LabelInfo.Text = "CETAK LAPORAN IUP";
            // 
            // FormPrintLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 199);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbTahapKegiatan);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrintLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan IUP";
            this.Load += new System.EventHandler(this.FormPrintLaporan_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTahapKegiatan;
        private System.Windows.Forms.ComboBox cbbStatus;
        internal System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label LabelInfo;
    }
}