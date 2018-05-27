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
    public partial class FormLokasi : Form
    {
        private DBConnect dbConnect;
        public DataTable dtKabKota = new DataTable();
        public string selectedId;
        public FormLokasi()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string sql = "insert into  esdm_lokasi (idKabKota,alamatLokasi) values('" + cbbKabKota.SelectedValue + "','" + NamaLokasiTextBox.Text + "')";
            Debug.Print(sql);
            dbConnect.Insert(sql);
            this.tampildata();
        }

        private void FormLokasi_Load(object sender, EventArgs e)
        {
            this.tampilComboKabKota(cbbKabKota, "namaKabKota", "idKabKota");
            tampildata();
            NamaLokasiTextBox.Text = "";
            NamaLokasiTextBox.Focus();
        }

        public void tampildata()
        {
            string sqlTampil = "SELECT il.idLokasi,kk.namaKabKota,il.alamatLokasi,kk.latKabKota,kk.longKabKota FROM esdm_lokasi il inner join esdm_kab_kota kk on il.idKabKota=kk.idKabKota";
            Debug.Print(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update esdm_lokasi set idKabKota='" + cbbKabKota.SelectedValue + "',alamatLokasi='" + NamaLokasiTextBox.Text + "' where idLokasi='" + dgvList.SelectedCells[1].Value.ToString() + "'";
            Debug.Print(sql);
            dbConnect.Update(sql);
            this.tampildata();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            NamaLokasiTextBox.Text = "";
            NamaLokasiTextBox.Focus();
        }

        public void tampilComboKabKota(ComboBox cbKabKota, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_kab_kota order by namaKabKota";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtKabKota);
                DataView dvKabKota = new DataView(dtKabKota);
                cbKabKota.DataSource = dvKabKota;
                cbKabKota.DisplayMember = list;
                cbKabKota.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbKabKota.Text = dgvList.SelectedCells[2].Value.ToString();
                NamaLokasiTextBox.Text = dgvList.SelectedCells[3].Value.ToString();
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string sql = "delete from esdm_lokasi where idLokasi='" +  dgvList.SelectedCells[1].Value.ToString()+ "'";
            Debug.Print(sql);
            dbConnect.Delete(sql);
            this.tampildata();
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.ColumnIndex == 0)
            {
                dgvList.CurrentCell = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvList.Rows[e.RowIndex].Selected = true;
                dgvList.Focus();
                selectedId = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormLokasiDetil fld = new FormLokasiDetil();
                fld.Idlokasi = selectedId;
                fld.ShowDialog();

            }
        }
    }
}
