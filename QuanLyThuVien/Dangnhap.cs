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
            var dangnhap = db.TAIKHOANs.Where(x => x.TENTAIKHOAN == txtId_dangnhap.Text).ToList().Where(x=> x.MATKHAU == txtPass_dangnhap.Text).FirstOrDefault();
            if (txtId_dangnhap.Text.Trim() == "" || txtPass_dangnhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật khẩu và tài khoản");
            }

            else
            {
                if (dangnhap != null)
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
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Summer 2008";
        }
    }
}