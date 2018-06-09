namespace NHAHANG_RIENG
{
    partial class HoaDon
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
            this.BILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYNHAHANGDataSet = new NHAHANG_RIENG.QUANLYNHAHANGDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BILLTableAdapter = new NHAHANG_RIENG.QUANLYNHAHANGDataSetTableAdapters.BILLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYNHAHANGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BILLBindingSource
            // 
            this.BILLBindingSource.DataMember = "BILL";
            this.BILLBindingSource.DataSource = this.QUANLYNHAHANGDataSet;
            // 
            // QUANLYNHAHANGDataSet
            // 
            this.QUANLYNHAHANGDataSet.DataSetName = "QUANLYNHAHANGDataSet";
            this.QUANLYNHAHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BILLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NHAHANG_RIENG.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 398);
            this.reportViewer1.TabIndex = 0;
            // 
            // BILLTableAdapter
            // 
            this.BILLTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 398);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYNHAHANGDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BILLBindingSource;
        private QUANLYNHAHANGDataSet QUANLYNHAHANGDataSet;
        private QUANLYNHAHANGDataSetTableAdapters.BILLTableAdapter BILLTableAdapter;
    }
}