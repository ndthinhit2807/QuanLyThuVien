using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmPhieumuontra : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieumuontra()
        {
            InitializeComponent();
        }

        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();



        private void ctpm_Load(object sender, EventArgs e)
        {

            loadpmt();
            loadctpm();

        }

        void loadpmt()
        {
            var pmt = from s in db.PHIEUMUONTRAs
                     select new
                     {
                         s.MAPHIEUMUON,
                         s.MANV,
                         s.NHANVIEN.HOTENNV,
                         s.MATHE,
                         s.THEDOCGIA.DOCGIA.TENDOCGIA,
                         s.NGAYLAP
                         
                     };
            dgvpmt.DataSource = pmt;

            cbomanv_pmt.DataSource = db.NHANVIENs;
            cbomanv_pmt.ValueMember = "MANV";
            cbomanv_pmt.DisplayMember = "MANV";

            cbomatdg_pmt.DataSource = db.THEDOCGIAs;
            cbomatdg_pmt.ValueMember = "MATHE";
            cbomatdg_pmt.DisplayMember = "MATHE";

            var madg = db.THEDOCGIAs.FirstOrDefault(k => k.MATHE == cbomatdg_pmt.Text);
            if (madg != null)
            {
                txtmadg_pmt.Text = madg.MADOCGIA.ToString();
            }


        }

        void loadctpm()
        {
            var ctpm = from s in db.CTPMs

                       
                       //join d in db.PHIEUMUONTRAs on s.MAPHIEUMUON equals d.MAPHIEUMUON
                       //join a in db.NHANVIENs on d.MANV equals a.MANV
                       // join b in db.THEDOCGIAs on a.MANV equals b.MANV
                       

                     
                       select new
                       {
                           s.PHIEUMUONTRA.MAPHIEUMUON,
                           s.PHIEUMUONTRA.MANV,
                           s.PHIEUMUONTRA.NHANVIEN.HOTENNV,
                           s.PHIEUMUONTRA.MATHE,
                           s.PHIEUMUONTRA.THEDOCGIA.DOCGIA.TENDOCGIA,
                           s.DAUSACH.MASACH,
                           s.DAUSACH.TENSACH,
                           s.TINHTRANG,
                           s.SOLUONG,
                           s.PHIEUMUONTRA.NGAYLAP,
                           s.HANTRA,
                           s.NGAYTRA
                          
                           
                           

                       };

            dgvctpm.DataSource = ctpm.ToList();

            cbomapmt_ctpm.DataSource = db.PHIEUMUONTRAs;
            cbomapmt_ctpm.DisplayMember = "MAPHIEUMUON";
            cbomapmt_ctpm.ValueMember = "MAPHIEUMUON";

            cbomasach_ctpm.DataSource = db.DAUSACHes;
            cbomasach_ctpm.DisplayMember = "TENSACH";
            cbomasach_ctpm.ValueMember = "MASACH";

       

         

            cbotinhtrang.SelectedIndex = 0;




        }

        private void btnthemsuapmt_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUMUONTRA pmt = new PHIEUMUONTRA();
                pmt.MAPHIEUMUON = txtmapmt.Text;
                pmt.MANV = cbomanv_pmt.SelectedValue.ToString();
                pmt.MATHE = cbomatdg_pmt.SelectedValue.ToString();
                pmt.MADOCGIA = txtmadg_pmt.Text;
                pmt.NGAYLAP = Convert.ToDateTime(dtmpmt.Value);

                var tests = db.PHIEUMUONTRAs.FirstOrDefault(p => p.MAPHIEUMUON == pmt.MAPHIEUMUON);
                if (tests == null)
                {
                    db.PHIEUMUONTRAs.InsertOnSubmit(pmt);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    loadpmt();
                    txtmapmt.Clear();


                }
                else
                {
                    tests.MANV = cbomanv_pmt.SelectedValue.ToString();
                    tests.MATHE = cbomatdg_pmt.SelectedValue.ToString();
                    tests.NGAYLAP = Convert.ToDateTime(dtmpmt.Value);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    db.SubmitChanges();
                    loadpmt();
                    txtmapmt.Clear();

                }

            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }


        private void btnxoapmt_Click(object sender, EventArgs e)
        {
            PHIEUMUONTRA pmt = new PHIEUMUONTRA();
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (DataGridViewRow row in dgvpmt.SelectedRows)
                {
                    var numrow = row.Cells[0].Value;
                    pmt = db.PHIEUMUONTRAs.FirstOrDefault(s => s.MAPHIEUMUON == numrow.ToString());
                    if (pmt != null)
                    {
                        db.PHIEUMUONTRAs.DeleteOnSubmit(pmt);
                    }
                    db.SubmitChanges();
                    loadpmt();
                    MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    txtmapmt.Clear();
                }
        }

        private void btnthemsua_ctpm_Click(object sender, EventArgs e)
        {

            try
            {
                CTPM ctpm = new CTPM();
               

                ctpm.MAPHIEUMUON = cbomapmt_ctpm.SelectedValue.ToString();
                ctpm.MASACH = cbomasach_ctpm.SelectedValue.ToString();
          
                ctpm.HANTRA = Convert.ToDateTime(dtmhantra.Value);
                //ctpm.NGAYTRA = Convert.ToDateTime(dtmngaytra.Value);
                ctpm.SOLUONG = txtsoluong_ctpm.Text;
                ctpm.TINHTRANG = cbotinhtrang.Text;


                var testctpm = db.CTPMs.FirstOrDefault(p => p.MAPHIEUMUON == ctpm.MAPHIEUMUON);
                if (testctpm == null)
                {
                    db.CTPMs.InsertOnSubmit(ctpm);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    loadctpm();
                    txtmapmt.Clear();


                }
                else
                {
                  //  testctpm.PHIEUMUONTRA.MANV = cbomanvtra_ctpm.SelectedValue.ToString();
                    testctpm.MASACH = cbomasach_ctpm.SelectedValue.ToString();
                    
                    testctpm.HANTRA = Convert.ToDateTime(dtmhantra.Value);
                    //testctpm.NGAYTRA = Convert.ToDateTime(dtmngaytra.Value);
                    testctpm.SOLUONG = txtsoluong_ctpm.Text;
                    testctpm.TINHTRANG = cbotinhtrang.Text;
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    db.SubmitChanges();
                    loadctpm();
                    txtmapmt.Clear();

                }

            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnxoa_ctpm_Click(object sender, EventArgs e)
        {
            CTPM ctpm = new CTPM();
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (DataGridViewRow row in dgvpmt.SelectedRows)
                {
                    var numrow = row.Cells[0].Value;
                    ctpm = db.CTPMs.FirstOrDefault(s => s.MAPHIEUMUON == numrow.ToString());
                    if (ctpm != null)
                    {
                        db.CTPMs.DeleteOnSubmit(ctpm);
                    }
                    db.SubmitChanges();
                    loadctpm();
                    MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    txtmapmt.Clear();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadctpm();
        }

        private void cbomatdg_pmt_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadpmt();
        }

        private void btntrasach_ctpm_Click(object sender, EventArgs e)
        {
            CTPM ctpm = new CTPM();
            ctpm.MAPHIEUMUON = cbomapmt_ctpm.SelectedValue.ToString();
            var testctpmm = db.CTPMs.FirstOrDefault(p => p.MAPHIEUMUON == ctpm.MAPHIEUMUON);
            if(testctpmm != null)
            {

            testctpmm.NGAYTRA = Convert.ToDateTime(dtmngaytra.Value);
         
            MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK);
            db.SubmitChanges();
            loadctpm();
            txtmapmt.Clear();
            }
        }

        private void btngiahan_ctpm_Click(object sender, EventArgs e)
        {
            CTPM ctpm = new CTPM();
            ctpm.MAPHIEUMUON = cbomapmt_ctpm.SelectedValue.ToString();
            var testctpmm = db.CTPMs.FirstOrDefault(p => p.MAPHIEUMUON == ctpm.MAPHIEUMUON);
            if (testctpmm != null)
            {

                testctpmm.HANTRA = Convert.ToDateTime(dtmhantra.Value);

                MessageBox.Show("Gia hạn thành công", "Thông báo", MessageBoxButtons.OK);
                db.SubmitChanges();
                loadctpm();
                txtmapmt.Clear();
            }
        }
    }
}