using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using sigkepri.FormReporting;

namespace sigkepri
{
    public partial class FormPrintLaporan : Form
    {
        private DBConnect dbConnect;
        public DataTable dttahap = new DataTable();
        string masaBerlaku;
        public FormPrintLaporan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            this.tampilComboTahap(cbbTahapKegiatan, "namaTahapKegiatan", "idTahapKegiatan");
        }

        public void tampilComboTahap(ComboBox cbtahap, string list, string nilai)
        {
            try
            {

                string sql = "select * from esdm_tahap_kegiatan order by namaTahapKegiatan";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dttahap);
                DataView dvTahap = new DataView(dttahap);
                cbtahap.DataSource = dvTahap;
                cbtahap.DisplayMember = list;
                cbtahap.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbTahapKegiatan.Text == "Eksplorasi" && cbbStatus.Text == "Aktif")
            {
                FormIzinReport fi = new FormIzinReport();
                fi.cetaklapiupaktif(cbbTahapKegiatan.Text);
                fi.Show();
            }
            else if (cbbTahapKegiatan.Text == "Operasi Produksi" && cbbStatus.Text == "Aktif")
            {
                FormIzinReport fi = new FormIzinReport();
                fi.cetaklapiupaktif(cbbTahapKegiatan.Text);
                fi.Show();
            }
            else if (cbbTahapKegiatan.Text == "IPR" && cbbStatus.Text == "Aktif")
            {
                FormIzinReport fi = new FormIzinReport();
                fi.cetaklapiupaktif(cbbTahapKegiatan.Text);
                fi.Show();
            }
            else if (cbbTahapKegiatan.Text == "Eksplorasi" && cbbStatus.Text == "Tidak Aktif")
            {
                FormIzinReport fi = new FormIzinReport();
                fi.cetaklapiuptidakaktif(cbbTahapKegiatan.Text);
                fi.Show();
            }
            else if (cbbTahapKegiatan.Text == "Operasi Produksi" && cbbStatus.Text == "Tidak Aktif")
            {
                FormIzinReport fi = new FormIzinReport();
                fi.cetaklapiuptidakaktif(cbbTahapKegiatan.Text);
                fi.Show();
            }
            else if (cbbTahapKegiatan.Text == "IPR" && cbbStatus.Text == "Tidak Aktif")
            {
                FormIzinReport fi = new FormIzinReport();
                fi.cetaklapiuptidakaktif(cbbTahapKegiatan.Text);
                fi.Show();
            }
        }

        private void FormPrintLaporan_Load(object sender, EventArgs e)
        {

        }
    }
}
