
namespace QuanLyThuVien
{
    partial class frmTheDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtmNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.cboMaNV1 = new System.Windows.Forms.ComboBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.cboMaDocGia = new System.Windows.Forms.ComboBox();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblMathe = new System.Windows.Forms.Label();
            this.dtmNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dgvTheDocGia = new System.Windows.Forms.DataGridView();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lblDemdong = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboTimKiem1 = new System.Windows.Forms.ComboBox();
            this.txtTimKiemTheDocGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTheDocGia = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheDocGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dtmNgayLap);
            this.groupBox2.Controls.Add(this.lblMaNV);
            this.groupBox2.Controls.Add(this.lblMaDocGia);
            this.groupBox2.Controls.Add(this.txtMaThe);
            this.groupBox2.Controls.Add(this.cboMaNV1);
            this.groupBox2.Controls.Add(this.lblNgayLap);
            this.groupBox2.Controls.Add(this.cboMaDocGia);
            this.groupBox2.Controls.Add(this.lblNgayHetHan);
            this.groupBox2.Controls.Add(this.lblMathe);
            this.groupBox2.Controls.Add(this.dtmNgayHetHan);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(216, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 338);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Thông Tin";
            // 
            // dtmNgayLap
            // 
            this.dtmNgayLap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmNgayLap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayLap.Location = new System.Drawing.Point(211, 224);
            this.dtmNgayLap.Name = "dtmNgayLap";
            this.dtmNgayLap.Size = new System.Drawing.Size(324, 35);
            this.dtmNgayLap.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(49, 101);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(147, 30);
            this.lblMaNV.TabIndex = 10;
            this.lblMaNV.Text = "Mã Nhân Viên";
            this.lblMaNV.UseWaitCursor = true;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDocGia.Location = new System.Drawing.Point(74, 38);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(122, 30);
            this.lblMaDocGia.TabIndex = 10;
            this.lblMaDocGia.Text = "Mã Độc Giả";
            this.lblMaDocGia.UseWaitCursor = true;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaThe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(211, 164);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(324, 35);
            this.txtMaThe.TabIndex = 0;
            // 
            // cboMaNV1
            // 
            this.cboMaNV1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMaNV1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV1.FormattingEnabled = true;
            this.cboMaNV1.Location = new System.Drawing.Point(211, 101);
            this.cboMaNV1.Name = "cboMaNV1";
            this.cboMaNV1.Size = new System.Drawing.Size(324, 38);
            this.cboMaNV1.TabIndex = 3;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(95, 227);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(101, 30);
            this.lblNgayLap.TabIndex = 11;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // cboMaDocGia
            // 
            this.cboMaDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMaDocGia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaDocGia.FormattingEnabled = true;
            this.cboMaDocGia.Location = new System.Drawing.Point(211, 38);
            this.cboMaDocGia.Name = "cboMaDocGia";
            this.cboMaDocGia.Size = new System.Drawing.Size(324, 38);
            this.cboMaDocGia.TabIndex = 3;
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHetHan.Location = new System.Drawing.Point(51, 290);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(145, 30);
            this.lblNgayHetHan.TabIndex = 13;
            this.lblNgayHetHan.Text = "Ngày Hết Hạn";
            // 
            // lblMathe
            // 
            this.lblMathe.AutoSize = true;
            this.lblMathe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathe.Location = new System.Drawing.Point(113, 164);
            this.lblMathe.Name = "lblMathe";
            this.lblMathe.Size = new System.Drawing.Size(83, 30);
            this.lblMathe.TabIndex = 12;
            this.lblMathe.Text = "Mã Thẻ";
            // 
            // dtmNgayHetHan
            // 
            this.dtmNgayHetHan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayHetHan.Location = new System.Drawing.Point(211, 284);
            this.dtmNgayHetHan.Name = "dtmNgayHetHan";
            this.dtmNgayHetHan.Size = new System.Drawing.Size(324, 35);
            this.dtmNgayHetHan.TabIndex = 2;
            // 
            // dgvTheDocGia
            // 
            this.dgvTheDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTheDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTheDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.ngaymuon,
            this.ngaytra,
            this.manv,
            this.ngayhethan});
            this.dgvTheDocGia.Location = new System.Drawing.Point(216, 417);
            this.dgvTheDocGia.Name = "dgvTheDocGia";
            this.dgvTheDocGia.ReadOnly = true;
            this.dgvTheDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheDocGia.Size = new System.Drawing.Size(1115, 448);
            this.dgvTheDocGia.TabIndex = 18;
            this.dgvTheDocGia.SelectionChanged += new System.EventHandler(this.dgvTheDocGia_SelectionChanged);
            this.dgvTheDocGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTheDocGia_MouseClick);
            // 
            // maphieu
            // 
            this.maphieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maphieu.DataPropertyName = "MADOCGIA";
            this.maphieu.HeaderText = "Mã Độc Giả";
            this.maphieu.Name = "maphieu";
            // 
            // ngaymuon
            // 
            this.ngaymuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaymuon.DataPropertyName = "MANV";
            this.ngaymuon.HeaderText = "Mã Nhân Viên";
            this.ngaymuon.Name = "ngaymuon";
            // 
            // ngaytra
            // 
            this.ngaytra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaytra.DataPropertyName = "MATHE";
            this.ngaytra.HeaderText = "Mã Thẻ";
            this.ngaytra.Name = "ngaytra";
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manv.DataPropertyName = "NGAYLAP";
            this.manv.HeaderText = "Ngày Lập";
            this.manv.Name = "manv";
            // 
            // ngayhethan
            // 
            this.ngayhethan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayhethan.DataPropertyName = "NGAYHETHAN";
            this.ngayhethan.HeaderText = "Ngày Hết Hạn";
            this.ngayhethan.Name = "ngayhethan";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl1.TabIndex = 22;
            // 
            // lblDemdong
            // 
            this.lblDemdong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDemdong.AutoSize = true;
            this.lblDemdong.Location = new System.Drawing.Point(1312, 868);
            this.lblDemdong.Name = "lblDemdong";
            this.lblDemdong.Size = new System.Drawing.Size(19, 13);
            this.lblDemdong.TabIndex = 0;
            this.lblDemdong.Text = "...";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(220, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 40);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(426, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 40);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.cboTimKiem1);
            this.groupBox3.Controls.Add(this.txtTimKiemTheDocGia);
            this.groupBox3.Location = new System.Drawing.Point(812, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 94);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // cboTimKiem1
            // 
            this.cboTimKiem1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTimKiem1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboTimKiem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimKiem1.FormattingEnabled = true;
            this.cboTimKiem1.Items.AddRange(new object[] {
            "Mã Độc Giả",
            "Mã Nhân Viên",
            "Mã Thẻ"});
            this.cboTimKiem1.Location = new System.Drawing.Point(347, 31);
            this.cboTimKiem1.Name = "cboTimKiem1";
            this.cboTimKiem1.Size = new System.Drawing.Size(164, 38);
            this.cboTimKiem1.TabIndex = 10;
            // 
            // txtTimKiemTheDocGia
            // 
            this.txtTimKiemTheDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemTheDocGia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTheDocGia.Location = new System.Drawing.Point(9, 34);
            this.txtTimKiemTheDocGia.Name = "txtTimKiemTheDocGia";
            this.txtTimKiemTheDocGia.Size = new System.Drawing.Size(325, 35);
            this.txtTimKiemTheDocGia.TabIndex = 9;
            this.txtTimKiemTheDocGia.TextChanged += new System.EventHandler(this.txtTimKiemTheDocGia_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(16, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(122, 23);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 40);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(329, 23);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 40);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Location = new System.Drawing.Point(812, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 79);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lblTheDocGia
            // 
            this.lblTheDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTheDocGia.AutoSize = true;
            this.lblTheDocGia.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheDocGia.Location = new System.Drawing.Point(880, 130);
            this.lblTheDocGia.Name = "lblTheDocGia";
            this.lblTheDocGia.Size = new System.Drawing.Size(361, 50);
            this.lblTheDocGia.TabIndex = 23;
            this.lblTheDocGia.Text = "Quản Lý Thẻ Độc Giả";
            // 
            // frmTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 960);
            this.Controls.Add(this.lblTheDocGia);
            this.Controls.Add(this.lblDemdong);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTheDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTheDocGia";
            this.Text = "TheDocGia";
            this.Load += new System.EventHandler(this.TheDocGia_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheDocGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtmNgayLap;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.ComboBox cboMaDocGia;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.Label lblMathe;
        private System.Windows.Forms.DateTimePicker dtmNgayHetHan;
        private System.Windows.Forms.DataGridView dgvTheDocGia;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
        private System.Windows.Forms.ComboBox cboMaNV1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.Label lblDemdong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimKiemTheDocGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTimKiem1;
        private System.Windows.Forms.Label lblTheDocGia;
    }
}