namespace xtremgym
{
    partial class frmMostrarReportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReporte = new xtremgym.DataSetReporte();
            this.reporteFechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteFechTableAdapter = new xtremgym.DataSetReporteTableAdapters.reporteFechTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFechBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteFechBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "xtremgym.ReporteF.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(551, 505);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSetReporte
            // 
            this.DataSetReporte.DataSetName = "DataSetReporte";
            this.DataSetReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteFechBindingSource
            // 
            this.reporteFechBindingSource.DataMember = "reporteFech";
            this.reporteFechBindingSource.DataSource = this.DataSetReporte;
            // 
            // reporteFechTableAdapter
            // 
            this.reporteFechTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMostrarReportes";
            this.Text = "frmMostrarReportes";
            this.Load += new System.EventHandler(this.frmMostrarReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFechBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteFechBindingSource;
        private DataSetReporte DataSetReporte;
        private DataSetReporteTableAdapters.reporteFechTableAdapter reporteFechTableAdapter;
    }
}