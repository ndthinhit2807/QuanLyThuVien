using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyThuVien
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();

        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'QuanLyThuVienDataSet.CTPM' table. You can move, or remove it, as needed.

            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var result = db.procSachDuocMuonNhieu("2020-01", "2020-07").ToArray();
            var reportdata = new ReportDataSource("QuanLyThuVienDataSet", result);
            this.reportViewer1.LocalReport.DataSources.Add(reportdata);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            //var result = db.procSachDuocMuonNhieu(dateTimePicker1.Value.ToString("yyyy-MM"), dateTimePicker2.Value.ToString("yyyy-MM")).ToArray();
            //var reportdata = new ReportDataSource("QuanLyThuVienDataSet", result);
            //this.reportViewer1.LocalReport.DataSources.Add(reportdata);
            //this.reportViewer1.RefreshReport();
        }
    }
}