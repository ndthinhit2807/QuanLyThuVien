
namespace QuanLyThuVien
{
    partial class Thongke
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
            this.procSachDuocMuonNhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetreport1 = new QuanLyThuVien.datasetreport1();
            this.CTPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.procSachDuocMuonNhieuTableAdapter = new QuanLyThuVien.datasetreport1TableAdapters.procSachDuocMuonNhieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.procSachDuocMuonNhieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetreport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // procSachDuocMuonNhieuBindingSource
            // 
            this.procSachDuocMuonNhieuBindingSource.DataMember = "procSachDuocMuonNhieu";
            this.procSachDuocMuonNhieuBindingSource.DataSource = this.datasetreport1;
            // 
            // datasetreport1
            // 
            this.datasetreport1.DataSetName = "datasetreport1";
            this.datasetreport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CTPMBindingSource
            // 
            this.CTPMBindingSource.DataMember = "CTPM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "thông ke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(400, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.procSachDuocMuonNhieuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(102, 130);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 3;
            // 
            // procSachDuocMuonNhieuTableAdapter
            // 
            this.procSachDuocMuonNhieuTableAdapter.ClearBeforeFill = true;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 413);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procSachDuocMuonNhieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetreport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource CTPMBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource procSachDuocMuonNhieuBindingSource;
        private datasetreport1 datasetreport1;
        private datasetreport1TableAdapters.procSachDuocMuonNhieuTableAdapter procSachDuocMuonNhieuTableAdapter;
    }
}