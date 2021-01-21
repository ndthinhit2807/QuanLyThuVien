
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.procSachDuocMuonNhieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetreport1 = new QuanLyThuVien.datasetreport1();
            this.CTPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTao_thongke = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.procSachDuocMuonNhieuTableAdapter = new QuanLyThuVien.datasetreport1TableAdapters.procSachDuocMuonNhieuTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.procSachDuocMuonNhieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetreport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPMBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // btnTao_thongke
            // 
            this.btnTao_thongke.Image = ((System.Drawing.Image)(resources.GetObject("btnTao_thongke.Image")));
            this.btnTao_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTao_thongke.Location = new System.Drawing.Point(1131, 27);
            this.btnTao_thongke.Name = "btnTao_thongke";
            this.btnTao_thongke.Size = new System.Drawing.Size(185, 48);
            this.btnTao_thongke.TabIndex = 1;
            this.btnTao_thongke.Text = "Tạo Thống Kê";
            this.btnTao_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTao_thongke.UseVisualStyleBackColor = true;
            this.btnTao_thongke.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(559, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(882, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.procSachDuocMuonNhieuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1906, 690);
            this.reportViewer1.TabIndex = 3;
            // 
            // procSachDuocMuonNhieuTableAdapter
            // 
            this.procSachDuocMuonNhieuTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnTao_thongke);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1918, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(825, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ";
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 808);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Thongke";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procSachDuocMuonNhieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetreport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPMBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTao_thongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource CTPMBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource procSachDuocMuonNhieuBindingSource;
        private datasetreport1 datasetreport1;
        private datasetreport1TableAdapters.procSachDuocMuonNhieuTableAdapter procSachDuocMuonNhieuTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}