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
    public partial class FormPerusahaan : Form
    {
        private DBConnect dbConnect;
        public FormPerusahaan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            NamaPerusahaanTextBox.Text = "";
            TlpTextBox.Text = "";
            AlamatTextBox.Text = "";
            NamaPerusahaanTextBox.Focus();

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            dbConnect.Insert("insert into  esdm_perusahaan (namaPerusahaan,tlp,alamat) values('" + NamaPerusahaanTextBox.Text.ToUpper() + "','" + TlpTextBox.Text + "','" + AlamatTextBox.Text.ToString() + "')");
            dbConnect.tampilData(dgvList, "select * from esdm_perusahaan");
        }

        private void FormPerusahaan_Load(object sender, EventArgs e)
        {

            if (!backgroundWorker1.IsBusy)//Check if the worker is already in progress
            {
                backgroundWorker1.RunWorkerAsync();//Call the background worker
                Control.CheckForIllegalCrossThreadCalls = false;
            }

       
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NamaPerusahaanTextBox.Text = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                TlpTextBox.Text = dgvList.Rows[e.RowIndex].Cells[2].Value.ToString();
                AlamatTextBox.Text = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.Update("update esdm_perusahaan set namaPerusahaan='" + NamaPerusahaanTextBox.Text.ToUpper() + "',tlp='" + TlpTextBox.Text + "',alamat='" + AlamatTextBox.Text + "' where idPerusahaan='"+ dgvList.SelectedCells[0].Value.ToString() +"'");
                dgvList.SelectedCells[1].Value = NamaPerusahaanTextBox.Text.ToString();
                dgvList.SelectedCells[2].Value = TlpTextBox.Text.ToString();
                dgvList.SelectedCells[3].Value = AlamatTextBox.Text.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.Delete("delete from esdm_perusahaan where idPerusahaan='" + dgvList.SelectedCells[0].Value.ToString() + "'");
                dbConnect.tampilData(dgvList, "select * from esdm_perusahaan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            string sql = "select * from esdm_perusahaan where namaPerusahaan like '%" + txtCari.Text.ToLower() + "%'";
            Debug.Print(sql);
            dbConnect.tampilData(dgvList,sql);
            if(dgvList.Rows.Count==0)
            {
                MessageBox.Show("data tidak ditemukan.", "informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dbConnect.tampilData(dgvList, "select * from esdm_perusahaan");
        }

        private void txtCari_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand("select * from esdm_perusahaan", dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dbConnect.ds);
                e.Result= dbConnect.ds.Tables[0];
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void panggil(DataGridView dg,string sql)
        {

        }

        private void FormPerusahaan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(backgroundWorker1 .IsBusy)
            {
                backgroundWorker1.CancelAsync();
                while (backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)//Check if the worker has been cancelled or if an error occured
            {
              //  string result = (string)e.Result;//Get the result from the background thread
                dgvList.DataSource = e.Result;//result;//Display the result to the user
                lblStatus.Text = "Done";
            }
            else if (e.Cancelled)
            {
                lblStatus.Text = "User Cancelled";
            }
            else
            {
                lblStatus.Text = "An error has occured";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = string.Format("Counting number: {0}...", e.ProgressPercentage);

        }
    }
}
