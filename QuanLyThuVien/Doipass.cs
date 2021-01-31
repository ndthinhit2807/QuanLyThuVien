
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
    public partial class frmDoipass : DevExpress.XtraEditors.XtraForm
    {

        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        public frmDoipass()
        {
            InitializeComponent();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "") MessageBox.Show("Vui lòng nhập mật khẩu hiện tại");
            else if (txtpassmoi.Text == "") MessageBox.Show("Vui lòng nhập mật khẩu mới");
            else if (txtrepass.Text == "") MessageBox.Show("Vui lòng nhập lại mật khẩu mới");
            else if (txtpassmoi.Text != txtrepass.Text) MessageBox.Show("Mật khẩu nhập lại không đúng");
            else if (label7.Text!= "" || label6.Text != ""||label5.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đúng định dạng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                var dangnhap = db.TAIKHOANs.Where (ip => ip.TENTAIKHOAN == txtid.Text).ToList().Where(ip => ip.MATKHAU == txtpass.Text).FirstOrDefault();                             
               
                    if (dangnhap != null)
                    { dangnhap.MATKHAU = txtpassmoi.Text;
                        db.SubmitChanges();                  
                        MessageBox.Show("Đổi mật khẩu thành công",
                        "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtid.Clear();
                        txtpass.Clear();
                        txtpassmoi.Clear();
                        txtrepass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu !!!",
                        "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtid.Focus();

                    }
            }
        }


        private void frmDoipass_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
                txtpassmoi.UseSystemPasswordChar = false;
                txtrepass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                txtpassmoi.UseSystemPasswordChar = true;
                txtrepass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_KeyUp_1(object sender, KeyEventArgs e)
        {
            Regex rr = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,12}$");
            if (rr.IsMatch(txtpass.Text) == false)
            {
                label7.Text = "Mật khẩu ít nhất 8 chữ cái, bao gồm hoa, số và kí tự đặc biệt ";
            }
            else
            {
                label7.Text = "";
            }
        }

        private void txtpassmoi_KeyUp_1(object sender, KeyEventArgs e)
        {
            Regex rr = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,12}$");
            if (rr.IsMatch(txtpassmoi.Text) == false)
            {
                label6.Text = "Mật khẩu ít nhất 8 chữ cái, bao gồm hoa, số và kí tự đặc biệt ";
            }
            else
            {
                label6.Text = "";
            }
        }

        private void txtrepass_KeyUp_1(object sender, KeyEventArgs e)
        {
            Regex rr = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,12}$");
            if (rr.IsMatch(txtrepass.Text) == false)
            {
                label5.Text = "Mật khẩu ít nhất 8 chữ cái, bao gồm hoa, số và kí tự đặc biệt ";
            }
            else
            {
                label5.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}