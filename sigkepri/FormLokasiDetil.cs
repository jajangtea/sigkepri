using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class FormLokasiDetil : Form
    {
        private string _idlokasi;

        public string Idlokasi
        {
            get { return _idlokasi; }
            set { _idlokasi = value; }
        }
        private DBConnect dbConnect;
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        //public string Idlokasi { get => _idlokasi; set => _idlokasi = value; }

        public FormLokasiDetil()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLatitude.Text = dgvList.SelectedCells[2].Value.ToString();
            txtLongitude.Text = dgvList.SelectedCells[3].Value.ToString();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string sql = "insert into  esdm_lokasi_detil (idLokasi,pLat,pLong) values('" + this.Idlokasi + "','" + txtLatitude.Text + "','" + txtLongitude.Text + "')";
            Debug.Print(sql);
            dbConnect.Insert(sql);
            this.tampildata();
        }

        private void tampildata()
        {
            string sqlTampil = "SELECT idLokasiDetil,pLat,pLong FROM esdm_lokasi_detil eld INNER JOIN esdm_lokasi el ON eld.idlokasi=el.idlokasi where eld.idLokasi  ='" + this.Idlokasi + "' order by idLokasiDetil";
            Debug.Print(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
        }

        private void FormLokasiDetil_Load(object sender, EventArgs e)
        {
            this.tampildata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update esdm_lokasi_detil set pLat='" + txtLatitude.Text + "',pLong='" + txtLongitude.Text + "' where idLokasiDetil='" + dgvList.SelectedCells[1].Value.ToString() + "'"; Debug.Print(sql);
            dbConnect.Update(sql);
            this.tampildata();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string sql = "delete from esdm_lokasi_detil where idLokasiDetil='" + dgvList.SelectedCells[1].Value.ToString() + "'";
            Debug.Print(sql);
            dbConnect.Delete(sql);
            this.tampildata();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtLatitude.Text = "";
            txtLongitude.Text = "";
            txtLatitude.Focus();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
           
            MySqlConnection Con = new MySqlConnection(Properties.Settings.Default.sigConnectionString);
            MySqlCommand com;
            Con.Open();
            for (int index = 0; index <= dgvList.Rows.Count - 1; index++)
            {
                string y = dgvList.Rows[index].Cells[1].Value.ToString();
                string x = dgvList.Rows[index].Cells[2].Value.ToString();
                string sql = "Insert Into esdm_lokasi_detil(idLokasi,pLat,pLong) Values(" + this.Idlokasi + ", '" + y + "','" + x + "')";
                com = new MySqlCommand(sql, Con);
                com.ExecuteNonQuery();
            }
            Con.Close();
        }

        private void ofdSelectOk(object sender, CancelEventArgs e)
        {
            string filePath = ofdSelect.FileName;
            string extension = Path.GetExtension(filePath);
            string conString = "";
            string sheetName = "";
            switch (extension)
            {
                case ".xls":
                    conString = string.Format(Excel03ConString, filePath, "YES");
                    break;
                case ".xlsx":
                    conString = string.Format(Excel07ConString, filePath, "YES");
                    break;
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dt.Rows[0]["esdm_lokasi_detil"].ToString();
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    OleDbDataAdapter oda = new OleDbDataAdapter();
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    oda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    con.Close();
                    dgvList.DataSource = dt;
                }
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            ofdSelect.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofdSelect.ShowDialog();
        }

        private void ofdSelect_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = ofdSelect.FileName;
            string extension = Path.GetExtension(filePath);
            string conString = "";
            string sheetName = "";
            switch (extension)
            {
                case ".xls":
                    conString = string.Format(Excel03ConString, filePath, "YES");
                    break;
                case ".xlsx":
                    conString = string.Format(Excel07ConString, filePath, "YES");
                    break;
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dt.Rows[0]["Table_Name"].ToString();
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    OleDbDataAdapter oda = new OleDbDataAdapter();
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    oda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    con.Close();
                    dgvList .DataSource = dt;
                }
            }
        }
    }
}
