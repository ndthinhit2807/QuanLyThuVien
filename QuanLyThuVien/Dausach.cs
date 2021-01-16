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

                cbotimds.SelectedIndex = 0;

                cbonxb.DataSource = db.NHAXUATBANs;
                cbonxb.ValueMember = "MANXB";
                cbonxb.DisplayMember = "TENNXB";

                cbotg.DataSource = db.TACGIAs;
                cbotg.ValueMember = "MATACGIA";
                cbotg.DisplayMember = "TENTACGIA";

                cbotl.DataSource = db.THELOAIs;
                cbotl.ValueMember = "MATHELOAI";
                cbotl.DisplayMember = "TENTHELOAI";
            
        }

        private void btnthemsuads_Click(object sender, EventArgs e)
        {
            try
            {
                DAUSACH ds = new DAUSACH();
                ds.MASACH = maskds.Text.Trim();
                ds.MANXB = cbonxb.SelectedValue.ToString();
                ds.TENSACH = txttends.Text.Trim();
                ds.MATHELOAI = cbotl.SelectedValue.ToString();
                ds.NAMXUATBAN = txtnamxb.Text.Trim();
                ds.MATACGIA = cbotg.SelectedValue.ToString();
                var testds = db.DAUSACHes.FirstOrDefault(p => p.MASACH == ds.MASACH);
                if (testds == null)
                {
                    db.DAUSACHes.InsertOnSubmit(ds);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    maskds.Clear();
                    txtnamxb.Clear();
                    txttends.Clear();
                }
                else
                {
                    ds = db.DAUSACHes.Where(p => p.MASACH == maskds.Text).Single();
                    ds.MANXB = cbonxb.SelectedValue.ToString();
                    ds.TENSACH = txttends.Text.Trim();
                    ds.MATHELOAI = cbotl.SelectedValue.ToString();
                    ds.NAMXUATBAN = txtnamxb.Text.Trim();
                    ds.MATACGIA = cbotg.SelectedValue.ToString();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    maskds.Clear();
                    txtnamxb.Clear();
                    txttends.Clear();
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
                    maskds.Clear();
                    txtnamxb.Clear();
                    txttends.Clear();
                }
        }

        private void txttimds_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbotimds.Text == "Tên")
            {
                var findtensach = from s in db.DAUSACHes
                                  join d in db.TACGIAs
                                  on s.MATACGIA equals d.MATACGIA
                                  join t in db.THELOAIs
                                  on s.MATHELOAI equals t.MATHELOAI
                                  join v in db.NHAXUATBANs
                                  on s.MANXB equals v.MANXB
                                  where s.TENSACH.Contains(txttimds.Text)
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
            else if (cbotimds.Text == "Thể Loại")
            {
                var findtheloai = from s in db.DAUSACHes
                                  join d in db.TACGIAs
                                  on s.MATACGIA equals d.MATACGIA
                                  join t in db.THELOAIs
                                  on s.MATHELOAI equals t.MATHELOAI
                                  join v in db.NHAXUATBANs
                                  on s.MANXB equals v.MANXB
                                  where t.TENTHELOAI.Contains(txttimds.Text)
                                  select new
                                  {
                                      s.MASACH,
                                      s.TENSACH,
                                      s.NAMXUATBAN,
                                      t.TENTHELOAI,
                                      d.TENTACGIA,
                                      v.TENNXB
                                  };
                dgvds.DataSource = findtheloai;

            }
            else if (cbotimds.Text == "Tác Giả")
            {
                var findtacgia = from s in db.DAUSACHes
                                 join d in db.TACGIAs
                                 on s.MATACGIA equals d.MATACGIA
                                 join t in db.THELOAIs
                                 on s.MATHELOAI equals t.MATHELOAI
                                 join v in db.NHAXUATBANs
                                 on s.MANXB equals v.MANXB
                                 where d.TENTACGIA.Contains(txttimds.Text)
                                 select new
                                 {
                                     s.MASACH,
                                     s.TENSACH,
                                     s.NAMXUATBAN,
                                     t.TENTHELOAI,
                                     d.TENTACGIA,
                                     v.TENNXB
                                 };
                dgvds.DataSource = findtacgia;
            }
            else if(cbotimds.Text == "Thể Loại")
            {
                var findnxb = from s in db.DAUSACHes
                              join d in db.TACGIAs
                              on s.MATACGIA equals d.MATACGIA
                              join t in db.THELOAIs
                              on s.MATHELOAI equals t.MATHELOAI
                              join v in db.NHAXUATBANs
                              on s.MANXB equals v.MANXB
                              where v.TENNXB.Contains(txttimds.Text)
                              select new
                              {
                                  s.MASACH,
                                  s.TENSACH,
                                  s.NAMXUATBAN,
                                  t.TENTHELOAI,
                                  d.TENTACGIA,
                                  v.TENNXB
                              };
                dgvds.DataSource = findnxb;
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
                              where s.MASACH.Contains(txttimds.Text)
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
            maskds.Text = dgvds.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttends.Text = dgvds.Rows[e.RowIndex].Cells[1].Value.ToString();
          txtnamxb.Text = dgvds.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbotl.Text = dgvds.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbotg.Text = dgvds.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbonxb.Text = dgvds.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}