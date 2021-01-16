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
    public partial class frmTrangchu : DevExpress.XtraEditors.XtraForm
    {
        public frmTrangchu()
        {
            InitializeComponent();
            this.labelControl2.Parent = this.pictureBox1;
            this.labelControl1.Parent = this.pictureBox1;
        }
    }
}