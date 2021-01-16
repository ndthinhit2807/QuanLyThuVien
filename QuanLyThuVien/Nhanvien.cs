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
            nv.MANV = masknv.Text.Trim();
            nv.HOTENNV = txtName.Text.Trim();
            nv.DIACHINV = txtDiachi.Text.Trim();
            nv.NGAYSINHNV = Convert.ToDateTime(dtmNgaysinh.Value);
            nv.GIOITINHNV = cbogioitinh.Text.Trim();
            nv.DIENTHOAINV = txtSDT.Text.Trim();
            nv.EMAILNV = txtEmail.Text.Trim();
            try
            {
                var test = db.NHANVIENs.FirstOrDefault(p => p.MANV == nv.MANV);
                if (test == null)
                {
                    db.NHANVIENs.InsertOnSubmit(nv);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    masknv.Clear();
                    txtName.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();

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
                    masknv.Clear();
                    txtName.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();
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
            cbogioitinh.SelectedIndex = 0;
            dgvNhanvien.DataSource = db.NHANVIENs.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var delete = db.NHANVIENs.FirstOrDefault(p => p.MANV == masknv.Text);
                if( delete != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xóa Thành Công !!!");
                    masknv.Clear();
                    txtName.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();

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
            masknv.Text = dgvNhanvien.Rows[numrow].Cells[0].Value.ToString();
            txtName.Text = dgvNhanvien.Rows[numrow].Cells[1].Value.ToString();
            cbogioitinh.Text = dgvNhanvien.Rows[numrow].Cells[2].Value.ToString();
            dtmNgaysinh.Text = dgvNhanvien.Rows[numrow].Cells[3].Value.ToString();
            txtDiachi.Text = dgvNhanvien.Rows[numrow].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanvien.Rows[numrow].Cells[5].Value.ToString();
            txtEmail.Text = dgvNhanvien.Rows[numrow].Cells[6].Value.ToString();


        }

        private void txtTimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbotimnv.Text == "Mã")
            {
            var findmanv = (from s in db.NHANVIENs
                              where  s.MANV.Contains(txtTimkiem.Text)
                              select s).ToList();
            dgvNhanvien.DataSource = findmanv;


            }else if (cbotimnv.Text == "Tên")
            {
            var findtennv = (from s in db.NHANVIENs
                                   where s.HOTENNV.Contains(txtTimkiem.Text)
                                   select s).ToList();
            dgvNhanvien.DataSource = findtennv;
            }


            else if (cbotimnv.Text == "Giới Tính")
            {
                var findgioitinhnv = (from s in db.NHANVIENs
                                 where s.GIOITINHNV.Contains(txtTimkiem.Text)
                                 select s).ToList();
                dgvNhanvien.DataSource = findgioitinhnv;
            }


            else if (cbotimnv.Text == "Địa Chỉ")
            {
                var finddiachinv = (from s in db.NHANVIENs
                                 where s.DIACHINV.Contains(txtTimkiem.Text)
                                 select s).ToList();
            dgvNhanvien.DataSource = finddiachinv;


            }
            else if (cbotimnv.Text == "SĐT")
            {
                var findsdtnv = (from s in db.NHANVIENs
                                 where s.DIENTHOAINV.Contains(txtTimkiem.Text)
                                 select s).ToList();
                dgvNhanvien.DataSource = findsdtnv;
            }


            else
            {
                var findemailnv = (from s in db.NHANVIENs
                                 where s.EMAILNV.Contains(txtTimkiem.Text)
                                 select s).ToList();
                dgvNhanvien.DataSource = findemailnv;
            }
        }

        private void masknv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbogioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtmNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}