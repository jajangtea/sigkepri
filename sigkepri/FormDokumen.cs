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
    public partial class FormDokumen : Form
    {
        private DBConnect dbConnect;
        public DataTable dtDokumen = new DataTable();
        public FormDokumen()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void FormDokumen_Load(object sender, EventArgs e)
        {
            this.tampilComboDokumen(cbbJenisDokumen, "namaJenisDokumen", "idJenisDokumen");
            this.tampildata();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string sql = "insert into  esdm_dokumen (namaDokumen,idJenisDokumen) values('" + NamaDokumenTextBox.Text + "','" + cbbJenisDokumen.SelectedValue + "')";
            Debug.Print(sql);
            dbConnect.Insert(sql);
            this.tampildata();
        }
        public void tampilComboDokumen(ComboBox cbDokumen, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_jenis_dokumen";
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
        public void tampildata()
        {
            string sqlTampil = "select ed.idDokumen,ed.namaDokumen,jd.namaJenisDokumen from esdm_dokumen  ed inner join esdm_jenis_dokumen jd on ed.idJenisDokumen=jd.idJenisDokumen order by ed.namaDokumen";
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
            string sql = "delete from esdm_dokumen where idDokumen='" + dgvList.SelectedCells[1].Value.ToString() + "'";
            Debug.Print(sql);
            dbConnect.Delete(sql);
            this.tampildata();
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            NamaDokumenTextBox.Text = "";
            NamaDokumenTextBox.Focus();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NamaDokumenTextBox.Text = dgvList.SelectedCells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update esdm_dokumen set namaDokumen='" + NamaDokumenTextBox.Text + "',idJenisDokumen='" + cbbJenisDokumen.SelectedValue + "' where idDokumen='" + dgvList.SelectedCells[1].Value.ToString() + "'";
            Debug.Print(sql);
            dbConnect.Update(sql);
            this.tampildata();
        }
    }
}
