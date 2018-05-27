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
    public partial class FormDokumenPerusahaan : Form
    {
        private DBConnect dbConnect;
        public DataTable dtPerusahaan = new DataTable();
        public DataTable dtDokumen = new DataTable();

        public const string tblPrefik = "esdm_";
        private string _namaPerusahaan;

        public string NamaPerusahaan
        {
            get { return _namaPerusahaan; }
            set { _namaPerusahaan = value; }
        }
        private string idizin;

        public string Idizin
        {
            get { return idizin; }
            set { idizin = value; }
        }
        //public string Idizin { get => idizin; set => idizin = value; }
        //public string NamaPerusahaan { get => _namaPerusahaan; set => _namaPerusahaan = value; }

        public FormDokumenPerusahaan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if(nomorDok.Text=="")
                {
                    MessageBox.Show("Nomor Dokumen tidak boleh kosong.", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect.Insert("insert into  esdm_izin_dokumen (idIzinPerusahaan,idDokumen,nomorDokumen) values" +
                   "('" + Idizin + "','" + cbbDokumen.SelectedValue + "','" + nomorDok.Text + "')");
                    tampildata();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void tampildata()
        {
            string sqlTampil = "select el.idIzinDokumen,id.namaDokumen,jd.namaJenisDokumen,el.nomorDokumen from esdm_izin_perusahaan ew " +
                  "inner join esdm_perusahaan ep on ew.idPerusahaan=ep.idPerusahaan " +
                  "inner join esdm_izin_dokumen el on ew.idIzinPerusahaan=el.idIzinPerusahaan " +
                  "inner join esdm_dokumen id on el.idDokumen=id.idDokumen " +
                  "inner join esdm_jenis_dokumen jd on id.idJenisDokumen=jd.idJenisDokumen " +
                  "where  ew.idIzinPerusahaan='" + this.idizin + "'";
            Debug.Print(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                string sqlTampil = "select el.idIzinDokumen,id.namaDokumen,jd.namaJenisDokumen,el.nomorDokumen from esdm_izin_perusahaan ew " +
                   "inner join esdm_perusahaan ep on ew.idPerusahaan=ep.idPerusahaan " +
                   "inner join esdm_izin_dokumen el on ew.idIzinPerusahaan=el.idIzinPerusahaan " +
                   "inner join esdm_dokumen id on el.idDokumen=id.idDokumen " +
                   "inner join esdm_jenis_dokumen jd on id.idJenisDokumen=jd.idJenisDokumen " +
                   "where  ew.idIzinPerusahaan='" + this.idizin + "'";
                Debug.Print(sqlTampil);
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

        public void tampilComboDokumen(ComboBox cbDokumen, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_dokumen order by namaDokumen";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtDokumen);
                DataView dvDokumen = new DataView(dtDokumen);
                cbDokumen.DataSource = dvDokumen;
                cbDokumen.DisplayMember = list;
                cbDokumen.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void FormDokumenPerusahaan_Load(object sender, EventArgs e)
        {
            dbConnect.CloseConnection();
            this.tampilComboPerusahaan(cbbPerusahaan, "namaPerusahaan", "idPerusahaan");
            this.tampilComboDokumen(cbbDokumen, "namaDokumen", "idDokumen");
            cbbPerusahaan.Text = this.NamaPerusahaan;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = e.Result;
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

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbPerusahaan.Text = dgvList.SelectedCells[1].Value.ToString();
                cbbDokumen.Text = dgvList.SelectedCells[2].Value.ToString();
                nomorDok.Text = dgvList.SelectedCells[3].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string sql= "delete from esdm_izin_dokumen where idIzinDokumen='" + dgvList.SelectedCells[0].Value.ToString() +"'";
                dbConnect.CloseConnection();
                dbConnect.Delete(sql);
                this.tampildata();
            }
            catch (Exception ef)
            {

                MessageBox.Show(ef.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomorDok.Text == "")
                {
                    MessageBox.Show("Nomor Dokumen tidak boleh kosong.", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect.Update("update esdm_izin_dokumen set idIzinPerusahaan='" + Idizin + "',idDokumen='" + cbbDokumen.SelectedValue + "',nomorDokumen='" + nomorDok.Text + "' where idIzinDokumen='" + dgvList.SelectedCells[0].Value.ToString() + "'");
                    tampildata();
                }
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            nomorDok.Text = "";
            nomorDok.Focus();
        }
    }
}
