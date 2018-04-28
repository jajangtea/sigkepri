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

namespace sigkepri
{
    public partial class FormGreatMap : Form
    {
        private DBConnect dbConnect;
        public FormGreatMap()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            comboBoxMode.DataSource = Enum.GetValues(typeof(AccessMode));
            comboBoxMode.SelectedItem = gmap.Manager.Mode;
        }

        private void FormGreatMap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(1.1773530, 103.9250000);

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(1.1773530, 103.9250000),new Bitmap(Properties.Resources.Home_30px));
            marker.ToolTipText = "PT.Angin Ribut";
            marker.ToolTip.Fill = Brushes.Crimson;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Crimson;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            ///  GMarkerGoogle marker = new GMapMarker(new PointLatLng(1.1773530, 103.9250000), GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            List<string>[] list;
            list = dbConnect.SelectLokasiDetil();

            for (int i = 0; i < list[0].Count; i++)
            {
                Debug.Print(list[0][i]);
                points.Add(new PointLatLng(Convert.ToDouble( list[0][i]), Convert.ToDouble(list[1][i])));
            }

            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gmap.Overlays.Add(polyOverlay);

        }
        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Console.WriteLine(String.Format("Marker {0} was clicked.", item.Tag));
           // FormInfoLokasi fl = new FormInfoLokasi();
          //  fl.ShowDialog();
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
    }
}
