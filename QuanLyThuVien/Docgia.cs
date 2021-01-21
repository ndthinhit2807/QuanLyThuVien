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
using System.Text.RegularExpressions;

namespace QuanLyThuVien
{
    public partial class frmDocgia : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();       
        public frmDocgia()
        {
            InitializeComponent();
        }

        void DataGridView()
        {
            dgvdg.DataSource = db.DOCGIAs.ToList();
            cboTim_docgia.SelectedIndex = 0;
            cboGioitinh_docgia.SelectedIndex = 0;
            autotang();
            lblEmail_docgia.Text = "";
            lbltestns.Text = "Ngày sinh nhỏ hơn: " + DateTime.Now.ToString("dd/MM/yyyy");
            lbltestsdt.Text = "";

           
        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {
            DataGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void btnthemsuadg_Click(object sender, EventArgs e)
        {
            if (txtTen_docgia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên độc giả", "Thông báo", MessageBoxButtons.OK);
            }
            else if (lbltestns.Text != "")
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "Thông báo", MessageBoxButtons.OK);
            }else if (txtDiachi_docgia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (mskSdt_docgia.Text == "" || lbltestsdt.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK);
            }else if (txtEmail_docgia.Text == "" || lblEmail_docgia.Text != "")
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK);
            }else
            {
                try
                {
                    DOCGIA dg = new DOCGIA();
                    dg.MADOCGIA = mskMa_docgia.Text.Trim();
                    dg.TENDOCGIA = txtTen_docgia.Text.Trim();
                    dg.DIACHI = txtDiachi_docgia.Text.Trim();
                    dg.SDTDOCGIA = mskSdt_docgia.Text.Trim();
                    dg.EMAIL = txtEmail_docgia.Text.Trim();
                    dg.NGAYSINH = Convert.ToDateTime(dtmNgaysinh_docgia.Value.ToString("dd - MMM - yyyy"));
                    dg.GIOITINH = cboGioitinh_docgia.Text;
                    var testdg = db.DOCGIAs.FirstOrDefault(p => p.MADOCGIA == dg.MADOCGIA);
                    if (testdg == null)
                    {
                        db.DOCGIAs.InsertOnSubmit(dg);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        DataGridView();
                        mskMa_docgia.Clear();
                        txtTen_docgia.Clear();
                        txtDiachi_docgia.Clear();
                        mskSdt_docgia.Clear();
                        txtEmail_docgia.Clear();
                    }
                    else
                    {
                        testdg.TENDOCGIA = dg.TENDOCGIA;
                        testdg.DIACHI = dg.DIACHI;
                        testdg.SDTDOCGIA = dg.SDTDOCGIA;
                        testdg.EMAIL = dg.EMAIL;
                        testdg.NGAYSINH = dg.NGAYSINH;
                        testdg.GIOITINH = dg.GIOITINH;
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        db.SubmitChanges();
                        DataGridView();                       
                        txtTen_docgia.Clear();
                        txtDiachi_docgia.Clear();
                        mskSdt_docgia.Clear();
                        txtEmail_docgia.Clear();
                    }
                    autotang();
                }
                catch
                {
                    MessageBox.Show("Có Lỗi", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoadg_Click(object sender, EventArgs e)
        {
            DOCGIA dg = new DOCGIA();
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (DataGridViewRow row in dgvdg.SelectedRows)
                {
                    var numrow = row.Cells[0].Value;
                    dg = db.DOCGIAs.FirstOrDefault(s => s.MADOCGIA == numrow.ToString());
                    if (dg != null)
                    {
                        db.DOCGIAs.DeleteOnSubmit(dg);
                    }
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    mskMa_docgia.Clear();
                    txtTen_docgia.Clear();
                    txtDiachi_docgia.Clear();
                    mskSdt_docgia.Clear();
                    autotang();
                }
        }

        private void txttimdg_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTim_docgia.Text == "Tên")
            {
            var findtendg = (from s in db.DOCGIAs
                              where s.TENDOCGIA.Contains(txtTim_docgia.Text)
                              select s).ToList();
            dgvdg.DataSource = findtendg;

            }
            else
            {
                var findmadg = (from s in db.DOCGIAs
                                 where s.MADOCGIA.Contains(txtTim_docgia.Text)
                                 select s).ToList();
                dgvdg.DataSource = findmadg;
            }
        }

        private void dgvdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            mskMa_docgia.Text = dgvdg.Rows[numrow].Cells[0].Value.ToString();
            txtTen_docgia.Text = dgvdg.Rows[numrow].Cells[1].Value.ToString();
            cboGioitinh_docgia.Text = dgvdg.Rows[numrow].Cells[6].Value.ToString();
            dtmNgaysinh_docgia.Text = dgvdg.Rows[numrow].Cells[5].Value.ToString();
            txtDiachi_docgia.Text = dgvdg.Rows[numrow].Cells[2].Value.ToString();
            mskSdt_docgia.Text = dgvdg.Rows[numrow].Cells[3].Value.ToString();
            txtEmail_docgia.Text = dgvdg.Rows[numrow].Cells[4].Value.ToString();
        }

        public void autotang()
        {
            string mamax = (from s in db.DOCGIAs
                            orderby s.MADOCGIA descending
                            select s.MADOCGIA).FirstOrDefault();


            if (mamax == null)
            {
                mskMa_docgia.Text = "DG001".ToString();
            }
            else
            {
                int stt = int.Parse(mamax.Substring(2));
                stt += 1;
                if (stt < 10)
                {
                    mskMa_docgia.Text = "DG00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    mskMa_docgia.Text = "DG0" + stt.ToString();
                }
                else
                {
                    mskMa_docgia.Text = "DG" + stt.ToString();
                }
            }
        }

        private void btnLammoi_nhanvien_Click(object sender, EventArgs e)
        {
            DataGridView();
            autotang();
            txtTen_docgia.Clear();
            txtDiachi_docgia.Clear();
            mskSdt_docgia.Clear();
            txtEmail_docgia.Clear();
        }

        private void txtEmail_docgia_KeyUp(object sender, KeyEventArgs e)
        {
            string match = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex reg = new Regex(match);
            if (!reg.IsMatch(this.txtEmail_docgia.Text))
            {
                this.lblEmail_docgia.Text = "Email không hợp lệ";
            }
            else
            {
                this.lblEmail_docgia.Text = "";
            }
        }

        private void dtmNgaysinh_docgia_ValueChanged(object sender, EventArgs e)
        {
            if (dtmNgaysinh_docgia.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") || dtmNgaysinh_docgia.Value > DateTime.Now)
            {
                lbltestns.Text = "Ngày sinh nhỏ hơn: " + DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                lbltestns.Text = "";
            }
        }

        private void mskSdt_docgia_Click(object sender, EventArgs e)
        {
            mskSdt_docgia.Select(0, 0);
        }

        private void btnLammoi_docgia_Click(object sender, EventArgs e)
        {
            DataGridView();
            txtTen_docgia.Clear();
            txtDiachi_docgia.Clear();
            mskSdt_docgia.Clear();
            txtEmail_docgia.Clear();
        }

        private void mskSdt_docgia_KeyUp(object sender, KeyEventArgs e)
        {
            string dauso = "0";
            if (mskSdt_docgia.Text.Length != 10 || mskSdt_docgia.Text.IndexOf(dauso) != 0)
            {
                lbltestsdt.Text = "Nhập đúng định dạng";
            }
            else
            {
                lbltestsdt.Text = "";
            }
        }
    }
}