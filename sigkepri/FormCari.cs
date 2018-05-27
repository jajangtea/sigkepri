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
    public partial class FormCari : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        string strquery,rw;
        private DBConnect dbcn;
        private FormRekapitulasi frm1;
        private readonly FormRekap frm2;
        public FormCari(FormRekap frm)
        {
            InitializeComponent();
            dbcn = new DBConnect();
            frm2 = frm;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
        public FormCari(FormRekapitulasi frms)
        {
            InitializeComponent();
            dbcn = new DBConnect();
            frm1 = frms;
        }

        private void FormCari_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            frm2.tampildglist(txtCari.Text);
            frm2.tampilLokasi(txtCari.Text);
            frm2.tampilKorLokasi(txtCari.Text);
            frm2.tampilPenanda(txtCari.Text);
            frm2.gambarpolygon(txtCari.Text);
            frm2.sumberDayaChart(txtCari.Text);
            frm2.sumberDayalist(txtCari.Text);
            frm2.CadanganChart(txtCari.Text);
            frm2.cadanganList(txtCari.Text);
            //frm2.tampildataDokumen(txtCari.Text);
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                strquery = "select namaPerusahaan from esdm_perusahaan where namaPerusahaan like '%" + txtCari.Text + "%' order by namaPerusahaan asc";
                dbcn.OpenConnection();
                cmd = new MySqlCommand(strquery, dbcn.connection);
                da = new MySqlDataAdapter(cmd);
                ds.Clear();
                dt = new DataTable();
                da.Fill(dt);
                backgroundWorker1.ReportProgress(dt.Rows.Count);
                dbcn.CloseConnection();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

       

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)//Check if the worker has been cancelled or if an error occured
            {
                txtCari.AutoCompleteCustomSource.Clear();
               
                foreach (DataRow r in dt.Rows)
                {
                    rw=r.Field<string>("namaPerusahaan");
                    txtCari.AutoCompleteCustomSource.Add(rw);
                }
              
                txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCari.Visible = true;
            }
            else if (e.Cancelled)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Maximum = dt.Rows.Count;
            progressBar1.Value = e.ProgressPercentage;
        }

        private void FormCari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                while (backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }
            }

        }
    }
}
