using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnectCsharpToMysql;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;

namespace sigkepri
{
    public partial class FormRekap : Form
    {
        private DBConnect dbConnect;
        public GMapMarker marker;
        public FormRekap()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            if (!Stuff.PingNetwork("pingtest.com"))
            {
                gmap.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection available, going to CacheOnly mode.", "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            FormCari fp = new FormCari(this);
            fp.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void tampildglist(string nama)
        {
            string sql = "select p.namaPerusahaan,p.alamat,ip.nomorSK,ip.tglBerlaku,ip.tglKadaluwarsa,tk.namaTahapKegiatan," +
                " ip.luasWilayahTambang,ip.luasWilayahPenunjang,bg.namaBahanGalian from esdm_perusahaan p " +
                " inner join esdm_izin_perusahaan ip on p.idPerusahaan = ip.idPerusahaan " +
                " inner join esdm_jenis_perizinan jp on ip.idJenisPerizinan = jp.idJenisPerizinan " +
                " inner join esdm_tahap_kegiatan tk on ip.idTahapKegiatan=tk.idTahapKegiatan " +
                " inner join esdm_bahan_galian bg on ip.idBahanGalian=bg.idBahanGalian " +
                " where p.namaPerusahaan like '%" + nama + "%'";
            Debug.Print(sql);
            dbConnect.tampilData(dgvList, sql);
        }

        public void tampilLokasi(string nama)
        {
            MySqlCommand cmd;
            MySqlDataAdapter tampil;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string strquery = "SELECT el.alamatLokasi FROM esdm_perusahaan p " +
                    " INNER JOIN esdm_izin_perusahaan ip ON p.idPerusahaan = ip.idPerusahaan " +
                    " INNER JOIN esdm_lokasi el ON ip.idLokasi = el.idLokasi " +
                    " where p.namaPerusahaan like '%" + nama + "%'";
            Debug.Print(strquery);
            dbConnect.OpenConnection();
            cmd = new MySqlCommand(strquery, dbConnect.connection);
            tampil = new MySqlDataAdapter(cmd);
            ds.Clear();
            dt = new DataTable();
            tampil.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                var rw = r.Field<string>("alamatLokasi");
                lbLokasi.Text = rw.ToString();
            }
            dbConnect.CloseConnection();
        }

        public void tampilKorLokasi(string nama)
        {
            MySqlCommand cmd;
            MySqlDataAdapter tampil;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string strquery = "SELECT eld.pLat,eld.pLong FROM esdm_perusahaan p " +
                    " INNER JOIN esdm_izin_perusahaan ip ON p.idPerusahaan = ip.idPerusahaan " +
                    " INNER JOIN esdm_lokasi el ON ip.idLokasi = el.idLokasi " +
                    " INNER JOIN esdm_lokasi_detil eld ON el.idLokasi = eld.idLokasi " +
                    " where p.namaPerusahaan like '%" + nama + "%'";
            Debug.Print(strquery);
            dbConnect.OpenConnection();
            cmd = new MySqlCommand(strquery, dbConnect.connection);
            tampil = new MySqlDataAdapter(cmd);
            ds.Clear();
            tampil.Fill(ds);
            dgvKordinat.DataSource = ds.Tables[0];
            dbConnect.CloseConnection();
        }

        public void tampilPenanda(string nama)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            List<PointLatLng> points = new List<PointLatLng>();
            List<string>[] list;
            list = dbConnect.selectPenandaDetil(nama);
           
