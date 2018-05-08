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
    public partial class FormRekapitulasi : Form
    {
        private DBConnect dbConnect;

        public FormRekapitulasi()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
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
            dbConnect.tampilData(dgvList ,sql );
        }

        public void tampilLokasi(string nama)
        {
             MySqlCommand cmd;
             MySqlDataAdapter tampil;
             DataSet ds = new DataSet();
             DataTable dt = new DataTable();

        string strquery = "SELECT el.namaLokasi FROM esdm_perusahaan p " +
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
                var rw = r.Field<string>("namaLokasi");
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            FormCari fp = new FormCari(this);
            fp.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void tampilPeta(string nama)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(1.1773530, 103.9250000);
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(1.1773530, 103.9250000), new Bitmap(Properties.Resources.Home_30px));
            marker.ToolTipText = "PT.Angin Ribut";
            marker.ToolTip.Fill = Brushes.Crimson;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Crimson;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            List<string>[] list;
            list = dbConnect.SelectLokasiDetil(nama);

            for (int i = 0; i < list[0].Count; i++)
            {
                Debug.Print(list[0][i]);
                points.Add(new PointLatLng(Convert.ToDouble(list[1][i]), Convert.ToDouble(list[0][i])));
            }

            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

        }

        
    }
}
