using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri.FormReporting
{
    public partial class FormIzinReport : Form
    {
        public FormIzinReport()
        {
            InitializeComponent();
        }



        public void cetaklapiupaktif(string tahap)
        {
            this.dataTable1TableAdapter.FillByTahapAktif(this.sigDataSet.DataTable1, tahap);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.Width = 75;
            this.reportViewer1.RefreshReport();
        }
        public void cetaklapiuptidakaktif(string tahap)
        {
            this.dataTable1TableAdapter.FillByTidakAktif(this.sigDataSet.DataTable1, tahap);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.Width = 75;
            this.reportViewer1.RefreshReport();
        }

       
    }
}
