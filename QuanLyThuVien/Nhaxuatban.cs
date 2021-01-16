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
            dgvnhaxuatban.DataSource = db.NHAXUATBANs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHAXUATBAN nxb = new NHAXUATBAN();
            nxb.MANXB = masknxb.Text.Trim();
            nxb.TENNXB = txtTenNXB.Text.Trim();
            nxb.DIACHINXB = txtDiachi.Text.Trim();
            nxb.DIENTHOAIXB = txtSDT.Text.Trim();
            try
            {
                var testNXb = db.NHAXUATBANs.FirstOrDefault(p => p.MANXB == nxb.MANXB);
                if (testNXb == null)
                {
                    db.NHAXUATBANs.InsertOnSubmit(nxb);
                    MessageBox.Show("Thêm và Lưu thành công!!!");
                    masknxb.Clear();
                    txtTenNXB.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                }
                else
                {
                    testNXb.TENNXB = txtTenNXB.Text.Trim();
                    testNXb.DIACHINXB = txtDiachi.Text.Trim();
                    testNXb.DIENTHOAIXB = txtSDT.Text.Trim();
                    masknxb.Clear();
                    txtTenNXB.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                }
                db.SubmitChanges();
                DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Nhaxuatban_Load(object sender, EventArgs e)
        {
            var show = db.NHAXUATBANs.ToList();
            dgvnhaxuatban.DataSource = show;
            cbotimnxb.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            {
                if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var nhaxuatban = db.NHAXUATBANs.FirstOrDefault(p => p.MANXB == masknxb.Text);
                    if (nhaxuatban != null)
                    {
                        db.NHAXUATBANs.DeleteOnSubmit(nhaxuatban);
                        MessageBox.Show("Bạn đã xóa thành công!!!");
                        db.SubmitChanges();
                        DataGridView();
                        masknxb.Clear();
                        txtTenNXB.Clear();
                        txtDiachi.Clear();
                        txtSDT.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!!!");
                    }
                }
            }
        }

        private void dgvnhaxuatban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            masknxb.Text = dgvnhaxuatban.Rows[numrow].Cells[0].Value.ToString();
            txtTenNXB.Text = dgvnhaxuatban.Rows[numrow].Cells[1].Value.ToString();
            txtDiachi.Text = dgvnhaxuatban.Rows[numrow].Cells[2].Value.ToString();
            txtSDT.Text = dgvnhaxuatban.Rows[numrow].Cells[3].Value.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void txtTimkiemnxb_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cbotimds_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbotimnxb.Text == "Tên")
            {
                var findtennxb = (from s in db.NHAXUATBANs
                                where s.TENNXB.Contains(txtTimkiemnxb.Text)
                                select s).ToList();
                dgvnhaxuatban.DataSource = findtennxb;
            }
            else if (cbotimnxb.Text == "Địa Chỉ")
            {
                var finddiachinxb = (from s in db.NHAXUATBANs
                                    where s.DIACHINXB.Contains(txtTimkiemnxb.Text)
                                 select s).ToList();
                dgvnhaxuatban.DataSource = finddiachinxb;
            }
            else if(cbotimnxb.Text == "SĐT")
            {
                var findsdtnxb = (from s in db.NHAXUATBANs
                                  where s.DIENTHOAIXB.Contains(txtTimkiemnxb.Text)
                                      select s).ToList();
                dgvnhaxuatban.DataSource = findsdtnxb;
            }
            else
            {
                var findmanxb = (from s in db.NHAXUATBANs
                                  where s.MANXB.Contains(txtTimkiemnxb.Text)
                                  select s).ToList();
                dgvnhaxuatban.DataSource = findmanxb;
            }

        }
    }
}