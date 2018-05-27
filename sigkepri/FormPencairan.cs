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
    public partial class FormPencairan : Form
    {
        private string _idJaminan;

        public string IdJaminan
        {
            get { return _idJaminan; }
            set { _idJaminan = value; }
        }
        private DBConnect dbConnect;
        private double jsisa;
       // public string IdJaminan { get => _idJaminan; set => _idJaminan = value; }

        public FormPencairan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void FormPencairan_Load(object sender, EventArgs e)
        {
            jsisa = tampilSisa();
            lbSisa.Text = jsisa.ToString("#,##0");
            this.tampildata();
        }

        private Double tampilSisa()
        {
            double jmlsisa=0;

            string sqlTampil = "SELECT ij.idJaminan,ij.sisa FROM esdm_izin_jaminan ij " +
                "INNER JOIN esdm_izin_perusahaan ip ON ij.idIzinPerusahaan = ip.idIzinPerusahaan " +
                "INNER JOIN esdm_bank eb ON ij.idBank = eb.idBank " +
                "WHERE ij.idJaminan='" + this.IdJaminan + "'";
            Debug.Print(sqlTampil);
            if (dbConnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                   jmlsisa= Convert.ToDouble(dataReader["sisa"] + "");
                }
                dataReader.Close();
                dbConnect.CloseConnection();
            }
            else
            {
                return 0;
            }
            dbConnect.CloseConnection();

            return jmlsisa;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            dbConnect.CloseConnection();
            string sql = "insert into  esdm_pencairan (idJaminan,tglPencairan,pencairan) values('" + this.IdJaminan + "','" + tglCair.Value.ToString("yyyy-MM-dd") + "','" + txtJmlCair.Text.Trim() + "')";
            dbConnect.Insert(sql);
            dbConnect.Update("update esdm_izin_jaminan set sisa=sisa-'" + Convert.ToDouble(txtJmlCair.Text.Trim()) + "' where idJaminan='" + this.IdJaminan + "'");

            Debug.Print(sql);

            
            this.tampildata();
        }

        public void tampildata()
        {
            string sqlTampil = "SELECT idPencairan,tglPencairan,Pencairan from esdm_pencairan " +
                "WHERE idJaminan='" + this.IdJaminan + "'";
            Debug.Print(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.Insert("delete from esdm_pencairan where idPencairan='" + dgvList.SelectedCells[0].Value.ToString() + "'");
                this.tampildata();
            }
            catch (Exception ed)
            {

                throw ed;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.Update("update esdm_pencairan set tglPencairan='" + tglCair.Value + "',Pencairan='" + txtJmlCair.Text + "' where idPencairan='" + dgvList.SelectedCells[0].Value.ToString() + "'");
                this.tampildata();
            }
            catch (Exception ed)
            {

                throw ed;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtJmlCair.Text = "";
            txtJmlCair.Focus();
        }

        private void txtJmlCair_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                double sisa = Convert.ToDouble(lbSisa.Text) - Convert.ToDouble(txtJmlCair.Text);
                lbSisa.Text = sisa.ToString("#,##0");
            }
        }
    }
}
