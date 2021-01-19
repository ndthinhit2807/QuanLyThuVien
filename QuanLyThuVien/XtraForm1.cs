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
            // TODO: This line of code loads data into the 'datasetreport1.procSachDuocMuonNhieu' table. You can move, or remove it, as needed.
            //this.procSachDuocMuonNhieuTableAdapter.Fill(this.datasetreport1.procSachDuocMuonNhieu, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

            string month1 = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
            string fromdate = dateTimePicker1.Value.Year.ToString() + "-" + month1;
            string month2 = dateTimePicker2.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Month.ToString() : dateTimePicker2.Value.Month.ToString();
            string todate = dateTimePicker2.Value.Year.ToString() + "-" + month2;
            
            this.procSachDuocMuonNhieuTableAdapter.Fill(this.datasetreport1.procSachDuocMuonNhieu, fromdate, todate);
           
            //// TODO: This line of code loads data into the 'QuanLyThuVienDataSet.CTPM' table. You can move, or remove it, as needed.

            //this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            // var result = db.procSachDuocMuonNhieu(dateTimePicker1.Value.ToString(),dateTimePicker2.Value.ToString()).ToArray();
            //  var reportdata = new ReportDataSource("QuanLyThuVienDataSet", result);
            //  this.reportViewer1.LocalReport.DataSources.Add(reportdata);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month1 = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
            string fromdate = dateTimePicker1.Value.Year.ToString() + "-" + month1;
            string month2 = dateTimePicker2.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Month.ToString() : dateTimePicker2.Value.Month.ToString();
            string todate = dateTimePicker2.Value.Year.ToString() + "-" + month2;

            this.procSachDuocMuonNhieuTableAdapter.Fill(this.datasetreport1.procSachDuocMuonNhieu, fromdate, todate);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}