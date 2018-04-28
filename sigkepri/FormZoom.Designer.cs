namespace sigkepri
{
    partial class FormZoom
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
            this.LabelPath = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Button1 = new System.Windows.Forms.Button();
            this.ZoomPictureBox1 = new ZPBlib.ZoomPictureBox();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPath
            // 
            this.LabelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelPath.Location = new System.Drawing.Point(104, 8);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(362, 30);
            this.LabelPath.TabIndex = 6;
            this.LabelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.LabelPath);
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(878, 46);
            this.Panel2.TabIndex = 8;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.RadioButton3);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(469, 8);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(401, 30);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Zoom Mode";
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Checked = true;
            this.RadioButton3.Location = new System.Drawing.Point(299, -1);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(97, 17);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Mouse Position";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(194, -1);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(88, 17);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "Center Image";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(88, -1);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(92, 17);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.Text = "Center Control";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Crimson;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(11, 8);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(93, 30);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Buka Gambar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ZoomPictureBox1
            // 
            this.ZoomPictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ZoomPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomPictureBox1.EnableMouseDragging = true;
            this.ZoomPictureBox1.EnableMouseWheelZooming = true;
            this.ZoomPictureBox1.Image = null;
            this.ZoomPictureBox1.ImagePosition = new System.Drawing.Point(0, 0);
            this.ZoomPictureBox1.Location = new System.Drawing.Point(0, 46);
            this.ZoomPictureBox1.MaximumZoomFactor = 64D;
            this.ZoomPictureBox1.MinimumImageHeight = 10;
            this.ZoomPictureBox1.MinimumImageWidth = 10;
            this.ZoomPictureBox1.MouseWheelDivisor = 4000;
            this.ZoomPictureBox1.Name = "ZoomPictureBox1";
            this.ZoomPictureBox1.Size = new System.Drawing.Size(878, 389);
            this.ZoomPictureBox1.TabIndex = 9;
            this.ZoomPictureBox1.ZoomFactor = 0D;
            // 
            // FormZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(878, 435);
            this.Controls.Add(this.ZoomPictureBox1);
            this.Controls.Add(this.Panel2);
            this.Name = "FormZoom";
            this.Text = "FormZoom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormZoom_FormClosing);
            this.Panel2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabelPath;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.Button Button1;
        internal ZPBlib.ZoomPictureBox ZoomPictureBox1;
    }
}