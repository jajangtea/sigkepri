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
    public partial class FormJaminan : Form
    {
        private DBConnect dbConnect;
        private string _namaPerusahaan;

        public string NamaPerusahaan
        {
            get { return _namaPerusahaan; }
            set { _namaPerusahaan = value; }
        }
        public DataTable dtBank = new DataTable();
        public DataTable dtJaminan = new DataTable();
        private string idizin;

        public string Idizin
        {
          get { return idizin; }
          set { idizin = value; }
        }
        //public string Idizin { get => idizin; set => idizin = value; }
       // public string NamaPerusahaan { get => _namaPerusahaan; set => _namaPerusahaan = value; }
        public FormJaminan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        public void tampilComboBank(ComboBox cbBank, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_bank order by namaBank";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtBank);
                DataView dvBank = new DataView(dtBank);
                cbBank.DataSource = dvBank;
                cbBank.DisplayMember = list;
                cbBank.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void tampilComboJenisJaminan(ComboBox cbJenis, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_jenis_jaminan order by namaJenisJaminan";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtJaminan);
                DataView dvJaminan = new DataView(dtJaminan);
                cbJenis.DataSource = dvJaminan;
                cbJenis.DisplayMember = list;
                cbJenis.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtJumlah.Text = "";
            txtJumlah.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string sql = "insert into  esdm_izin_jaminan (idIzinPerusahaan,idBank,jumlah,sisa,idJenisJaminan) values('" + this.Idizin + "','" + cbbBank.SelectedValue + "','" + txtJumlah.Text.Trim() + "','" + txtSisa.Text.Trim() + "','"+ cbbJenisJaminan.SelectedValue +"')";
            Debug.Print(sql);
            dbConnect.Insert(sql);
            this.tampildata();
        }

        private void FormJaminan_Load(object sender, EventArgs e)
        {
            this.tampilComboBank(cbbBank, "namaBank", "idBank");
            this.tampilComboJenisJaminan(cbbJenisJaminan, "namaJenisJaminan", "idJenisJaminan");
            this.tampildata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dbConnect.Update("update esdm_izin_jaminan set idBank='" + cbbBank.SelectedValue + "',jumlah='" + txtJumlah.Text + "',sisa='" + txtSisa.Text + "',idJenisJaminan='"+ cbbJenisJaminan.SelectedValue  +"' where idJaminan='" + dgvList.SelectedCells[0].Value.ToString() + "'");
            this.tampildata();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.Insert("delete from esdm_izin_jaminan where idJaminan='" + dgvList.SelectedCells[0].Value.ToString() + "'");
                this.tampildata();
            }
            catch (Exception ed)
            {

               throw ed;
            }
           
        }

        public void tampildata()
        {
            string sqlTampil = "SELECT ij.idJaminan,eb.namaBank,ij.jumlah,ij.sisa,jn.namaJenisJaminan FROM esdm_izin_jaminan ij " +
                "INNER JOIN esdm_izin_perusahaan ip ON ij.idIzinPerusahaan = ip.idIzinPerusahaan " +
                "INNER JOIN esdm_bank eb ON ij.idBank = eb.idBank " +
                "INNER JOIN esdm_jenis_jaminan jn ON ij.idJenisJaminan = jn.idJenisJaminan " +
                "WHERE ij.idIzinPerusahaan='" + this.Idizin + "'";
            Debug.Print(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
            txtJumlah.Focus();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtJumlah.Text = dgvList.SelectedCells[2].Value.ToString();
                txtSisa.Text = dgvList.SelectedCells[3].Value.ToString();
            }
            catch (Exception er)
            {

                throw er;
            }

           
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnPencairan_Click(object sender, EventArgs e)
        {
            FormPencairan fp = new FormPencairan();
            fp.IdJaminan = dgvList.SelectedCells[0].Value.ToString();
            fp.Show();
        }

        private void txtJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtSisa.Text = txtJumlah.Text;
                }
                catch (Exception ee)
                {

                    throw ee;
                }
            }
        }

       
    }
}
