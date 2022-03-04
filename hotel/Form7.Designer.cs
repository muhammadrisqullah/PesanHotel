namespace hotel
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HotelDataSet = new hotel.HotelDataSet();
            this.PesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PesananTableAdapter = new hotel.HotelDataSetTableAdapters.PesananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PesananBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "hotel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(806, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // HotelDataSet
            // 
            this.HotelDataSet.DataSetName = "HotelDataSet";
            this.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PesananBindingSource
            // 
            this.PesananBindingSource.DataMember = "Pesanan";
            this.PesananBindingSource.DataSource = this.HotelDataSet;
            // 
            // PesananTableAdapter
            // 
            this.PesananTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.Text = "Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReport_FormClosed);
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesananBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PesananBindingSource;
        private HotelDataSet HotelDataSet;
        private HotelDataSetTableAdapters.PesananTableAdapter PesananTableAdapter;
    }
}