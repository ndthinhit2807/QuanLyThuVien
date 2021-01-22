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
    public partial class frmTacgia : DevExpress.XtraEditors.XtraForm
    {
        public frmTacgia()
        {
            InitializeComponent();
        }
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        TACGIA tg = new TACGIA();


        void loadtacgia()
        {
            dgvtacgia.DataSource = db.TACGIAs.ToList();
            autotang();
            cboTim_tacgia.SelectedIndex = 0;
        }



        private void btnthemsuatg_Click(object sender, EventArgs e)
        {
            if (txtTen_tacgia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                TACGIA tg = new TACGIA();

                tg.MATACGIA = mskMa_tacgia.Text.Trim();
                tg.TENTACGIA = txtTen_tacgia.Text.Trim();
                try
                {
                    var tacgia = db.TACGIAs.FirstOrDefault(p => p.MATACGIA == tg.MATACGIA);
                    if (tacgia == null)
                    {
                        db.TACGIAs.InsertOnSubmit(tg);

                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        mskMa_tacgia.Clear();
                        txtTen_tacgia.Clear();
                    }
                    else
                    {
                        tg = db.TACGIAs.Where(p => p.MATACGIA == mskMa_tacgia.Text).Single();
                        tg.MATACGIA = mskMa_tacgia.Text.Trim();
                        tg.TENTACGIA = txtTen_tacgia.Text.Trim();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        mskMa_tacgia.Clear();
                        txtTen_tacgia.Clear();
                    }
                    db.SubmitChanges();
                    loadtacgia();
                    autotang();
                }
                catch
                {
                    MessageBox.Show("Có Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmTacgia_Load(object sender, EventArgs e)
        {
            loadtacgia();
        }

        private void btnxoatg_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (DataGridViewRow row in dgvtacgia.SelectedRows)
                {
                    var numrow = row.Cells[0].Value;
                    tg = db.TACGIAs.FirstOrDefault(s => s.MATACGIA == numrow.ToString());
                    if (tg != null)
                    {
                        db.TACGIAs.DeleteOnSubmit(tg);
                    }
                    db.SubmitChanges();
                    loadtacgia();
                    autotang();
                    MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    mskMa_tacgia.Clear();
                    txtTen_tacgia.Clear();
                }
        }

        private void dgvtacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskMa_tacgia.Text = dgvtacgia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen_tacgia.Text = dgvtacgia.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

       

        public void autotang()
        {
            string mamax = (from s in db.TACGIAs
                            orderby s.MATACGIA descending
                            select s.MATACGIA).FirstOrDefault();
            if (mamax == null)
            {
                mskMa_tacgia.Text = "TG001".ToString();
            }
            else
            {
                int stt = int.Parse(mamax.Substring(2));
                stt += 1;
                if (stt < 10)
                {
                    mskMa_tacgia.Text = "TG00" + stt.ToString();
                }
                else if (stt < 100)
                {
                    mskMa_tacgia.Text = "TG0" + stt.ToString();
                }
                else
                {
                    mskMa_tacgia.Text = "TG" + stt.ToString();
                }
            }
        }

        private void btnLammoi_tacgia_Click(object sender, EventArgs e)
        {
            loadtacgia();
        }
        

        private void txtTim_tacgia_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (cboTim_tacgia.Text == "Mã")
            {
                var findmatg = (from s in db.TACGIAs
                                where s.MATACGIA.Contains(txtTim_tacgia.Text)
                                select s).ToList();
                dgvtacgia.DataSource = findmatg;
            }
            else
            {
                var findntentg = (from s in db.TACGIAs
                                  where s.TENTACGIA.Contains(txtTim_tacgia.Text)
                                  select s).ToList();
                dgvtacgia.DataSource = findntentg;
            }
        }
    }
}