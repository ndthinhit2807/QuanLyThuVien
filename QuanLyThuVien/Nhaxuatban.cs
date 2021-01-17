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
            nxb.MANXB = mskMa_nxb.Text.Trim();
            nxb.TENNXB = txtTen_nxb.Text.Trim();
            nxb.DIACHINXB = txtDiachi_nxb.Text.Trim();
            nxb.DIENTHOAIXB = txtSdt_nxb.Text.Trim();
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
                    txtSdt_nxb.Clear();
                }
                else
                {
                    testNXb.TENNXB = txtTen_nxb.Text.Trim();
                    testNXb.DIACHINXB = txtDiachi_nxb.Text.Trim();
                    testNXb.DIENTHOAIXB = txtSdt_nxb.Text.Trim();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    mskMa_nxb.Clear();
                    txtTen_nxb.Clear();
                    txtDiachi_nxb.Clear();
                    txtSdt_nxb.Clear();
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
            cboTim_nxb.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

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
                        txtSdt_nxb.Clear();
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
            mskMa_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[0].Value.ToString();
            txtTen_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[1].Value.ToString();
            txtDiachi_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[2].Value.ToString();
            txtSdt_nxb.Text = dgvnhaxuatban.Rows[numrow].Cells[3].Value.ToString();

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
    }
}