using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class FormListAir : Form
    {
        private DBConnect dbConnect;
        public DataTable dtPerusahaan = new DataTable();
        string sqlTampil;
        public const string tblPrefik = "esdm_";
        public int selectedId;
        public FormListAir()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            dgvList.AutoGenerateColumns = false;
            this.tampilComboPerusahaan(cbbPerusahaan, "namaPerusahaan", "idPerusahaan");
        }
        public void tampildata()
        {
            try
            {
                sqlTampil = "select w.idIzinPerusahaanAir,w.tglBerlaku,w.tglKadaluwarsa,TIMESTAMPDIFF(MONTH,CURDATE(),w.tglKadaluwarsa) AS masaBerlaku, p.namaPerusahaan,w.nomorSK,l.alamatLokasi from " + tblPrefik + "izin_perusahaan_air w ";
                sqlTampil += "inner join " + tblPrefik + "perusahaan p on w.idPerusahaan=p.idPerusahaan ";
                sqlTampil += " inner join " + tblPrefik + "lokasi l on w.idLokasi=l.idLokasi ";
                sqlTampil += " order by w.idIzinPerusahaanAir desc";
                Debug.WriteLine(sqlTampil);
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dbConnect.ds);
                dgvList.DataSource = dbConnect.ds.Tables[0];
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }

        private void FormListAir_Load(object sender, EventArgs e)
        {
            this.tampildata();
            this.ubahGrid();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormIzinAir fi = new FormIzinAir(this);
            fi.btnSimpan.Text = "Simpan";
            //fi.Idizin = dgvList.SelectedCells[0].Value.ToString();
            fi.ShowDialog();
        }

        public void tampilComboPerusahaan(ComboBox cbPerusahaan, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_perusahaan order by namaPerusahaan";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtPerusahaan);
                DataView dvPerusahaan = new DataView(dtPerusahaan);
                cbPerusahaan.DataSource = dvPerusahaan;
                cbPerusahaan.DisplayMember = list;
                cbPerusahaan.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ubahGrid()
        {
            string kolom;
            double kol;
            int f;
            for (f = 0; f < dgvList.Rows.Count; f++)
            {
                kolom = dgvList.Rows[f].Cells[5].Value.ToString();
                kol = Convert.ToDouble(kolom);
                if (kol <= 1)
                {
                    dgvList.Rows[f].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

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

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.ColumnIndex == 7)
            {
                cmWiup.Show(Cursor.Position.X, Cursor.Position.Y);
                dgvList.CurrentCell = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvList.Rows[e.RowIndex].Selected = true;
                dgvList.Focus();
                selectedId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void dokumen_Click(object sender, EventArgs e)
        {
            FormDokumenPerusahaan fd = new FormDokumenPerusahaan();
            fd.Idizin = this.selectedId.ToString();
            fd.ShowDialog();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
