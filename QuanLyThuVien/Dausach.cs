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
    public partial class frmDausach : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        public frmDausach()
        {
            InitializeComponent();
        }

        private void frmDausach_Load(object sender, EventArgs e)
        {
            loaddausach();
        }

         void loaddausach()
        {
                var loadds = from s in db.DAUSACHes
                                 join d in db.TACGIAs
                                 on s.MATACGIA equals d.MATACGIA
                                 join t in db.THELOAIs
                                 on s.MATHELOAI equals t.MATHELOAI
                                 join v in db.NHAXUATBANs
                                 on s.MANXB equals v.MANXB
                                 select new
                                 {
                                     s.MASACH,
                                     s.TENSACH,
                                     s.NAMXUATBAN,
                                     t.TENTHELOAI,
                                     d.TENTACGIA,
                                     v.TENNXB
                                 };
                dgvds.DataSource = loadds;

                cboTim_dausach.SelectedIndex = 0;

                cboNxb_dausach.DataSource = db.NHAXUATBANs;
                cboNxb_dausach.ValueMember = "MANXB";
                cboNxb_dausach.DisplayMember = "TENNXB";

                cboTacgia_dausach.DataSource = db.TACGIAs;
                cboTacgia_dausach.ValueMember = "MATACGIA";
                cboTacgia_dausach.DisplayMember = "TENTACGIA";

                cboTheloai_dausach.DataSource = db.THELOAIs;
                cboTheloai_dausach.ValueMember = "MATHELOAI";
                cboTheloai_dausach.DisplayMember = "TENTHELOAI";
            
        }

        private void btnthemsuads_Click(object sender, EventArgs e)
        {
            try
            {
                DAUSACH ds = new DAUSACH();
                ds.MASACH = mskMa_dausach.Text.Trim();
                ds.MANXB = cboNxb_dausach.SelectedValue.ToString();
                ds.TENSACH = txtTen_dausach.Text.Trim();
                ds.MATHELOAI = cboTheloai_dausach.SelectedValue.ToString();
                ds.NAMXUATBAN = txtNamxb_dausach.Text.Trim();
                ds.MATACGIA = cboTacgia_dausach.SelectedValue.ToString();
                var test_ds = db.DAUSACHes.FirstOrDefault(p => p.MASACH == ds.MASACH);
                if (test_ds == null)
                {
                    db.DAUSACHes.InsertOnSubmit(ds);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    mskMa_dausach.Clear();
                    txtNamxb_dausach.Clear();
                    txtTen_dausach.Clear();
                }
                else
                {
                    ds = db.DAUSACHes.Where(p => p.MASACH == mskMa_dausach.Text).Single();
                    test_ds.MANXB = cboNxb_dausach.SelectedValue.ToString();
                    test_ds.TENSACH = txtTen_dausach.Text.Trim();
                    test_ds.MATHELOAI = cboTheloai_dausach.SelectedValue.ToString();
                    test_ds.NAMXUATBAN = txtNamxb_dausach.Text.Trim();
                    test_ds.MATACGIA = cboTacgia_dausach.SelectedValue.ToString();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    mskMa_dausach.Clear();
                    txtNamxb_dausach.Clear();
                    txtTen_dausach.Clear();
                }
                db.SubmitChanges();
                loaddausach();
            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnxoads_Click(object sender, EventArgs e)
        {
            DAUSACH ds = new DAUSACH();
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (DataGridViewRow row in dgvds.SelectedRows)
                {
                    var numrow = row.Cells[0].Value;
                    ds = db.DAUSACHes.FirstOrDefault(s => s.MASACH == numrow.ToString());
                    if (ds != null)
                    {
                        db.DAUSACHes.DeleteOnSubmit(ds);
                    }
                    db.SubmitChanges();
                    loaddausach();
                    MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    mskMa_dausach.Clear();
                    txtNamxb_dausach.Clear();
                    txtTen_dausach.Clear();
                }
        }

        private void txttimds_KeyUp(object sender, KeyEventArgs e)
        {
            if (cboTim_dausach.Text == "Tên")
            {
                var findtensach = from s in db.DAUSACHes
                                  join d in db.TACGIAs
                                  on s.MATACGIA equals d.MATACGIA
                                  join t in db.THELOAIs
                                  on s.MATHELOAI equals t.MATHELOAI
                                  join v in db.NHAXUATBANs
                                  on s.MANXB equals v.MANXB
                                  where s.TENSACH.Contains(txtTim_dausach.Text)
                                  select new
                                  {
                                      s.MASACH,
                                      s.TENSACH,
                                      s.NAMXUATBAN,
                                      t.TENTHELOAI,
                                      d.TENTACGIA,
                                      v.TENNXB
                                  };
                dgvds.DataSource = findtensach;
            }
            
            else
            {
                var findmads = from s in db.DAUSACHes
                              join d in db.TACGIAs
                              on s.MATACGIA equals d.MATACGIA
                              join t in db.THELOAIs
                              on s.MATHELOAI equals t.MATHELOAI
                              join v in db.NHAXUATBANs
                              on s.MANXB equals v.MANXB
                              where s.MASACH.Contains(txtTim_dausach.Text)
                              select new
                              {
                                  s.MASACH,
                                  s.TENSACH,
                                  s.NAMXUATBAN,
                                  t.TENTHELOAI,
                                  d.TENTACGIA,
                                  v.TENNXB
                              };
                dgvds.DataSource = findmads;
            }
        }

        private void dgvds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskMa_dausach.Text = dgvds.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen_dausach.Text = dgvds.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNamxb_dausach.Text = dgvds.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboTheloai_dausach.Text = dgvds.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboTacgia_dausach.Text = dgvds.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboNxb_dausach.Text = dgvds.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}