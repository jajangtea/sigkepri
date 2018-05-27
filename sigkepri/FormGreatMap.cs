using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Reflection;
using System.Collections;
using ConnectCsharpToMysql;
using MySql.Data.MySqlClient;
using System.Data;

namespace sigkepri
{
    public partial class FormGreatMap : Form
    {
        private DBConnect dbConnect;
        public DataTable dtKabKota = new DataTable();
        public DataTable dtkomoditi = new DataTable();
        public FormGreatMap()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            comboBoxMode.DataSource = Enum.GetValues(typeof(AccessMode));
            comboBoxMode.SelectedItem = gmap.Manager.Mode;
            if (!GMapControl.IsDesignerHosted)
            {
                gmap.OnMapTypeChanged += new MapTypeChanged(gmap_OnMapTypeChanged);
            }

            this.tampilComboKabKota(cbbKabKota, "namaKabKota", "idKabKota");
            this.tampilComboKomoditi(cbbKomoditas, "namaBahanGalian", "idBahanGalian");

        }

        public void tampilPenanda()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            List<PointLatLng> points = new List<PointLatLng>();
            List<string>[] list;
            list = dbConnect.selectPenanda();
            for (int i = 0; i < list[0].Count; i++)
            {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(list[1][i]), Convert.ToDouble(list[2][i])), new Bitmap(Properties.Resources.Marker_16px));
                points.Add(new PointLatLng(Convert.ToDouble(list[1][i]), Convert.ToDouble(list[2][i])));
                marker.ToolTipText = list[0][i];
                marker.ToolTip.Fill = Brushes.Crimson;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Crimson;
                marker.ToolTip.TextPadding = new Size(20, 20);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
        }

        private void FormGreatMap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.CacheLocation="C:\\cache";
            gmap.Position = new PointLatLng(1.082828, 104.030457);
            comboBoxMapType.ValueMember = "Name";
            comboBoxMapType.DataSource = GMapProviders.List;
            comboBoxMapType.SelectedItem = gmap.MapProvider;

            this.tampilPenanda();
            this.gambarpolygon();

        }
        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            //Console.WriteLine(String.Format("Marker {0} was clicked.", item.Tag));
            //FormInfoLokasi fl = new FormInfoLokasi();
            //fl.ShowDialog();
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // acccess mode
            comboBoxMode.DataSource = Enum.GetValues(typeof(AccessMode));
            comboBoxMode.SelectedItem = gmap.Manager.Mode;
        }

        private void comboBoxMode_DropDownClosed(object sender, EventArgs e)
        {
            gmap.Manager.Mode = (AccessMode)comboBoxMode.SelectedValue;
            gmap.ReloadMap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double lat = double.Parse(textBoxLat.Text, CultureInfo.InvariantCulture);
                double lng = double.Parse(textBoxLng.Text, CultureInfo.InvariantCulture);

                gmap.Position = new PointLatLng(lat, lng);
            }
            catch (Exception ex)
            {
                MessageBox.Show("incorrect coordinate format: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG (*.png)|*.png";
                    sfd.FileName = "GMap.NET image";

                    Image tmpImage = gmap.ToImage();
                    if (tmpImage != null)
                    {
                        using (tmpImage)
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                tmpImage.Save(sfd.FileName);

                                MessageBox.Show("Image saved: " + sfd.FileName, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image failed to save: " + ex.Message, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            gmap.Zoom = trackBar1.Value / 100.0;
        }





        private void comboBoxMapType_DropDownClosed(object sender, EventArgs e)
        {
            //  gmap.MapType = (MapType)comboBoxMapType.SelectedValue;
        }

        private void gmap_OnMapTypeChanged(GMapProvider type)
        {
            comboBoxMapType.SelectedItem = type;

            trackBar1.Minimum = gmap.MinZoom * 100;
            trackBar1.Maximum = gmap.MaxZoom * 100;
        }

        private void comboBoxMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gmap.MapProvider = (GMapProvider)comboBoxMapType.SelectedItem;
                trackBar1.Minimum = gmap.MinZoom * 100;
                trackBar1.Maximum = gmap.MaxZoom * 100;
            }
            catch (Exception)
            {
               // MessageBox.Show("map belum support" + ed);
            }

        }

        public void gambarpolygon()
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new PointLatLng(3.945651, 108.142867);


            List<string>[] listPerusahaan;
            listPerusahaan = dbConnect.SelectPerusahaan();
            string _namaPerusahaan;
            for (int jj = 0; jj < listPerusahaan[1].Count; jj++)
            {
                _namaPerusahaan = listPerusahaan[1][jj];
                GMapOverlay polyOverlay = new GMapOverlay("polygons");
                List<PointLatLng> points = new List<PointLatLng>();
                List<string>[] list;
                list = dbConnect.SelectLokasiDetil(_namaPerusahaan);
                for (int i = 0; i < list[0].Count; i++)
                {
                    points.Add(new PointLatLng(Convert.ToDouble(list[0][i]), Convert.ToDouble(list[1][i])));
                }
                GMapPolygon polygon = new GMapPolygon(points, "PT. Sukses");
                polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                polygon.Stroke = new Pen(Color.Red, 1);
                polyOverlay.Polygons.Add(polygon);
                gmap.Overlays.Add(polyOverlay);
            }
            gmap.Zoom = 7;
        }


        public void gambarpolygonKota(string _namaKota)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new PointLatLng(3.945651, 108.142867);
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            List<string>[] list;
            list = dbConnect.SelectLokasiKota(_namaKota);
            for (int i = 0; i < list[0].Count; i++)
            {
                points.Add(new PointLatLng(Convert.ToDouble(list[0][i]), Convert.ToDouble(list[1][i])));
            }
            GMapPolygon polygon = new GMapPolygon(points, "PT. Sukses");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

            gmap.Zoom = 7;
        }

        public void gambarpolygonKomoditi(string _komoditi)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new PointLatLng(3.945651, 108.142867);

            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            List<string>[] list;
            list = dbConnect.SelectLokasiKota(_komoditi);
            for (int i = 0; i < list[0].Count; i++)
            {
                points.Add(new PointLatLng(Convert.ToDouble(list[0][i]), Convert.ToDouble(list[1][i])));
            }
            GMapPolygon polygon = new GMapPolygon(points, "PT. Sukses");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);
            gmap.Zoom = 7;
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

        public void tampilComboKomoditi(ComboBox cbKomoditi, string list, string nilai)
        {
            try
            {
                string sql = "select * from esdm_bahan_galian order by namaBahanGalian";
                dbConnect.OpenConnection();
                dbConnect.cmd = new MySqlCommand(sql, dbConnect.connection);
                dbConnect.tampil = new MySqlDataAdapter(dbConnect.cmd);
                dbConnect.ds.Clear();
                dbConnect.tampil.Fill(dtkomoditi);
                DataView dvKomoditi = new DataView(dtkomoditi);
                cbKomoditi.DataSource = dvKomoditi;
                cbKomoditi.DisplayMember = list;
                cbKomoditi.ValueMember = nilai;
                dbConnect.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gambarpolygonKomoditi(cbbKomoditas.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gambarpolygonKota(cbbKabKota.Text);
        }
    }
}
