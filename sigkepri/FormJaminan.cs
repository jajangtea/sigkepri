using ConnectCsharpToMysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class FormJaminan : Form
    {
        private DBConnect dbConnect;
        public FormJaminan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            NamaJaminanTextBox.Text = "";
            NamaJaminanTextBox.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            dbConnect.Insert("insert into  esdm_jaminan (namaJaminan) values('" + NamaJaminanTextBox.Text.ToUpper() + "')");
            dbConnect.tampilData(dgvList, "select * from esdm_jaminan order by namaJaminan asc");
        }

        private void FormJaminan_Load(object sender, EventArgs e)
        {
            dbConnect.tampilData(dgvList, "select * from esdm_jaminan");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dbConnect.Insert("update esdm_jaminan set namaJaminan='" + NamaJaminanTextBox.Text.ToUpper() + "' where idJaminan='" + dgvList.SelectedCells[0].Value.ToString() + "'");
            dbConnect.tampilData(dgvList, "select * from esdm_jaminan order by namaJaminan asc");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.Insert("delete from esdm_jaminan where idJaminan='" + dgvList.SelectedCells[0].Value.ToString() + "'");
                dbConnect.tampilData(dgvList, "select * from esdm_jaminan order by namaJaminan asc");
            }
            catch (Exception)
            {

               // throw;
            }
           
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NamaJaminanTextBox.Text = dgvList.SelectedCells[1].Value.ToString();
        }
    }
}
