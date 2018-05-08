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
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            xPander10.Collapse();
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
            fp.LabelInfo.Text = "Pencarian Data IUP Ekplorasi";
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
            fp.LabelInfo.Text = "Pencarian Data IUP Operasi Produksi";
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
            fp.LabelInfo.Text = "Pencarian Data IUP IPR";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbtnPerusahaan_Click(object sender, EventArgs e)
        {
            FormPerusahaan fp = new FormPerusahaan();
            fp.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormRekap fp = new FormRekap();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.BringToFront();
        }

        private void lbOnline_Click(object sender, EventArgs e)
        {
            FormGreatMap fg = new FormGreatMap();
            fg.Show();
        }

        private void lbJaminan_Click(object sender, EventArgs e)
        {
            FormJaminan fj = new FormJaminan();
            fj.ShowDialog();
        }

        private void lbtnWiup_Click(object sender, EventArgs e)
        {

            FormListWiup fp = new FormListWiup(this);
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.Label1.Text = "Pencarian Data WIUP";
            fp.Label1.Text = "1";
           // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbiupe_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.LabelInfo.Text = "Pencarian Data IUP Eplorasi";
            //fp.LabelInfo.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbiupep_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.LabelInfo.Text = "Pencarian Data IUP Ekplorasi Produksi";
            //fp.LabelInfo.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbiupipr_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.LabelInfo.Text = "Pencarian Data IUP IPR";
            //fp.LabelInfo.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }
    }
}
