using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZPBlib;

namespace sigkepri
{

    public partial class FormZoom : Form
    {

        public FormZoom()
        {
            InitializeComponent();
        }

        private void FormZoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            ZoomPictureBox1.Image.Dispose();
            ZoomPictureBox1.Image = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        public void pilihPeta(int kota)
        {
            switch (kota)
            {
                case 1:
                    {
                        try
                        {
                            string id = "19-Tanjungpinang";
                            string folder = "Z:\\ESDM\\Peta\\Geologi\\";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                           MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 2:
                    {
                        try
                        {
                            string id = "24-Dabo";
                            string folder = "Z:\\ESDM\\Peta\\Geologi\\";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 3:
                    {
                        try
                        {
                            string id = "44-Tarempa & Jemaja";
                            string folder = "Z:\\ESDM\\Peta\\Geologi\\";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 4:
                    {
                        try
                        {
                            string id = "45-Teluk Butun & Ranai";
                            string folder = "Z:\\ESDM\\Peta\\Geologi\\";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 5:
                    {
                        try
                        {
                            string id = "46-Kep Natuna Selatan";
                            string folder = "Z:\\ESDM\\Peta\\Geologi\\";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 6:
                    {
                        try
                        {
                            string id = "47-Tambelan";
                            string folder = "Z:\\ESDM\\Peta\\Geologi\\";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                           
                        }

                        break;
                    }

                case 7:
                    {
                        try
                        {
                            string id = "Bengkalis-Siak Sriindrapura";
                            string folder = "Z:\\ESDM\\Peta\\Hidrologi";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 8:
                    {
                        try
                        {
                            string id = "Bunguran";
                            string folder = "Z:\\ESDM\\Peta\\Hidrologi";
                            string filename = System.IO.Path.Combine(folder, id + ".BMP");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                             MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 9:
                    {
                        try
                        {
                            string id = "Dabo";
                            string folder = "Z:\\ESDM\\Peta\\Hidrologi";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                           MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                case 10:
                    {
                        try
                        {
                            string id = "Natuna";
                            string folder = "Z:\\ESDM\\Peta\\Hidrologi";
                            string filename = System.IO.Path.Combine(folder, id + ".jpg");
                            LabelPath.Text = filename;
                            ZoomPictureBox1.Image = Image.FromFile(filename);
                            ZoomPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        }
                        catch (Exception ex)
                        {
                           MessageBox.Show(ex.Message);
                        }

                        break;
                    }

                default:
                    {
                        //MsgBox("Peta tidak ditemukan", MsgBoxStyle.Critical);
                        break;
                    }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.ControlCenter;
            }
            else if (RadioButton2.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.ImageCenter;
            }
            else if (RadioButton3.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.MousePosition;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.ControlCenter;
            }
            else if (RadioButton2.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.ImageCenter;
            }
            else if (RadioButton3.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.MousePosition;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.ControlCenter;
            }
            else if (RadioButton2.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.ImageCenter;
            }
            else if (RadioButton3.Checked == true)
            {
                ZoomPictureBox1.ZoomMode = ZoomPictureBox.ZoomType.MousePosition;
            }
        }
    }
}
