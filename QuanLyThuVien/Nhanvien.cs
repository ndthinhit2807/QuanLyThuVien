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
using System.Data.SqlClient;

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
            nv.MANV = txtMa_nhanvien.Text.Trim();
            nv.HOTENNV = txtTen_nhanvien.Text.Trim();
            nv.DIACHINV = txtDiachi_nhanvien.Text.Trim();
            nv.NGAYSINHNV = Convert.ToDateTime(dtmNgaysinh_nhanvien.Value);
            nv.GIOITINHNV = cboGioitinh_nhanvien.Text.Trim();
            nv.DIENTHOAINV = mskSdt_nhanvien.Text.Trim();
            nv.EMAILNV = txtEmail_nhanvien.Text.Trim();
            if (txtTen_nhanvien.Text == "" || txtDiachi_nhanvien.Text == "" || txtEmail_nhanvien.Text == "" ||
                lblEmail_nhanvien.Text != "") 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và đúng định dạng", "Thông báo", MessageBoxButtons.OK);               
            }
            else
            {
                try
                {
                    var test = db.NHANVIENs.FirstOrDefault(p => p.MANV == nv.MANV);
                    if (test == null)
                    {
                        db.NHANVIENs.InsertOnSubmit(nv);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        txtMa_nhanvien.Clear();
                        txtTen_nhanvien.Clear();
                        txtDiachi_nhanvien.Clear();
                        mskSdt_nhanvien.Clear();
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
                        txtMa_nhanvien.Clear();
                        txtTen_nhanvien.Clear();
                        txtDiachi_nhanvien.Clear();
                        mskSdt_nhanvien.Clear();
                        txtEmail_nhanvien.Clear();
                    }
                    db.SubmitChanges();
                    DataGridView();
                    autotang();
                }
                catch
                {
                    MessageBox.Show("Lỗi", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            cbotimnv.SelectedIndex = 0;
            cboGioitinh_nhanvien.SelectedIndex = 0;
            dgvNhanvien.DataSource = db.NHANVIENs.ToList();
            autotang();
            lblEmail_nhanvien.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var delete = db.NHANVIENs.FirstOrDefault(p => p.MANV == txtMa_nhanvien.Text);
                if( delete != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xóa Thành Công !!!");
                    txtMa_nhanvien.Clear();
                    txtTen_nhanvien.Clear();
                    txtDiachi_nhanvien.Clear();
                    mskSdt_nhanvien.Clear();
                    txtEmail_nhanvien.Clear();
                    autotang();

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
            txtMa_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[0].Value.ToString();
            txtTen_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[1].Value.ToString();
            cboGioitinh_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[2].Value.ToString();
            dtmNgaysinh_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[3].Value.ToString();
            txtDiachi_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[4].Value.ToString();
            mskSdt_nhanvien.Text = dgvNhanvien.Rows[numrow].Cells[5].Value.ToString();
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
        
       
    private void txtEmail_nhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            string match = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex reg = new Regex(match);
            if (!reg.IsMatch(this.txtEmail_nhanvien.Text))
            {
                this.lblEmail_nhanvien.Text = "Email không hợp lệ";
            }
            else
            {
                this.lblEmail_nhanvien.Text = "";
            }          
        }

        public void autotang()
        {
            string mamax = (from s in db.NHANVIENs
                         orderby s.MANV descending
                         select s.MANV).FirstOrDefault();
            if(mamax == null)
            {
                txtMa_nhanvien.Text = "NV001".ToString();
            }
            else
            {
            int stt = int.Parse(mamax.Substring(2));
                stt += 1;
                if(stt < 10)
                {
                    txtMa_nhanvien.Text = "NV00" + stt.ToString();
                }else if(stt < 100)
                {
                    txtMa_nhanvien.Text = "NV0" + stt.ToString();
                }
                else
                {
                    txtMa_nhanvien.Text = "NV" + stt.ToString();
                }
            }
        }

        private void btnLammoi_nhanvien_Click(object sender, EventArgs e)
        {
            DataGridView();
            autotang();
            txtTen_nhanvien.Clear();
            txtDiachi_nhanvien.Clear();
            txtMa_nhanvien.Clear();
            txtEmail_nhanvien.Clear();
        }
    }
}