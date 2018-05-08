using System;
using System.Drawing;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

      

        

      


        private void btnBank_Click(System.Object sender, System.EventArgs e)
        {
           // FormBank.ShowDialog();
        }

        private void btnDokumen_Click(System.Object sender, System.EventArgs e)
        {
            //FormDokumen.ShowDialog();
        }

        private void btnLokasi_Click(System.Object sender, System.EventArgs e)
        {
           // FormLokasi.ShowDialog();
        }

        private void btnRekomendasi_Click(System.Object sender, System.EventArgs e)
        {
           // FormRekomendasi.ShowDialog();
        }

        private void btnTahapKegiatan_Click(System.Object sender, System.EventArgs e)
        {
           // FormTahapKegiatan.ShowDialog();
        }

        private void btnRuangan_Click(System.Object sender, System.EventArgs e)
        {
            //FormListWiup.TopLevel = false;
            //SplitContainer1.Panel2.Controls.Add(FormListWiup);
            //FormListWiup.Show();
            //FormListWiup.BringToFront();
        }

        private void btnJenis_Click(System.Object sender, System.EventArgs e)
        {
           // FormJenisIzin.ShowDialog();
        }

        private void btnJaminan_Click(System.Object sender, System.EventArgs e)
        {
           // FormJaminan.ShowDialog();
        }

        private void btnBahanGalian_Click(System.Object sender, System.EventArgs e)
        {
           // FormBahanGalian.ShowDialog();
        }

        private void btnIupE_Click(System.Object sender, System.EventArgs e)
        {
            //FormListIUP.TopLevel = false;
            //SplitContainer1.Panel2.Controls.Add(FormListIUP);
            //FormListIUP.Show();
            //FormListIUP.lbCari.Text = "Pencarian Data IUP Ekplorasi";
            //FormListIUP.Label1.Text = "1";
            //FormListIUP.tampilGrid();
            //FormListIUP.BringToFront();
        }

        private void btnIupOE_Click(System.Object sender, System.EventArgs e)
        {
            //FormListIUP.TopLevel = false;
            //SplitContainer1.Panel2.Controls.Add(FormListIUP);
            //FormListIUP.Show();
            //FormListIUP.lbCari.Text = "Pencarian Data IUP Operasi Produksi";
            //FormListIUP.Label1.Text = "2";
            //FormListIUP.tampilGrid();
            //FormListIUP.BringToFront();
        }

        

        private void lblMenu_Click(System.Object sender, System.EventArgs e)
        {
            foreach (Form ChildForm in this.SplitContainer1.Panel2.Controls)
                ChildForm.Close();
        }

        

        private void ToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
        {
            foreach (Form ChildForm in this.SplitContainer1.Panel2.Controls)
                ChildForm.Close();
        }

      


        private void MenuUtama_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Left = Top = 0;
            pnlMenuGroup1.Height = 35;
            pnlMenuGroup2.Height = 35;
            pnlMenuGroup4.Height = 35;
            pnlMenuGroup6.Height = 35;
            pnlMenuGroup8.Height = 35;
            pnlMenuGroup9.Height = 35;
            btnMenuGroup1.Image = Properties.Resources.down;
            btnMenuGroup2.Image = Properties.Resources.down;
            btnMenuGroup4.Image = Properties.Resources.down;
            btnMenuGroup8.Image = Properties.Resources.down;
            btnMenuGroup9.Image = Properties.Resources.down;
            Panel4.AutoScroll = true;
            MenuStrip1.BackColor = Color.Crimson;
              MenuStrip1.Renderer = new MenuStripRenderer();
            MenuStrip2.BackColor = Color.Crimson;
             MenuStrip2.Renderer = new MenuStripRenderer();
            MenuStrip3.BackColor = Color.Crimson;
             MenuStrip3.Renderer = new MenuStripRenderer();

            FormDashboard fp = new FormDashboard();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.BringToFront();
        }

        private void btnMenuGroup1_Click(object sender, EventArgs e)
        {
            if ((pnlMenuGroup1.Height == 35))
            {
                pnlMenuGroup1.Height = (35 * 10);
                btnMenuGroup1.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup1.Height = 35;
                btnMenuGroup1.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup2_Click(object sender, EventArgs e)
        {
            if ((pnlMenuGroup2.Height == 35))
            {
                pnlMenuGroup2.Height = (35 * 5) + 2;
                btnMenuGroup2.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup2.Height = 35;
                btnMenuGroup2.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup4_Click(object sender, EventArgs e)
        {
            if ((pnlMenuGroup4.Height == 35))
            {
                pnlMenuGroup4.Height = (35 * 4) + 2;
                btnMenuGroup4.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup4.Height = 35;
                btnMenuGroup4.Image = Properties.Resources.down;
            }
        }

        private void btnPerusahaan_Click(object sender, EventArgs e)
        {
            FormPerusahaan fp = new FormPerusahaan();
            fp.ShowDialog();
        }

        private void btnJaminan_Click_1(object sender, EventArgs e)
        {
            FormJaminan fp = new FormJaminan();
            fp.ShowDialog();
        }

        private void btnJenis_Click_1(object sender, EventArgs e)
        {
            FormJenisIzin fp = new FormJenisIzin();
            fp.ShowDialog();
        }

        private void btnBank_Click_1(object sender, EventArgs e)
        {
            FormBank fp = new FormBank();
            fp.ShowDialog();
        }

        private void btnDokumen_Click_1(object sender, EventArgs e)
        {
            FormDokumen fp = new FormDokumen();
            fp.ShowDialog();
        }

        private void btnLokasi_Click_1(object sender, EventArgs e)
        {
            FormLokasi fp = new FormLokasi();
            fp.ShowDialog();
        }

        private void btnRekomendasi_Click_1(object sender, EventArgs e)
        {
            FormRekomendasi fp = new FormRekomendasi();
            fp.ShowDialog();
        }

        private void btnTahapKegiatan_Click_1(object sender, EventArgs e)
        {
            FormTahapKegiatan fp = new FormTahapKegiatan();
            fp.ShowDialog();
        }

        private void btnBahanGalian_Click_1(object sender, EventArgs e)
        {
            FormBahanGalian fp = new FormBahanGalian();
            fp.ShowDialog();
        }

        private void btnWiup_Click(object sender, EventArgs e)
        {
             foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }
            FormListWiup fp = new FormListWiup(this);
           // fp.TopLevel = false;
           // SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
           // fp.Label1.Text = "Pencarian Data WIUP";
           // fp.Label1.Text = "1";
           // fp.tampilGrid();
           // fp.BringToFront();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.LabelInfo.Text = "Pencarian Data IUP Operasi";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            FormListIup fp = new FormListIup();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.LabelInfo.Text = "Pencarian Data IUP";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

       

        private void btWiup_Click(object sender, EventArgs e)
        {
            FormListWiup fp = new FormListWiup(this);
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.Label1.Text = "Pencarian Data WIUP";
            // fp.Label1.Text = "1";
            // fp.tampilGrid();
            fp.BringToFront();
        }

        private void btnIupE_Click_1(object sender, EventArgs e)
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

        private void btnIupOE_Click_1(object sender, EventArgs e)
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

        private void btnIPR_Click(object sender, EventArgs e)
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

        private void btnMenuGroup8_Click(object sender, EventArgs e)
        {
            if ((pnlMenuGroup8.Height == 35))
            {
                pnlMenuGroup8.Height = (35 * 4) + 2;
                btnMenuGroup8.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup8.Height = 35;
                btnMenuGroup8.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup9_Click(object sender, EventArgs e)
        {
            if ((pnlMenuGroup9.Height == 35))
            {
                pnlMenuGroup9.Height = (35 * 4) + 2;
                btnMenuGroup9.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup9.Height = 35;
                btnMenuGroup9.Image = Properties.Resources.down;
            }
        }

        private void TanjungpinangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(1);
            fz.ShowDialog();
        }

        private void DaboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(2);
            fz.ShowDialog();
        }

        private void TarempaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(3);
            fz.ShowDialog();
        }

        private void TelukButunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(4);
            fz.ShowDialog();
        }

        private void RanaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(8);
            fz.ShowDialog();
        }

        private void NatunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZoom fz = new FormZoom();
            fz.pilihPeta(9);
            fz.ShowDialog();
        }

        private void lblMenu_Click_1(object sender, EventArgs e)
        {
            foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }

            FormDashboard fp = new FormDashboard();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }

            FormDashboard fp = new FormDashboard();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.BringToFront();
        }

        public void tampildashboard()
        {
            foreach (Form childForm in this.SplitContainer1.Panel2.Controls)
            {
                childForm.Close();
            }

            FormDashboard fp = new FormDashboard();
            fp.TopLevel = false;
            SplitContainer1.Panel2.Controls.Add(fp);
            fp.Show();
            fp.BringToFront();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void onlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGreatMap fg = new FormGreatMap();
            fg.Show();
        }
    }
}
