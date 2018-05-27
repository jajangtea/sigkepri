using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sigkepri.FormReporting;

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
            //FormDashboard fp = new FormDashboard();
            //fp.TopLevel = false;
            //SplitContainer1.Panel2.Controls.Add(fp);
            //fp.Show();
            //fp.WindowState = FormWindowState.Maximized;
            //fp.BringToFront();
            //this.SplitContainer1.Panel1.Hide();
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
            //fp.Label1.Text = "1";
           // fp.tampilGrid();
            fp.BringToFront();
        }

        private void lbiupe_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp._idtahapKegiatan = "1";
            fp.LabelInfo.Text = "Pencarian Data IUP Ekplorasi";
            fp.Show();
            fp.BringToFront();
        }

        private void lbiupep_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp._idtahapKegiatan = "2";
            fp.LabelInfo.Text = "Pencarian Data IUP Ekplorasi Produksi";
            fp.Show();
            fp.BringToFront();
        }

        private void lbiupipr_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp._idtahapKegiatan = "3";
            fp.LabelInfo.Text = "Pencarian Data IUP IPR";
            fp.Show();
            fp.BringToFront();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            FormRekap fp = new FormRekap();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.BringToFront();
        }

        private void tanjungpinangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(1);
            fz.ShowDialog();
        }

        private void daboToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(2);
            fz.ShowDialog();
        }

        private void tarempaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(3);
            fz.ShowDialog();
        }

        private void telukButunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(4);
            fz.ShowDialog();
        }

        private void ranaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(8);
            fz.ShowDialog();
        }

        private void natunaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(9);
            fz.ShowDialog();
        }

        private void lbOffline_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "Z:\\OK\\DemoMap.exe";
            p.Start();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            FormJenisIzin fp = new FormJenisIzin();
            fp.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            FormBank fp = new FormBank();
            fp.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            FormDokumen fp = new FormDokumen();
            fp.ShowDialog();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            FormLokasi fp = new FormLokasi();
            fp.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            FormTahapKegiatan fp = new FormTahapKegiatan();
            fp.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            FormBahanGalian fp = new FormBahanGalian();
            fp.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormListAir fp = new FormListAir();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.LabelInfo.Text = "Pencarian Data Sumber Daya Air";
            fp.Show();
            fp.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            //FormDashboard fp = new FormDashboard();
            //fp.TopLevel = false;
            //SplitContainer1.Panel2.Controls.Add(fp);
            //fp.Show();
            //fp.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmAbout fb = new frmAbout();
            fb.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormWiupReport fb = new FormWiupReport();
            fb.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormPrintLaporan fb = new FormPrintLaporan();
            fb.ShowDialog();
        }

        private void hodrologiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
