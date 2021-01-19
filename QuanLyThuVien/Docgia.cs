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
        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {
           
            dgvdg.DataSource = db.DOCGIAs;
            cboTim_docgia.SelectedIndex = 0;
            cboGioitinh_docgia.SelectedIndex = 0;
            autotang();
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
            if(mskMa_docgia.Text == "DG")
            {
                MessageBox.Show("Nhap du");
            }
            else
            {

                try
                {
                    DOCGIA dg = new DOCGIA();
                    dg.MADOCGIA = mskMa_docgia.Text.Trim();
                    dg.TENDOCGIA = txtTen_docgia.Text.Trim();
                    dg.DIACHI = txtDiachi_docgia.Text.Trim();
                    dg.SDTDOCGIA = txtSdt_docgia.Text.Trim();
                    dg.EMAIL = txtEmail_docgia.Text.Trim();
                    dg.NGAYSINH = Convert.ToDateTime(dtmNgaysinh_docgia.Value);
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
                        txtSdt_docgia.Clear();
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
                        mskMa_docgia.Clear();
                        txtTen_docgia.Clear();
                        txtDiachi_docgia.Clear();
                        txtSdt_docgia.Clear();
                        txtEmail_docgia.Clear();
                    }
                    autotang();
                }
                catch
                {
                    MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
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
                    txtSdt_docgia.Clear();
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
            txtSdt_docgia.Text = dgvdg.Rows[numrow].Cells[3].Value.ToString();
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
    }
}