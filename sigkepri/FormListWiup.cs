using ConnectCsharpToMysql;
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
    public partial class FormListWiup : Form
    {
        private DBConnect dbConnect;
        string sqlTampil;
        public int selectedId;
        private MenuUtama menuUtama;
        private FormMenuUtama formMenuUtama;
        private FormWiup formWiup;
        public const string tblPrefik = "esdm_";
     
        

        public FormListWiup(MenuUtama menuUtama)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            this.menuUtama = menuUtama;
        }

        public FormListWiup(FormMenuUtama formMenuUtama)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            this.formMenuUtama = formMenuUtama;
        }

        public FormListWiup(FormWiup formWiup)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            this.formWiup = formWiup;
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormWiup fw = new FormWiup(this);
            fw.btnSimpan.Text = "Simpan";
            fw.cbPerusahaan.Text = "Pilih";
            fw.cbbLokasi.Text = "Pilih";
            fw.txtLuas.Text = "";
            fw.tglPicker.Value = DateTime.Today;
            fw.bdKomoditi.Text = "Pilih";
            fw.NoIzinTextBox.Text = "";
            fw.cbPerusahaan.Focus();
            fw.ShowDialog();
        }

        private void FormListWiup_Load(object sender, EventArgs e)
        {
            tampilkan();   
        }

        public void tampilkan()
        {
            sqlTampil = "select w.idWiup,p.namaPerusahaan,w.noIzin,w.tglIzin,l.alamatLokasi,w.luas,bg.namaBahanGalian from " + tblPrefik + "wiup w inner join " + tblPrefik + "perusahaan p on w.idPerusahaan=p.idPerusahaan ";
            sqlTampil += "inner join " + tblPrefik + "lokasi l on w.idLokasi=l.idLokasi ";
            sqlTampil += "inner join " + tblPrefik + "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian order by w.idWiup desc";
            dbConnect.tampilData(dgvList, sqlTampil);
        }

        private void dgvList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cb = e.Control as ComboBox;
            if (cb != null)
            {
                // first remove event handler to keep from attaching multiple:
                cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);

                // now attach the event handler
                cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
            }
        }

        void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            ((ComboBox)sender).BackColor = Color.White;
            if (cb.SelectedIndex == 1)
            {
                FormJaminan fj = new FormJaminan();
                fj.ShowDialog();
            }

            /*Here you can fill other cell of datagridview*/
        }

        private void dgvList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                cmWiup.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void jaminan_Click(object sender, EventArgs e)
        {
            FormJaminan fj = new FormJaminan();
            fj.ShowDialog();

        }

        private void dokumen_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(selectedId.ToString());
            FormDokumen fd = new FormDokumen();
            fd.ShowDialog();
        }

        private void wIUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWiup fw = new FormWiup(this);
            fw.Idizin = this.selectedId.ToString();
            fw.btnSimpan.Text = "Edit";
            fw.ShowDialog();
        }

        //private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (e.ColumnIndex == 0) 
        //        {
        //            dgvList.CurrentCell = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //            dgvList.Rows[e.RowIndex].Selected = true;
        //            dgvList.Focus();
        //            selectedId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[1].Value);

        //        }
        //    }
        //    catch (Exception ec)
        //    {
        //        throw ec;
        //    }
        //}

      

        private void dgvList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void usahaJasaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.ColumnIndex == 0)
            {
                dgvList.CurrentCell = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvList.Rows[e.RowIndex].Selected = true;
                dgvList.Focus();
                selectedId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[1].Value);
                cmWiup.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        
    }
}
