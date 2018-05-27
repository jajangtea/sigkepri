namespace sigkepri.FormReporting
{
    partial class FormWiupReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sigDataSet = new sigkepri.sigDataSet();
            this.dataTableWiupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableWiupTableAdapter = new sigkepri.sigDataSetTableAdapters.DataTableWiupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sigDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWiupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "izinWiup";
            reportDataSource3.Value = this.dataTableWiupBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sigkepri.RdlcReporting.izinWiupReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 388);
            this.reportViewer1.TabIndex = 0;
            // 
            // sigDataSet
            // 
            this.sigDataSet.DataSetName = "sigDataSet";
            this.sigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableWiupBindingSource
            // 
            this.dataTableWiupBindingSource.DataMember = "DataTableWiup";
            this.dataTableWiupBindingSource.DataSource = this.sigDataSet;
            // 
            // dataTableWiupTableAdapter
            // 
            this.dataTableWiupTableAdapter.ClearBeforeFill = true;
            // 
            // FormWiupReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 388);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormWiupReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIUP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormWiupReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sigDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableWiupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private sigDataSet sigDataSet;
        private System.Windows.Forms.BindingSource dataTableWiupBindingSource;
        private sigDataSetTableAdapters.DataTableWiupTableAdapter dataTableWiupTableAdapter;
    }
}