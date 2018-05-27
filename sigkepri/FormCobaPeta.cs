using GMap.NET;
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
    public partial class FormCobaPeta : Form
    {
        public FormCobaPeta()
        {
            InitializeComponent();

        }

        private void FormCobaPeta_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
         //   gmap.Position = new PointLatLng(1.082828, 104.030457);
        }
    }
}
