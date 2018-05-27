using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public partial class FormUploadLaporan : Form
    {
        private DBConnect dbConnect;
        public const string tblPrefik = "esdm_";
        public FormUploadLaporan()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        public string Izin { get; internal set; }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Pilh file laporan";
            openFileDialog1.Filter = "pilih dokumen (*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        NamaDokumenTextBox.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Silahkan upload dokumen");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void FormUploadLaporan_Load(object sender, EventArgs e)
        {
            this.tampildata();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (fname == null)
                {
                    MessageBox.Show("Upload dokumen terlebih dahulu");
                }
                else
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Laporan\\" + fname);
                    string lokasi = path + "\\Laporan\\" + fname;
                    string pathlokasi = path + "\\Laporan\\" + fname;
                    string output = pathlokasi.Replace(@"\\", @"\");
                    string sql = "insert into esdm_laporan (idIzinPerusahaan,namaFile,lokasi,namaLaporan,tanggalLapor) " +
                        "values('" + this.Izin + "','" + cbbJenisLaporan.Text +"_"+tglLapor.Value +"_"+ fname  + "','"+"/Laporan/"+fname + "','" + cbbJenisLaporan.Text + "','" + tglLapor.Value.ToString("yyyy-MM-dd") +"')";
                    Debug.WriteLine(sql);
                    dbConnect.Insert(sql);
                    this.tampildata();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tampildata()
        {
            string sqlTampil;
            sqlTampil = "select lp.namaFile,lp.namaLaporan,lp.lokasi,lp.tanggalLapor from " + tblPrefik + "izin_perusahaan w ";
            sqlTampil += "inner join " + tblPrefik + "perusahaan p on w.idPerusahaan=p.idPerusahaan ";
            sqlTampil += " inner join " + tblPrefik + "lokasi l on w.idLokasi=l.idLokasi ";
            sqlTampil += " inner join " + tblPrefik + "bahan_galian bg on w.idBahanGalian=bg.idBahanGalian";
            sqlTampil += " inner join " + tblPrefik + "laporan lp on w.idIzinPerusahaan=lp.idIzinPerusahaan";
            sqlTampil += " where w.idIzinPerusahaan='" + this.Izin + "'";
            Debug.WriteLine(sqlTampil);
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand(sqlTampil, dbConnect.connection);
            dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
            dbConnect.ds.Clear();
            dbConnect.tampil.Fill(dbConnect.ds);
            dgvList.DataSource = dbConnect.ds.Tables[0];
            dbConnect.CloseConnection();
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
    }
}
