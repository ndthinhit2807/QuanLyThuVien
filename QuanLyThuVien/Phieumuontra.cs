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
            btnLuu_ctpm.Enabled = false;

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

            cboManv_pmt.DataSource = db.NHANVIENs;
            cboManv_pmt.ValueMember = "MANV";
            cboManv_pmt.DisplayMember = "MANV";

            cboMatdg_pmt.DataSource = db.THEDOCGIAs;
            cboMatdg_pmt.ValueMember = "MATHE";
            cboMatdg_pmt.DisplayMember = "MATHE";

            //var madg = db.THEDOCGIAs.FirstOrDefault(k => k.MATHE == cboMatdg_pmt.Text);
            //if (madg != null)
            //{
            //    txtMadg_pmt.Text = madg.MADOCGIA.ToString();
            //}


        }


        private void btnthemsuapmt_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUMUONTRA pmt = new PHIEUMUONTRA();
                pmt.MAPHIEUMUON = mskMa_phieumuontra.Text;
                pmt.MANV = cboManv_pmt.SelectedValue.ToString();
                pmt.MATHE = cboMatdg_pmt.SelectedValue.ToString();
                pmt.MADOCGIA = txtMadg_pmt.Text;
                pmt.NGAYLAP = Convert.ToDateTime(dtmngaylap_pmt.Value);

                var tests = db.PHIEUMUONTRAs.FirstOrDefault(p => p.MAPHIEUMUON == pmt.MAPHIEUMUON);
                if (tests == null)
                {
                    db.PHIEUMUONTRAs.InsertOnSubmit(pmt);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    loadpmt();
                    mskMa_phieumuontra.Clear();


                }
                else
                {
                    tests.MANV = cboManv_pmt.SelectedValue.ToString();
                    tests.MATHE = cboMatdg_pmt.SelectedValue.ToString();
                    tests.NGAYLAP = Convert.ToDateTime(dtmngaylap_pmt.Value);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    db.SubmitChanges();
                    loadpmt();
                    mskMa_phieumuontra.Clear();

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
                    mskMa_phieumuontra.Clear();
                }
        }

        void loadctpm()
        {
            var ctpm = from s in db.CTPMs
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
                    mskMa_phieumuontra.Clear();


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
                    mskMa_phieumuontra.Clear();

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
                    mskMa_phieumuontra.Clear();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadctpm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadpmt();
        }

        private void btntrasach_ctpm_Click(object sender, EventArgs e)
        {
            locktrasach();
        }

        private void btngiahan_ctpm_Click(object sender, EventArgs e)
        {
            lockgiahan();
        }

        void lockgiahan()
        {
            cbomapmt_ctpm.Enabled = false;
            cbotinhtrang.Enabled = false;
            txtsoluong_ctpm.Enabled = false;
            cbomasach_ctpm.Enabled = false;
            dtmngaytra.Enabled = false;

            btnthemsua_ctpm.Enabled = false;
            btnxoa_ctpm.Enabled = false;
            btntrasach_ctpm.Enabled = false;
            btnLuu_ctpm.Enabled = true;
        }

        void locktrasach()
        {
            cbomapmt_ctpm.Enabled = false;
            cbotinhtrang.Enabled = false;
            txtsoluong_ctpm.Enabled = false;
            cbomasach_ctpm.Enabled = false;
            dtmhantra.Enabled = false;

            btnthemsua_ctpm.Enabled = false;
            btnxoa_ctpm.Enabled = false;
            btngiahan_ctpm.Enabled = false;
            btnLuu_ctpm.Enabled = true;
        }


        void unlock()
        {
            cbomapmt_ctpm.Enabled = true;
            cbotinhtrang.Enabled = true;
            txtsoluong_ctpm.Enabled = true;
            cbomasach_ctpm.Enabled = true;
            dtmhantra.Enabled = true;
            dtmngaytra.Enabled = true;

            btnthemsua_ctpm.Enabled = true;
            btnxoa_ctpm.Enabled = true;
            btngiahan_ctpm.Enabled = true;
            btnLuu_ctpm.Enabled = true;
            btntrasach_ctpm.Enabled = true;
            btnLuu_ctpm.Enabled = false;
        }

        private void btnLuu_ctpm_Click(object sender, EventArgs e)
        {
            if (btngiahan_ctpm.Enabled == true)
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
                    mskMa_phieumuontra.Clear();
                    unlock();
                }
            }
            else
            {
                CTPM ctpm = new CTPM();
                ctpm.MAPHIEUMUON = cbomapmt_ctpm.SelectedValue.ToString();
                var testctpmm = db.CTPMs.FirstOrDefault(p => p.MAPHIEUMUON == ctpm.MAPHIEUMUON);
                if (testctpmm != null)
                {
                    testctpmm.NGAYTRA = Convert.ToDateTime(dtmngaytra.Value);

                    MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK);
                    db.SubmitChanges();
                    loadctpm();
                    mskMa_phieumuontra.Clear();
                    unlock();
                }
            }
        }

        private void btnHuy_ctpm_Click(object sender, EventArgs e)
        {
            unlock();
        }

        private void cboMatdg_pmt_KeyUp(object sender, KeyEventArgs e)
        {
            var madg = db.THEDOCGIAs.FirstOrDefault(k => k.MATHE == cboMatdg_pmt.Text);
            if (madg != null)
            {
                label5.Text = madg.DOCGIA.TENDOCGIA.ToString();
            }
        }

        private void cboMatdg_pmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            var madg = db.THEDOCGIAs.FirstOrDefault(k => k.MATHE == cboMatdg_pmt.Text);
            if (madg != null)
            {
                label5.Text = madg.DOCGIA.TENDOCGIA.ToString();
                txtMadg_pmt.Text = madg.MADOCGIA.ToString();
            }
        }
    }
}