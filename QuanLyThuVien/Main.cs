using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraEditors ;
using DevExpress.XtraBars.Helpers;


namespace QuanLyThuVien

{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

        }



        public void TabCreating(XtraTabControl TabControl, string Text, Form Form)
        {
            int Index = KiemTraTonTai(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTabPage = TabControl.TabPages[Index];
                TabControl.SelectedTabPage.Text = Text;

            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = Text };
                TabControl.TabPages.Add(TabPage);
                TabControl.SelectedTabPage = TabPage;

                Form.TopLevel = false;
                Form.Parent = TabPage;
                //  Form.MdiParent = this;
                Form.Show();
                Form.Dock = DockStyle.Fill;
            }
        }

        static int KiemTraTonTai(XtraTabControl TabControlName, string TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }
        private void tileControl1_Click(object sender, EventArgs e)
        {

        }



        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int a = TabControl.TabPages.Count;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }




        private void btndangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {


            frmDangnhap dangnhap = new frmDangnhap();
            this.Hide();
            dangnhap.ShowDialog();
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Summer 2008";
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(skinlink);
            skin();
            frmTrangchu trangchu = new frmTrangchu();
            TabCreating(this.xtraTabControl1, "Trang Chủ", trangchu);
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btntacgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTacgia tacgia = new frmTacgia();
            TabCreating(this.xtraTabControl1, "Tác Giả", tacgia);

        }

        private void btndocgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDocgia docgia = new frmDocgia();
            TabCreating(this.xtraTabControl1, "Độc Giả", docgia);
        }

        private void btndoipass_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoipass doipass = new frmDoipass();
            TabCreating(this.xtraTabControl1, "Đổi Mật Khẩu", doipass);
        }

        private void btnnxb_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNxb nxb = new frmNxb();
            TabCreating(this.xtraTabControl1, "Nhà Xuất Bản", nxb);
        }

        private void btntheloai_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTheloai theloai = new frmTheloai();
            TabCreating(this.xtraTabControl1, "Thể Loại", theloai);
        }

        private void btndausach_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDausach dausach = new frmDausach();
            TabCreating(this.xtraTabControl1, "Đầu Sách", dausach);
        }

     

        private void btnnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanvien nhanvien = new frmNhanvien();
            TabCreating(this.xtraTabControl1, "Nhân Viên", nhanvien);
        }

        private void btnmuontra_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhieumuontra pmt = new frmPhieumuontra();
            TabCreating(this.xtraTabControl1, "Mượn Trả", pmt);
        }

        private void btnthe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTheDocGia thedg = new frmTheDocGia();
            TabCreating(this.xtraTabControl1, "Thẻ Độc Giả", thedg);
        }

        private void btntrogiup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTrogiup trogiup = new frmTrogiup();
            TabCreating(this.xtraTabControl1, "Trợ Giúp", trogiup);
        }

        private void btnthongke_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thongke xtra = new Thongke();
            TabCreating(this.xtraTabControl1, "Thống kê", xtra);
        }
    }
}