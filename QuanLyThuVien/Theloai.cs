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
    public partial class frmTheloai : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        public frmTheloai()
        {
            InitializeComponent();
        }
        void DataGridView()
        {
            dgvTheloai.DataSource = db.THELOAIs.ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            THELOAI theloai = new THELOAI();
            theloai.MATHELOAI = masktl.Text.Trim();
            theloai.TENTHELOAI = txtTentheloai.Text.Trim();
            try
            {
                var testTheloai = db.THELOAIs.FirstOrDefault(p => p.MATHELOAI == theloai.MATHELOAI);
                if(testTheloai == null)
                {
                    db.THELOAIs.InsertOnSubmit(theloai);
                    MessageBox.Show("Thêm và Lưu thành công!!!");
                    masktl.Clear();
                    txtTentheloai.Clear();
                }
                else
                {
                    testTheloai.TENTHELOAI = theloai.TENTHELOAI;
                    MessageBox.Show("Sửa và Lưu thành công!!!");
                    masktl.Clear();
                    txtTentheloai.Clear();
                }
                db.SubmitChanges();
                DataGridView();                       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Theloai_Load(object sender, EventArgs e)
        {
            dgvTheloai.DataSource = db.THELOAIs.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var test1 = db.THELOAIs.FirstOrDefault(p => p.MATHELOAI == masktl.Text);
                if (test1 != null)
                {
                    db.THELOAIs.DeleteOnSubmit(test1);
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xóa thành công!!!");
                masktl.Clear();
                    txtTimtl.Clear();
                }
                else
                {
                    MessageBox.Show(" Xóa thất bại!!!");
                }                      

            }
        }

        private void dgvTheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            masktl.Text = dgvTheloai.Rows[numrow].Cells[0].Value.ToString();
            txtTentheloai.Text = dgvTheloai.Rows[numrow].Cells[1].Value.ToString();
        }

        private void txtTimtl_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbotimds.Text == "Tên")
            {
                var findtentl = (from s in db.THELOAIs
                                  where s.TENTHELOAI.Contains(txtTimtl.Text)
                                  select s).ToList();
                dgvTheloai.DataSource = findtentl;
            }
            else
            {
                var findmatl = (from s in db.THELOAIs
                                 where s.MATHELOAI.Contains(txtTimtl.Text)
                                 select s).ToList();
                dgvTheloai.DataSource = findmatl;
            }
        }
    }

       
    
}