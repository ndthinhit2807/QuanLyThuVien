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
using System.Data.Linq ;
using DevExpress.XtraBars.Helpers;
using System.Text.RegularExpressions;

namespace QuanLyThuVien
{
    public partial class frmDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangnhap()
        {
            InitializeComponent();            
        }

        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
       
        private void btnfrmdangnhap_Click(object sender, EventArgs e)
        {
            

            var tk = db.TAIKHOANs.Where(x => x.TENTAIKHOAN == txtId_dangnhap.Text).ToList().Where(x=> x.MATKHAU == txtPass_dangnhap.Text).FirstOrDefault();
            var mk = db.TAIKHOANs.Where(x => x.MATKHAU == txtPass_dangnhap.Text).ToList().Where(x => x.TENTAIKHOAN == txtId_dangnhap.Text).FirstOrDefault();
            if (txtId_dangnhap.Text.Trim() == "" || txtPass_dangnhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu và tài khoản", "Thông báo", MessageBoxButtons.OK);
            }
            else if (label1.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đúng định dạng", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                if (tk != null && mk != null)
                {
                    MessageBox.Show("Đăng nhập thành công",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMain main = new frmMain();
                    main.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !!!",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private void btnthoat_Click (object sender, EventArgs e)
        {
            DialogResult tl =
              MessageBox.Show("Bạn có muốn thoát ?",
              "Thông báo",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            skin();
            label1.Text = "";
            
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Summer 2008";
        }

        private void txtPass_dangnhap_Properties_KeyUp(object sender, KeyEventArgs e)
        {
            Regex rr = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,12}$");
            if (rr.IsMatch(txtPass_dangnhap.Text) == false)
            {
                label1.Text = "Mật khẩu ít nhất 8 chữ cái, bao gồm hoa, số và kí tự đặc biệt ";
            }
            else
            {
                label1.Text = "";
            }
        }
    }
}