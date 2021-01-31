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
    public partial class frmTrogiup : DevExpress.XtraEditors.XtraForm
    {
        public frmTrogiup()
        {
            InitializeComponent();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelGioiThieu.Visible = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            prgKiemTra.Visible = true;
            prgKiemTra.Minimum = 0;
            prgKiemTra.Maximum = 5000;
            for (int i = 0; i < 5000; i++)
            {
                prgKiemTra.Value = i;
            }
            prgKiemTra.Visible = false;

            MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất của Quản Lý Thư Viện vui lòng cập nhật lại sau", "Cập Nhật");
        }
    }
}