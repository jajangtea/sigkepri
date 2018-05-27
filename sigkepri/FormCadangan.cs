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
    public partial class FormCadangan : Form
    {
        private DBConnect dbConnect;
        private string _izin;

        public string Izin
        {
            get { return _izin; }
            set { _izin = value; }
        }
        //public string Izin { get => _izin; set => _izin = value; }

        public FormCadangan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void FormCadangan_Load(object sender, EventArgs e)
        {
            this.tampildata();
        }

        public void tampildata()
        {
            string sqlTampil = "SELECT idCadangan,tahun,terkira,terbukti,deskripsi FROM esdm_cadangan";
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
            string sql = "insert into  esdm_cadangan (idIzinPerusahaan,terkira,terbukti,tahun,deskripsi) values('" + this.Izin + "','" + txtTerkira.Text + "','" + txtTerbukti.Text + "','" + cbbTahun.Text + "','" + cbbDeskripsi.Text + "')";
            Debug.Print(sql);
            dbConnect.Insert(sql);
            this.tampildata();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string sql = "delete from  esdm_cadangan where idCadangan='" + dgvList.SelectedCells[0].Value.ToString() + "')";
            Debug.Print(sql);
            dbConnect.Delete(sql);
            this.tampildata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update esdm_cadangan set idIzinPerusahaan='" + this.Izin + "',terkira='" + txtTerkira.Text + "',terbukti='" + txtTerbukti.Text + "',tahun='" + cbbTahun.Text + "' where idCadangan='" + dgvList.SelectedCells[0].Value.ToString() + "',deskripsi='" + cbbDeskripsi.Text + "')";
            Debug.Print(sql);
            dbConnect.Update(sql);
            this.tampildata();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtTerkira.Text = "";
            txtTerbukti.Text = "";
            txtTerkira.Focus();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbTahun.Text = dgvList.SelectedCells[1].Value.ToString();
                txtTerkira.Text= dgvList.SelectedCells[2].Value.ToString();
               txtTerbukti.Text= dgvList.SelectedCells[3].Value.ToString();
            }
            catch (Exception ed)
            {

                throw ed;
            }
        }
    }
}
