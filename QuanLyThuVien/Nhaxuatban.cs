using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmNxb : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        public frmNxb()
        {
            InitializeComponent();
        }
        void DataGridView()
        {
            autotang();
            dgvnhaxuatban.DataSource = db.NHAXUATBANs.ToList();
            txtTen_nxb.Clear();
            txtDiachi_nxb.Clear();
            mskSdt_nxb.Clear();
            
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHAXUATBAN nxb = new NHAXUATBAN();
            nxb.MANXB = mskMa_nxb.Text.Trim();
            nxb.TENNXB = txtTen_nxb.Text.Trim();
            nxb.DIACHINXB = txtDiachi_nxb.Text.Trim();
            nxb.DIENTHOAIXB = mskSdt_nxb.Text.Trim();
         
            if (txtTen_nxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtDiachi_nxb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà xuất bản", "Thông báo", MessageBoxButtons.OK);
            }
            else if (lbltestsdt_nxb.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhà xuất bản", "Thông báo", MessageBoxButtons.OK);
            }
            else 
            {
                try
                {
                    var testNXb = db.NHAXUATBANs.FirstOrDefault(p => p.MANXB == nxb.MANXB);
                    if (testNXb == null)
                    {
                        db.NHAXUATBANs.InsertOnSubmit(nxb);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        mskMa_nxb.Clear();
                        txtTen_nxb.Clear();
                        txtDiachi_nxb.Clear();
                        mskSdt_nxb.Clear();
                    }
                    else
                    {
                        testNXb.TENNXB = txtTen_nxb.Text.Trim();
                        testNXb.DIACHINXB = txtDiachi_nxb.Text.Trim();
                        testNXb.DIENTHOAIXB = mskSdt_nxb.Text.Trim();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        mskMa_nxb.Clear();
                        txtTen_nxb.Clear();
                        txtDiachi_nxb.Clear();
                        mskSdt_nxb.Clear();
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
        private void Nhaxuatban_Load(object sender, EventArgs e)
        {
            var show = db.NHAXUATBANs.ToList();
            dgvnhaxuatban.DataSource = show;
            cboTim_nxb.SelectedIndex = 0;
            autotang();
            lbltestsdt_nxb.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var nhaxuatban = db.NHAXUATBANs.FirstOrDefault(p => p.MANXB == mskMa_nxb.Text);
                if (nhaxuatban != null)
                {
                    db.NHAXUATBANs.DeleteOnSubmit(nhaxuatban);
                    MessageBox.Show("Bạn đã xóa thành công!!!");
                    db.SubmitChanges();
                    DataGridView();
                    mskMa_nxb.Clear();
                    txtTen_nxb.Clear();
                    txtDiachi_nxb.Clear();
                    mskSdt_nxb.Clear();
                    autotang();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!!!");
                }
            }
        }

        private void dgvnhaxuatban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            mskMa_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[0].Value.ToString();
            txtTen_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[1].Value.ToString();
            txtDiachi_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[2].Value.ToString();
            mskSdt_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[3].Value.ToString();

        }

        private void cbotimds_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTim_nxb.Text == "Tên")
            {
                var findtennxb = (from s in db.NHAXUATBANs
                                where s.TENNXB.Contains(txtTim_nxb.Text)
                                select s).ToList();
                dgvnhaxuatban.DataSource = findtennxb;
            }
            else
            {
                var findmanxb = (from s in db.NHAXUATBANs
                                  where s.MANXB.Contains(txtTim_nxb.Text)
                                  select s).ToList();
                dgvnhaxuatban.DataSource = findmanxb;
            }
        }

        public void autotang()
        {
            string mamax = (from s in db.NHAXUATBANs
                            orderby s.MANXB descending
                            select s.MANXB).FirstOrDefault();
            if (mamax == null)
            {
                mskMa_nxb.Text = "NXB001".ToString();
            }
            else
            {
                int stt = int.Parse(mamax.Substring(3));
                stt += 1;
                if (stt < 10)
                {
                    mskMa_nxb.Text = "NXB00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    mskMa_nxb.Text = "NXB0" + stt.ToString();
                }
                else
                {
                    mskMa_nxb.Text = "NXB" + stt.ToString();
                }
            }
        }

        private void btnLammoi_nhanvien_Click(object sender, EventArgs e)
        {
            DataGridView();
        }

        private void mskSdt_nxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string dauso = "0";
            if(mskSdt_nxb.Text.Length != 10 || mskSdt_nxb.Text.IndexOf(dauso) != 0)
            {
                lbltestsdt_nxb.Text = "Nhập đúng định dạng";
            }
            else
            {
                lbltestsdt_nxb.Text = "";
            }
        }

        private void mskSdt_nxb_Click(object sender, EventArgs e)
        {
            mskSdt_nxb.Select(0, 0);
        }

        private void btnLammoi_nxb_Click(object sender, EventArgs e)
        {
            DataGridView();
        }
    }
}