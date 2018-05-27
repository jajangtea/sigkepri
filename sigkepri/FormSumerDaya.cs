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
    public partial class FormSumerDaya : Form
    {
        private DBConnect dbConnect;
        private string _izin;

        public string Izin
        {
            get { return _izin; }
            set { _izin = value; }
        }
        //public string Izin { get => _izin; set => _izin = value; }
        public FormSumerDaya()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void FormSumerDaya_Load(object sender, EventArgs e)
        {
            this.tampildata();
        }

        public void tampildata()
        {
            string sqlTampil = "SELECT idSdc,tahun,hipotetik,tereka,terunjuk,terukur,deskripsi FROM esdm_sumber_daya where idIzinPerusahaan='" + this.Izin + "'";
            Debug.Print(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string sql = "insert into  esdm_sumber_daya (idIzinPerusahaan,hipotetik,tereka,terunjuk,terukur,tahun,deskripsi) values('" + this.Izin + "','" + txtHipotetik.Text + "','" + txtTereka.Text + "','" + txtTerunjuk.Text + "','" + txtTerukur.Text + "','" + cbbTahun.Text + "','"+ cbbDeskripsi.Text+"')";
            Debug.Print(sql);
            dbConnect.Insert(sql);
            this.tampildata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update esdm_sumber_daya set idIzinPerusahaan='" + this.Izin + "',hipotetik='" + txtHipotetik.Text + "',tereka='" + txtTereka.Text + "',terunjuk='" + txtTerunjuk.Text + "',terukur='" + txtTerukur.Text + "',tahun='" + cbbTahun.Text + "',deskripsi='"+ cbbDeskripsi.Text +"' where idSdc='" + dgvList.SelectedCells[0].Value + "'";
            Debug.Print(sql);
            dbConnect.Update(sql);
            this.tampildata();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string sql = "delete from esdm_sumber_daya where idSdc='" + dgvList.SelectedCells[0].Value + "'";
            Debug.Print(sql);
            dbConnect.Delete(sql);
            this.tampildata();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtTerunjuk.Text = "";
            txtTerunjuk.Focus();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbTahun.Text = dgvList.SelectedCells[1].Value.ToString();
                txtHipotetik.Text = dgvList.SelectedCells[2].Value.ToString();
                txtTereka.Text = dgvList.SelectedCells[3].Value.ToString();
                txtTerunjuk.Text = dgvList.SelectedCells[4].Value.ToString();
                txtTerukur.Text = dgvList.SelectedCells[5].Value.ToString();
            }
            catch (Exception ed)
            {

                throw ed;
            }
        }
    }
}
