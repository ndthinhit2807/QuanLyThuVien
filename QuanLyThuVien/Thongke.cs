using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyThuVien
{
    public partial class Thongke : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();

        public Thongke()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        { 

            string month1 = dateTimePicker1.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker1.Value.Month.ToString() : dateTimePicker1.Value.Month.ToString();
            string fromdate = dateTimePicker1.Value.Year.ToString() + "-" + month1;
            string month2 = dateTimePicker2.Value.Month.ToString().Length < 2 ? "0" + dateTimePicker2.Value.Month.ToString() : dateTimePicker2.Value.Month.ToString();
            string todate = dateTimePicker2.Value.Year.ToString() + "-" + month2;
            
            this.procSachDuocMuonNhieuTableAdapter.Fill(this.datasetreport1.procSachDuocMuonNhieu, fromdate, todate);
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

      
    }
}