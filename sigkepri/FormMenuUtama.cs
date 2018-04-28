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
    public partial class FormMenuUtama : Form
    {
      
        public FormMenuUtama()
        {
            InitializeComponent();
            // outerPanel1.Width -= 20;
            // customScrollbar2.Left -= 20;
            //pt = new Point(this.innerPanel1.AutoScrollPosition.X, this.innerPanel1.AutoScrollPosition.Y);
            //this.customScrollbar2.Minimum = 0;
            //this.customScrollbar2.Maximum = this.innerPanel1.DisplayRectangle.Height;
            //this.customScrollbar2.LargeChange = customScrollbar2.Maximum / customScrollbar2.Height + this.innerPanel1.Height;
            //this.customScrollbar2.SmallChange = 15;
            //this.customScrollbar2.Value = Math.Abs(this.innerPanel1.AutoScrollPosition.Y);
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {

            //   xPander2.Collapse();
            // xPander3.Collapse();
            // xPander4.Collapse();
            // xPander5.Collapse();

            FormDashboard fp = new FormDashboard();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.WindowState = FormWindowState.Maximized;
            fp.BringToFront();
        }


        private void lbtnJaminan_Click(object sender, EventArgs e)
        {
            FormJaminan fp = new FormJaminan();
            fp.ShowDialog();
        }

        private void lbtnJenis_Click(object sender, EventArgs e)
        {
            FormJenisIzin fp = new FormJenisIzin();
            fp.ShowDialog();
        }

        private void lbtnBank_Click(object sender, EventArgs e)
        {
            FormBank fp = new FormBank();
            fp.ShowDialog();
        }

        private void lbtnDokumen_Click(object sender, EventArgs e)
        {
            FormDokumen fp = new FormDokumen();
            fp.ShowDialog();
        }

        private void lbtnLokasi_Click(object sender, EventArgs e)
        {
            FormLokasi fp = new FormLokasi();
            fp.ShowDialog();
        }

        private void lbtnRekom_Click(object sender, EventArgs e)
        {
            FormRekomendasi fp = new FormRekomendasi();
            fp.ShowDialog();
        }

        private void lbtnTahap_Click(object sender, EventArgs e)
        {
            FormTahapKegiatan fp = new FormTahapKegiatan();
            fp.ShowDialog();
        }

        private void lbtnBahan_Click(object sender, EventArgs e)
        {
            FormBahanGalian fp = new FormBahanGalian();
            fp.ShowDialog();
        }

        private void lbtnWiup_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }
            FormListWiup fp = new FormListWiup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.Label1.Text = "Pencarian Data WIUP";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbtnIupEp_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }

            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.lbCari.Text = "Pencarian Data IUP Ekplorasi";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbtnIupOp_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }

            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.lbCari.Text = "Pencarian Data IUP Operasi Produksi";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbtnIupIpr_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }

            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.lbCari.Text = "Pencarian Data IUP IPR";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbtnPerusahaan_Click(object sender, EventArgs e)
        {
            FormPerusahaan fp = new FormPerusahaan();
            fp.ShowDialog();
        }

        private void lbtnRekapitulasi_Click(object sender, EventArgs e)
        {
            FormRekapitulasi fr = new FormRekapitulasi();
            fr.ShowDialog();
        }
    }
}