            for (int i = 0; i < list[0].Count; i++)
            {
                marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(list[1][i]), Convert.ToDouble(list[2][i])), new Bitmap(Properties.Resources.Marker_16px));
                marker.ToolTipText = list[0][i];
                marker.ToolTip.Fill = Brushes.Crimson;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Crimson;
                marker.ToolTip.TextPadding = new Size(20, 20);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            gmap.Zoom = gmap.Zoom + 1;
        }

        public void gambarpolygon(string nama)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new PointLatLng(1.082828, 104.030457);

            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            List<string>[] list;
            list = dbConnect.SelectLokasiDetil(nama);

            for (int i = 0; i < list[0].Count; i++)
            {
                points.Add(new PointLatLng(Convert.ToDouble(list[0][i]), Convert.ToDouble(list[1][i])));
            }

            GMapPolygon polygon = new GMapPolygon(points, "PT. Sukses");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);
            gmap.Zoom = 10;
        }
        private void FormRekap_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void dgvKordinat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void gmap_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            Console.WriteLine(String.Format("Polygon {0} with tag {1} was clicked", item.Name, item.Tag));
            MessageBox.Show("cobaan");
        }

        public void sumberDayaChart(string nama)
        {
            dbConnect.OpenConnection();
            dbConnect.cmd = new MySqlCommand("SELECT * FROM esdm_sumber_daya sd  " +
                "INNER JOIN esdm_izin_perusahaan ip ON  sd.idIzinPerusahaan = ip.idIzinPerusahaan  " +
                "INNER JOIN esdm_perusahaan ep ON ip.idPerusahaan = ep.idPerusahaan   " +
                " where ep.namaPerusahaan = '" + nama + "'"
                , dbConnect.connection);
            MySqlDataReader mydatareader;
            try
            {
                mydatareader = dbConnect.cmd.ExecuteReader();
                while (mydatareader.Read())
                {
                    this.chartSumerDaya.Series["Hipotetik"].Points.AddXY(mydatareader.GetString(6), mydatareader.GetDouble("hipotetik"));
                    this.chartSumerDaya.Series["Tereka"].Points.AddXY(mydatareader.GetString(6), mydatareader.GetDouble("tereka"));
                    this.chartSumerDaya.Series["Terunjuk"].Points.AddXY(mydatareader.GetString(6), mydatareader.GetDouble("terunjuk"));
                    this.chartSumerDaya.Series["Terukur"].Points.AddXY(mydatareader.GetString(6), mydatareader.GetDouble("terukur"));
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                dbConnect.CloseConnection();
            }
        }

        public void sumberDayalist(string nama)
        {
            MySqlCommand cmd;
            MySqlDataAdapter tampil;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string strquery = "SELECT sd.tahun,sd.hipotetik,sd.tereka,sd.terunjuk,sd.terukur FROM esdm_sumber_daya sd  " +
                 "INNER JOIN esdm_izin_perusahaan ip ON  sd.idIzinPerusahaan = ip.idIzinPerusahaan  " +
                 "INNER JOIN esdm_perusahaan ep ON ip.idPerusahaan = ep.idPerusahaan   " +
                 " where ep.namaPerusahaan = '" + nama + "'";
            Debug.Print(strquery);
            dbConnect.OpenConnection();
            cmd = new MySqlCommand(strquery, dbConnect.connection);
            tampil = new MySqlDataAdapter(cmd);
            ds.Clear();
            tampil.Fill(ds);
            dgvSumberDaya.DataSource = ds.Tables[0];
            dbConnect.CloseConnection();
        }

        public void CadanganChart(string nama)
        {
            dbConnect.OpenConnection();
            string sqlc = "SELECT * FROM esdm_cadangan sd  " +
                "INNER JOIN esdm_izin_perusahaan ip ON  sd.idIzinPerusahaan = ip.idIzinPerusahaan  " +
                "INNER JOIN esdm_perusahaan ep ON ip.idPerusahaan = ep.idPerusahaan   " +
                " where ep.namaPerusahaan = '" + nama + "'";
            dbConnect.cmd = new MySqlCommand(sqlc
                , dbConnect.connection);
            MySqlDataReader mydatareader;
            try
            {
                mydatareader = dbConnect.cmd.ExecuteReader();
                while (mydatareader.Read())
                {
                    this.chartCadangan.Series["Terkira"].Points.AddXY(mydatareader.GetString(4), mydatareader.GetDouble("terkira"));
                    this.chartCadangan.Series["Terbukti"].Points.AddXY(mydatareader.GetString(4), mydatareader.GetDouble("terbukti"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.CloseConnection();
            }
        }

            public void cadanganList(string nama)
            {
                MySqlCommand cmdcadangan;
                MySqlDataAdapter tampilCadangan;
                DataSet dscadangan = new DataSet();
                DataTable dt = new DataTable();

                string strquery = "SELECT sd.tahun,sd.terkira,sd.terbukti FROM esdm_cadangan sd  " +
                     "INNER JOIN esdm_izin_perusahaan ip ON  sd.idIzinPerusahaan = ip.idIzinPerusahaan  " +
                     "INNER JOIN esdm_perusahaan ep ON ip.idPerusahaan = ep.idPerusahaan   " +
                     " where ep.namaPerusahaan = '" + nama + "'";
                Debug.Print(strquery);
                dbConnect.OpenConnection();
                cmdcadangan = new MySqlCommand(strquery, dbConnect.connection);
                tampilCadangan = new MySqlDataAdapter(cmdcadangan);
                dscadangan.Clear();
                tampilCadangan.Fill(dscadangan);
                dgvCadangan.DataSource = dscadangan.Tables[0];
                dbConnect.CloseConnection();
            }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            gmap.Zoom = trackBar1.Value / 100.0;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new PointLatLng(1.082828, 104.030457);
            xPanderCadangan.Collapse();
            xPanderDokumen.Collapse();
        }
    }
}
