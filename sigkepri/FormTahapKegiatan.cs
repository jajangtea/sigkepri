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
    public partial class FormTahapKegiatan : Form
    {
        private DBConnect dbConnect;
        public FormTahapKegiatan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void FormTahapKegiatan_Load(object sender, EventArgs e)
        {
            this.tampildata();
        }

        public void tampildata()
        {
            string sqlTampil = "SELECT idTahapKegiatan,namaTahapKegiatan FROM esdm_tahap_kegiatan";
            Debug.Print(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
        }
    }
}
