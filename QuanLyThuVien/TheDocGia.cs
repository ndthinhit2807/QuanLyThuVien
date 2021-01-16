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
            cboTimKiem1.SelectedIndex = 0; //combobox tìm kiếm mặc định là mã độc giả
            LoadTheDocGia();
            Loadsuathedocgia();
            Demsodong();
        }
        //Load không bị thừa dữ liẹu 
        void LoadTheDocGia()
        {
            

            {

                var thedocgia1 = from tbtdg in db.THEDOCGIAs
                                 join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                                 join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                                 select new
                                 {
                                     tbdg.MADOCGIA,
                                     tbnv.MANV,
                                     tbtdg.MATHE,
                                     tbtdg.NGAYLAP,
                                     tbtdg.NGAYHETHAN
                                 };
                dgvTheDocGia.DataSource = thedocgia1.ToList();
                cboMaNV1.DataSource = db.NHANVIENs;
                cboMaNV1.ValueMember = "HOTENNV";
                cboMaNV1.DisplayMember = "MANV";

                cboMaDocGia.DataSource = db.DOCGIAs;
                cboMaDocGia.ValueMember = "TENDOCGIA";
                cboMaDocGia.DisplayMember = "MADOCGIA";
            }
        }
        //Khoá chức năng Lưu,huỷ,...
        public void Lockcontroll()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboMaNV1.Enabled = false;
            cboMaDocGia.Enabled = false;
            txtMaThe.ReadOnly = true;//Chỉ được đọc dữ liệu
            dtmNgayLap.Enabled = false;
            dtmNgayHetHan.Enabled = false;
        }
        // Mở khoá các chức năng Lưu,Huỷ,...
        public void Unlockcontrol()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cboMaDocGia.Enabled = true;
            cboMaNV1.Enabled = true;
            txtMaThe.ReadOnly = false;
            dtmNgayHetHan.Enabled = true;
            dtmNgayLap.Enabled = true;
        }
        //Load lại datagridview khi ấn nút "sửa" hoặc Click vào 1 phần tử trong DataGridview
        void Loadsuathedocgia()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboMaNV1.Enabled = true;
            cboMaDocGia.Enabled = true;
            txtMaThe.ReadOnly = true;
            dtmNgayLap.Enabled = true;
            dtmNgayHetHan.Enabled = true;
        }
        //Reset phần nhập thông tin
        private void RsNhaplieu()
        {
            txtMaThe.Clear();
            cboMaDocGia.SelectedIndex = 0;
            dtmNgayHetHan.Text = DateTime.Now.ToString();
            dtmNgayLap.Text = DateTime.Now.ToString();
            cboMaNV1.SelectedIndex = 0;
        }
        // Đếm số dòng trong datagridview
        void Demsodong()
        {
            lblDemdong.Text = dgvTheDocGia.Rows.Count.ToString();
        }
        //Thêm dữ liệu mới vào datagridview
        private void btnThem_Click(object sender, EventArgs e)
        {
            RsNhaplieu();
            Unlockcontrol();
        }
        //Luu thông tin vừa nhập vào datagridview
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            THEDOCGIA tdg = new THEDOCGIA();
            try
            {
                // kiểm tra đã nhập dữ liệu chưa
                if (txtMaThe.Text == "")
                {
                    MessageBox.Show("Chưa nhập Mã Thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Gán các giá trị
                tdg.MADOCGIA = cboMaDocGia.Text;
                tdg.MATHE = txtMaThe.Text;
                tdg.MANV = cboMaNV1.Text;
                tdg.NGAYLAP = Convert.ToDateTime(dtmNgayLap.Value); // convert datetime từ data base sang winform c#
                tdg.NGAYHETHAN = Convert.ToDateTime(dtmNgayHetHan.Value);
                //Thêm vào CSDL
                db.THEDOCGIAs.InsertOnSubmit(tdg);
                //Xác nhận
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                Lockcontroll();
                LoadTheDocGia();
                Demsodong();
            }
            catch
            {
                MessageBox.Show("Đã tồn tại thẻ độc giả này, hoặc mã thẻ nhập quá 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);// bị trùng mã thẻ
            }
        }
        //Sửa thông tin trong bảng Datagridview
        private void btnSua_Click(object sender, EventArgs e)
        {

            
            THEDOCGIA tdg = new THEDOCGIA();
            try
            {
                tdg = db.THEDOCGIAs.Where(p => p.MATHE == txtMaThe.Text).Single();//Gán điều kiện không được sửa mã thẻ
                tdg.MANV = cboMaNV1.Text;
                tdg.MADOCGIA = cboMaDocGia.Text;
                tdg.NGAYLAP = Convert.ToDateTime(dtmNgayLap.Value);//convert datetime từ database sang TodateTime winform c#
                tdg.NGAYHETHAN = Convert.ToDateTime(dtmNgayHetHan.Value);
                db.SubmitChanges();
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                Loadsuathedocgia();
                LoadTheDocGia();
                Demsodong();
            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Reset thông tin vừa nhập
        private void btnHuy_Click(object sender, EventArgs e)
        {
            RsNhaplieu();
            Loadsuathedocgia();
        }
        //Xoá 1 phần tử trong DataGridview
        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            THEDOCGIA tdg = new THEDOCGIA();
            try
            {
                if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    foreach (DataGridViewRow row in dgvTheDocGia.SelectedRows)
                    {
                        var numrow = row.Cells[0].Value;
                        tdg = db.THEDOCGIAs.FirstOrDefault(s => s.MADOCGIA == numrow.ToString());
                        if (tdg != null)//Xoá dữ liệu, nếu có dữ liệu trong bảng Datagirdview
                        {
                            db.THEDOCGIAs.DeleteOnSubmit(tdg);
                        }
                        db.SubmitChanges();
                        MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        LoadTheDocGia();
                        Demsodong();
                    }
            }
            catch
            {
                MessageBox.Show("Chọn Sách Để Xoá", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        //Hiện dữ lệu từ DataGridView lên phần nhập thông tin
        private void dgvTheDocGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheDocGia.SelectedRows.Count == 0) return;
            int dong = dgvTheDocGia.CurrentRow.Index;
            if (dgvTheDocGia.Rows[dong].Cells[0].Value == null) return;
            cboMaDocGia.Text = dgvTheDocGia.Rows[dong].Cells[0].Value.ToString();
            cboMaNV1.Text = dgvTheDocGia.Rows[dong].Cells[1].Value.ToString();
            txtMaThe.Text = dgvTheDocGia.Rows[dong].Cells[2].Value.ToString();
            dtmNgayLap.Text = dgvTheDocGia.Rows[dong].Cells[3].Value.ToString();
            dtmNgayHetHan.Text = dgvTheDocGia.Rows[dong].Cells[4].Value.ToString();
        }
        //Tìm kiếm phần tử trong bảng DataGridView theo Mã Độc Giả, Mã Nhân Viên, Mã Thẻ
        private void txtTimKiemTheDocGia_TextChanged(object sender, EventArgs e)
        {
            if (cboTimKiem1.Text == "Mã Độc Giả")//Tìm kiếm theo mã độc giả
            {
               
                THEDOCGIA tdg = new THEDOCGIA();
                var search = from tbtdg in db.THEDOCGIAs
                             join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                             join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                             where tbtdg.MADOCGIA.Contains(txtTimKiemTheDocGia.Text)
                             select new
                             {
                                 tbdg.MADOCGIA,
                                 tbnv.MANV,
                                 tbtdg.MATHE,
                                 tbtdg.NGAYLAP,
                                 tbtdg.NGAYHETHAN
                             };
                dgvTheDocGia.DataSource = search;//Bắt đầu tìm kiếm
            }
            if (cboTimKiem1.Text == "Mã Nhân Viên")//Tìm kiếm theo mã nhân viên
            {
                THEDOCGIA tdg = new THEDOCGIA();
                var search = from tbtdg in db.THEDOCGIAs
                             join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                             join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                             where tbtdg.MANV.Contains(txtTimKiemTheDocGia.Text)
                             select new
                             {
                                 tbdg.MADOCGIA,
                                 tbnv.MANV,
                                 tbtdg.MATHE,
                                 tbtdg.NGAYLAP,
                                 tbtdg.NGAYHETHAN
                             };
                dgvTheDocGia.DataSource = search;
            }
            if (cboTimKiem1.Text == "Mã Thẻ")//Tìm kiếm theo mã thẻ
            {
                THEDOCGIA tdg = new THEDOCGIA();
                var search = from tbtdg in db.THEDOCGIAs
                             join tbdg in db.DOCGIAs on tbtdg.MADOCGIA equals tbdg.MADOCGIA
                             join tbnv in db.NHANVIENs on tbtdg.MANV equals tbnv.MANV
                             where tbtdg.MATHE.Contains(txtTimKiemTheDocGia.Text)
                             select new
                             {
                                 tbdg.MADOCGIA,
                                 tbnv.MANV,
                                 tbtdg.MATHE,
                                 tbtdg.NGAYLAP,
                                 tbtdg.NGAYHETHAN
                             };
                dgvTheDocGia.DataSource = search;
            }
        }
        //Click chuột vào từng dòng DataGridView
        private void dgvTheDocGia_MouseClick(object sender, MouseEventArgs e)
        {
            Loadsuathedocgia();
        }
    }
}