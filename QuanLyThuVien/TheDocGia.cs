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
    public partial class frmTheDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTheDocGia()
        {
            InitializeComponent();
        }
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        //Load dữ liệu từ database vào DataGirdview khi debug
        private void TheDocGia_Load(object sender, EventArgs e)
        {
            cboTim_thedocgia.SelectedIndex = 0; //combobox tìm kiếm mặc định là mã độc giả
            loadtdg();
        }
        //Load không bị thừa dữ liẹu 
        void loadtdg()
        {
            {
                var thedocgia1 = from tbtdg in db.THEDOCGIAs
                                 join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                                 join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                                 select new
                                 {
                                     tbtdg.MATHE,
                                     tbnv.MANV,
                                     tbdg.MADOCGIA,
                                     tbtdg.NGAYLAP,
                                     tbtdg.NGAYHETHAN
                                 };
                dgvTheDocGia.DataSource = thedocgia1.ToList();

                cboManv_thedocgia.DataSource = db.NHANVIENs;
                cboManv_thedocgia.ValueMember = "MANV";
                cboManv_thedocgia.DisplayMember = "MANV";

                cboMadocgia_thedocgia.DataSource = db.DOCGIAs;
                cboMadocgia_thedocgia.ValueMember = "MADOCGIA";
                cboMadocgia_thedocgia.DisplayMember = "MADOCGIA";

               // dtmNgaylap_thedocgia.MinDate = DateTime.Now;
               // dtmHethan_thedocgia.Value = DateTime.Now.AddYears(1);
            }
        }

        //Tìm kiếm phần tử trong bảng DataGridView theo Mã Độc Giả, Mã Nhân Viên, Mã Thẻ
        private void txtTimKiemTheDocGia_TextChanged(object sender, EventArgs e)
        {
            if (cboTim_thedocgia.Text == "Mã Độc Giả")//Tìm kiếm theo mã độc giả
            {

                THEDOCGIA tdg = new THEDOCGIA();
                var search = from tbtdg in db.THEDOCGIAs
                             join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                             join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                             where tbtdg.MADOCGIA.Contains(txtTim_thedocgia.Text)
                             select new
                             {
                                 tbtdg.MATHE,
                                 tbnv.MANV,
                                 tbdg.MADOCGIA,
                                 tbtdg.NGAYLAP,
                                 tbtdg.NGAYHETHAN
                             };
                dgvTheDocGia.DataSource = search;//Bắt đầu tìm kiếm
            }
            if (cboTim_thedocgia.Text == "Mã Nhân Viên")//Tìm kiếm theo mã nhân viên
            {
                THEDOCGIA tdg = new THEDOCGIA();
                var search = from tbtdg in db.THEDOCGIAs
                             join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                             join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                             where tbtdg.MANV.Contains(txtTim_thedocgia.Text)
                             select new
                             {
                                 tbtdg.MATHE,
                                 tbnv.MANV,
                                 tbdg.MADOCGIA,
                                 tbtdg.NGAYLAP,
                                 tbtdg.NGAYHETHAN
                             };
                dgvTheDocGia.DataSource = search;
            }
            if (cboTim_thedocgia.Text == "Mã Thẻ")//Tìm kiếm theo mã thẻ
            {
                THEDOCGIA tdg = new THEDOCGIA();
                var search = from tbtdg in db.THEDOCGIAs
                             join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                             join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                             where tbtdg.MATHE.Contains(txtTim_thedocgia.Text)
                             select new
                             {
                                 tbtdg.MATHE,
                                 tbnv.MANV,
                                 tbdg.MADOCGIA,
                                 tbtdg.NGAYLAP,
                                 tbtdg.NGAYHETHAN
                             };
                dgvTheDocGia.DataSource = search;
            }
        }

        private void dgvTheDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMadocgia_thedocgia.Text = dgvTheDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
            cboManv_thedocgia.Text = dgvTheDocGia.Rows[e.RowIndex].Cells[1].Value.ToString();
            mskMa_thedocgia.Text = dgvTheDocGia.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtmNgaylap_thedocgia.Text = dgvTheDocGia.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtmHethan_thedocgia.Text = dgvTheDocGia.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnthemsua_thedocgia_Click(object sender, EventArgs e)
        {
            try
            {
                THEDOCGIA tdg = new THEDOCGIA();
                tdg.MATHE = mskMa_thedocgia.Text.Trim();
                tdg.MANV = cboManv_thedocgia.SelectedValue.ToString();
                tdg.MADOCGIA = cboMadocgia_thedocgia.SelectedValue.ToString();
                tdg.NGAYLAP = Convert.ToDateTime(dtmNgaylap_thedocgia.Value);
                tdg.NGAYHETHAN = Convert.ToDateTime(dtmHethan_thedocgia.Value);
                var test_tdg = db.THEDOCGIAs.FirstOrDefault(p => p.MATHE == tdg.MATHE || p.MADOCGIA == tdg.MADOCGIA);
                if (test_tdg == null)
                {
                    db.THEDOCGIAs.InsertOnSubmit(tdg);
                    db.SubmitChanges();
                    loadtdg();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    mskMa_thedocgia.Clear();
                }
                else
                {
                    tdg = db.THEDOCGIAs.Where(p => p.MATHE == mskMa_thedocgia.Text).Single();
                    tdg.MATHE = mskMa_thedocgia.Text.Trim();
                    tdg.MANV = cboManv_thedocgia.SelectedValue.ToString();
                    tdg.MADOCGIA = cboMadocgia_thedocgia.SelectedValue.ToString();
                    tdg.NGAYLAP = Convert.ToDateTime(dtmNgaylap_thedocgia.Value);
                    tdg.NGAYHETHAN = Convert.ToDateTime(dtmHethan_thedocgia.Value);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    mskMa_thedocgia.Clear();
                    db.SubmitChanges();
                    loadtdg();
                }
            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_thedocgia_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var delete = db.THEDOCGIAs.FirstOrDefault(p => p.MATHE == mskMa_thedocgia.Text);
                    if (delete != null)
                    {
                        db.THEDOCGIAs.DeleteOnSubmit(delete);
                        db.SubmitChanges();
                        loadtdg();
                        MessageBox.Show("Xóa Thành Công !!!");
                        mskMa_thedocgia.Clear();
                    }
                    else
                    {
                        MessageBox.Show("lỗi rồi!!!");
                    }
                }
            }
        }

        private void btnLammoi_thedocgia_Click(object sender, EventArgs e)
        {
            loadtdg();
        }
    }
}