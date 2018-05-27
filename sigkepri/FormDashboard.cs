using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(64, 0, 64);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Login Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuUtama fm = new FormMenuUtama();
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Text = "" ;
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
    }
}
