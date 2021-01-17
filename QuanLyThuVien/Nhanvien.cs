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
    public partial class frmNhanvien : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        public frmNhanvien()
        {
            InitializeComponent();
        }
        void DataGridView()
        {
            dgvNhanvien.DataSource = db.NHANVIENs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = mskMa_nhanvien.Text.Trim();
            nv.HOTENNV = txtTen_nhanvien.Text.Trim();
            nv.DIACHINV = txtDiachi_nhanvien.Text.Trim();
            nv.NGAYSINHNV = Convert.ToDateTime(dtmNgaysinh_nhanvien.Value);
            nv.GIOITINHNV = cboGioitinh_nhanvien.Text.Trim();
            nv.DIENTHOAINV = txtSdt_nhanvien.Text.Trim();
            nv.EMAILNV = txtEmail_nhanvien.Text.Trim();
            try
            {
                var test = db.NHANVIENs.FirstOrDefault(p => p.MANV == nv.MANV);
                if (test == null)
                {
                    db.NHANVIENs.InsertOnSubmit(nv);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    mskMa_nhanvien.Clear();
                    txtTen_nhanvien.Clear();
                    txtDiachi_nhanvien.Clear();
                    txtSdt_nhanvien.Clear();
                    txtEmail_nhanvien.Clear();

                }
                else
                {
                    test.HOTENNV = nv.HOTENNV;
                    test.DIACHINV = nv.DIACHINV;
                    test.NGAYSINHNV = nv.NGAYSINHNV;
                    test.GIOITINHNV = nv.GIOITINHNV;
                    test.DIENTHOAINV = nv.DIENTHOAINV;
                    test.EMAILNV = nv.EMAILNV;
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    mskMa_nhanvien.Clear();
                    txtTen_nhanvien.Clear();
                    txtDiachi_nhanvien.Clear();
                    txtSdt_nhanvien.Clear();
                    txtEmail_nhanvien.Clear();
                }
                db.SubmitChanges();
                DataGridView();
            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            cbotimnv.SelectedIndex = 0;
            cboGioitinh_nhanvien.SelectedIndex = 0;
            dgvNhanvien.DataSource = db.NHANVIENs.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var delete = db.NHANVIENs.FirstOrDefault(p => p.MANV == mskMa_nhanvien.Text);
                if( delete != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xóa Thành Công !!!");
                    mskMa_nhanvien.Clear();
                    txtTen_nhanvien.Clear();
                    txtDiachi_nhanvien.Clear();
                    txtSdt_nhanvien.Clear();
                    txtEmail_nhanvien.Clear();

                }
                else
                {
                    MessageBox.Show("lỗi rồi!!!");
                }
                }
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            mskMa_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[0].Value.ToString();
            txtTen_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[1].Value.ToString();
            cboGioitinh_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[2].Value.ToString();
            dtmNgaysinh_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[3].Value.ToString();
            txtDiachi_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[4].Value.ToString();
            txtSdt_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[5].Value.ToString();
            txtEmail_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[6].Value.ToString();


        }

        private void txtTimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbotimnv.Text == "Mã")
            {
                var findmanv = (from s in db.NHANVIENs
                                where s.MANV.Contains(txtTimkiem.Text)
                                select s).ToList();
                dgvNhanvien.DataSource = findmanv;


            }
            else
            {
                var findtennv = (from s in db.NHANVIENs
                                 where s.HOTENNV.Contains(txtTimkiem.Text)
                                 select s).ToList();
                dgvNhanvien.DataSource = findtennv;
            }
        }
    }
}