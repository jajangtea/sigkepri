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
    public partial class FormWiupReport : Form
    {
        public FormWiupReport()
        {
            InitializeComponent();
        }

        private void FormWiupReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sigDataSet.DataTableWiup' table. You can move, or remove it, as needed.
            this.dataTableWiupTableAdapter.Fill(this.sigDataSet.DataTableWiup);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.Width = 75;
            this.reportViewer1.RefreshReport();
        }
    }
}
