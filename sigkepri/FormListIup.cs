using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace sigkepri
{
    public partial class FormListIup : Form
    {
        private DBConnect dbConnect;
        private string __idtahapKegiatan;

        public string _idtahapKegiatan
        {
            get { return __idtahapKegiatan; }
            set { __idtahapKegiatan = value; }
        }
        string sqlTampil;
        public int selectedId;
        public string _namaperusahaan;
        public const string tblPrefik = "esdm_";
        public DataTable dtPerusahaan = new DataTable();
        public FormListIup()
        {
            InitializeComponent();
            dbConnect = new DBConnect();

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            dgvList.AutoGenerateColumns = false;
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                while (backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }
            }
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormIup fi = new FormIup(this);
            fi.btnSimpan.Text = "Simpan";
            fi.Idtahap = this._idtahapKegiatan;
            fi.ShowDialog();

        }

        private void FormListIup_Load(object sender, EventArgs e)
        {
            this.tampilComboPerusahaan(cbbPerusahaan, "namaPerusahaan", "idPerusahaan");
            backgroundWorker1.RunWorkerAsync();

        }

        public void tampilkan()
        {
            sqlTampil = "select w.idIzinPerusahaan,w.tglBerlaku,w.tglKadaluwarsa,TIMESTAMPDIFF(DAY,CURDATE(),w.tglKadaluwarsa) AS masaBerlaku,w.cnc, ";
            sqlTampil += "p.namaPerusahaan,w.nomorSK,l.alamatLokasi,w.luasWilayahTambang,w.luasWilayahPenunjang,bg.namaBahanGalian ";
            sqlTampil += "from " + tblPrefik + "izin_perusahaan w inner join " + tblPrefik + "perusahaan p on w.idPerusahaan=p.idPerusahaan ";
            sqlTampil += " inner join " + tblPrefik + "lokasi l on w.idLokasi=l.idLokasi ";
            sqlTampil += " inner join " + tblPrefik + "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian";
            sqlTampil += " where w.idJenisPerizinan='" + 1 + "' and w.idTahapKegiatan='" + __idtahapKegiatan + "' order by w.idIzinPerusahaan desc";
            dbConnect.tampilData(dgvList, sqlTampil);
            Debug.WriteLine(sqlTampil);
            this.warnai();
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.ColumnIndex == 11)
            {
                cmWiup.Show(Cursor.Position.X, Cursor.Position.Y);
                dgvList.CurrentCell = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvList.Rows[e.RowIndex].Selected = true;
                dgvList.Focus();
                selectedId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value);
                _namaperusahaan = (dgvList.Rows[e.RowIndex].Cells[1].Value.ToString());

            }
            else if (e.ColumnIndex == 12)
            {
                dgvList.CurrentCell = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvList.Rows[e.RowIndex].Selected = true;
                selectedId = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value);
                string sql = "delete from esdm_izin_perusahaan where idIzinPerusahaan='" + selectedId + "'";
                dbConnect.Delete(sql);
                this.tampilkan();
            }
        }

        public void warnai()
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
                    dgvList.Rows[f].DefaultCellStyle.BackColor = Color.Red;
                    dgvList.Rows[f].DefaultCellStyle.ForeColor = Color.White;
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                sqlTampil = "select w.idIzinPerusahaan,w.tglBerlaku,w.tglKadaluwarsa,TIMESTAMPDIFF(DAY,CURDATE(),w.tglKadaluwarsa) AS masaBerlaku,w.cnc, ";
                sqlTampil += "p.namaPerusahaan,w.nomorSK,l.alamatLokasi,w.luasWilayahTambang,w.luasWilayahPenunjang,bg.namaBahanGalian ";
                sqlTampil += "from " + tblPrefik + "izin_perusahaan w inner join " + tblPrefik + "perusahaan p on w.idPerusahaan=p.idPerusahaan ";
                sqlTampil += " inner join " + tblPrefik + "lokasi l on w.idLokasi=l.idLokasi ";
                sqlTampil += " inner join " + tblPrefik + "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian";
                sqlTampil += " where w.idJenisPerizinan='" + 1 + "' and w.idTahapKegiatan='" + __idtahapKegiatan + "' order by w.idIzinPerusahaan desc";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dbConnect.ds);
                e.Result = dbConnect.ds.Tables[0];
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = e.Result;
            string kolom;
            double kol;
            int f;
            for (f = 0; f < dgvList.Rows.Count; f++)
            {
                kolom = dgvList.Rows[f].Cells[5].Value.ToString();
                kol = Convert.ToDouble(kolom);
                if (kol <= 1)
                {
                    dgvList.Rows[f].DefaultCellStyle.BackColor = Color.Red;
                    dgvList.Rows[f].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void wIUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIup fd = new FormIup(this);
            fd.Idizin = this.selectedId.ToString();
            fd.btnSimpan.Text = "Edit";
            fd.ShowDialog();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 6 || e.ColumnIndex == 7 && e.RowIndex != this.dgvList.NewRowIndex)
            //{
            //    double d = double.Parse(e.Value.ToString());
            //    e.Value = d.ToString("0.00##");
            //}
        }

        private void dokumen_Click(object sender, EventArgs e)
        {
            FormDokumenPerusahaan fd = new FormDokumenPerusahaan();
            fd.Idizin = this.selectedId.ToString();
            fd.NamaPerusahaan = this._namaperusahaan.ToString();
            fd.ShowDialog();
        }

        private void jaminan_Click(object sender, EventArgs e)
        {
            FormJaminan fd = new FormJaminan();
            fd.Idizin = this.selectedId.ToString();
            fd.ShowDialog();
        }



        private void sumberDayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSumerDaya fd = new FormSumerDaya();
            fd.Izin = this.selectedId.ToString();
            fd.ShowDialog();
        }

        private void cadanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadangan fd = new FormCadangan();
            fd.Izin = this.selectedId.ToString();
            fd.ShowDialog();
        }

        private void pelaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUploadLaporan fd = new FormUploadLaporan();
            fd.Izin = this.selectedId.ToString();
            fd.ShowDialog();
        }

        private void FormListIup_FormClosing(object sender, FormClosingEventArgs e)
        {
            new FormDashboard().Close();
        }
    }
}
