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
            else
            {
                var dangnhap = db.TAIKHOANs.Where (ip => ip.TENTAIKHOAN == txtid.Text).ToList().Where(ip => ip.MATKHAU == txtpass.Text).FirstOrDefault();                             
               
                    if (dangnhap != null)
                    { dangnhap.MATKHAU = txtpassmoi.Text;
                        db.SubmitChanges();                  
                        MessageBox.Show("Đổi mật khẩu thành công",
                        "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        //FrmMain frm = new FrmMain();
                        //frm.ShowDialog();
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
    }
}