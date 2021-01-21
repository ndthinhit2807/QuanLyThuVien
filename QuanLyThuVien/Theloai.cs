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
            autotang();
            cbotimds.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen_theloai.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập tên thể loại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                THELOAI theloai = new THELOAI();
                theloai.MATHELOAI = mskMa_theloai.Text.Trim();
                theloai.TENTHELOAI = txtTen_theloai.Text.Trim();
                try
                {
                    var testTheloai = db.THELOAIs.FirstOrDefault(p => p.MATHELOAI == theloai.MATHELOAI);
                    if (testTheloai == null)
                    {
                        db.THELOAIs.InsertOnSubmit(theloai);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        mskMa_theloai.Clear();
                        txtTen_theloai.Clear();
                    }
                    else
                    {
                        testTheloai.TENTHELOAI = theloai.TENTHELOAI;
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        mskMa_theloai.Clear();
                        txtTen_theloai.Clear();
                    }
                    db.SubmitChanges();
                    DataGridView();
                    autotang();
                }
                catch 
                {
                    MessageBox.Show("Có Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Theloai_Load(object sender, EventArgs e)
        {
            DataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var test1 = db.THELOAIs.FirstOrDefault(p => p.MATHELOAI == mskMa_theloai.Text);
                if (test1 != null)
                {
                    db.THELOAIs.DeleteOnSubmit(test1);
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xóa thành công!!!");
                    mskMa_theloai.Clear();
                    txtTimtl.Clear();
                    autotang();
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
            mskMa_theloai.Text = dgvTheloai.Rows[numrow].Cells[0].Value.ToString();
            txtTen_theloai.Text = dgvTheloai.Rows[numrow].Cells[1].Value.ToString();
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

        public void autotang()
        {
            string mamax = (from s in db.THELOAIs
                            orderby s.MATHELOAI descending
                            select s.MATHELOAI).FirstOrDefault();
            if (mamax == null)
            {
                mskMa_theloai.Text = "TL001".ToString();
            }
            else
            {
                int stt = int.Parse(mamax.Substring(2));
                stt += 1;
                if (stt < 10)
                {
                    mskMa_theloai.Text = "TL00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    mskMa_theloai.Text = "TL0" + stt.ToString();
                }
                else
                {
                    mskMa_theloai.Text = "TL" + stt.ToString();
                }
            }
        }

        private void btnLammoi_theloai_Click(object sender, EventArgs e)
        {
            DataGridView();
        }
    }
}