
namespace QuanLyThuVien
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskSdt_nhanvien = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail_nhanvien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboGioitinh_nhanvien = new System.Windows.Forms.ComboBox();
            this.dtmNgaysinh_nhanvien = new System.Windows.Forms.DateTimePicker();
            this.txtEmail_nhanvien = new System.Windows.Forms.TextBox();
            this.txtDiachi_nhanvien = new System.Windows.Forms.TextBox();
            this.txtMa_nhanvien = new System.Windows.Forms.TextBox();
            this.txtTen_nhanvien = new System.Windows.Forms.TextBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cbotimnv = new System.Windows.Forms.ComboBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.mskSdt_nhanvien);
            this.groupBox1.Controls.Add(this.lblEmail_nhanvien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.cboGioitinh_nhanvien);
            this.groupBox1.Controls.Add(this.dtmNgaysinh_nhanvien);
            this.groupBox1.Controls.Add(this.txtEmail_nhanvien);
            this.groupBox1.Controls.Add(this.txtDiachi_nhanvien);
            this.groupBox1.Controls.Add(this.txtMa_nhanvien);
            this.groupBox1.Controls.Add(this.txtTen_nhanvien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1286, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 727);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // mskSdt_nhanvien
            // 
            this.mskSdt_nhanvien.Location = new System.Drawing.Point(215, 446);
            this.mskSdt_nhanvien.Mask = "000000000";
            this.mskSdt_nhanvien.Name = "mskSdt_nhanvien";
            this.mskSdt_nhanvien.Size = new System.Drawing.Size(140, 35);
            this.mskSdt_nhanvien.TabIndex = 6;
            this.mskSdt_nhanvien.Text = "0";
            // 
            // lblEmail_nhanvien
            // 
            this.lblEmail_nhanvien.AutoSize = true;
            this.lblEmail_nhanvien.ForeColor = System.Drawing.Color.Red;
            this.lblEmail_nhanvien.Location = new System.Drawing.Point(210, 484);
            this.lblEmail_nhanvien.Name = "lblEmail_nhanvien";
            this.lblEmail_nhanvien.Size = new System.Drawing.Size(68, 30);
            this.lblEmail_nhanvien.TabIndex = 20;
            this.lblEmail_nhanvien.Text = "label6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày Sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giới Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(187, 598);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 52);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm / Sửa";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(395, 598);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 52);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboGioitinh_nhanvien
            // 
            this.cboGioitinh_nhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh_nhanvien.FormattingEnabled = true;
            this.cboGioitinh_nhanvien.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh_nhanvien.Location = new System.Drawing.Point(215, 235);
            this.cboGioitinh_nhanvien.Name = "cboGioitinh_nhanvien";
            this.cboGioitinh_nhanvien.Size = new System.Drawing.Size(140, 38);
            this.cboGioitinh_nhanvien.TabIndex = 3;
            // 
            // dtmNgaysinh_nhanvien
            // 
            this.dtmNgaysinh_nhanvien.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaysinh_nhanvien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaysinh_nhanvien.Location = new System.Drawing.Point(215, 307);
            this.dtmNgaysinh_nhanvien.MaxDate = new System.DateTime(2100, 2, 28, 0, 0, 0, 0);
            this.dtmNgaysinh_nhanvien.Name = "dtmNgaysinh_nhanvien";
            this.dtmNgaysinh_nhanvien.Size = new System.Drawing.Size(140, 35);
            this.dtmNgaysinh_nhanvien.TabIndex = 4;
            this.dtmNgaysinh_nhanvien.Value = new System.DateTime(2021, 1, 9, 0, 0, 0, 0);
            // 
            // txtEmail_nhanvien
            // 
            this.txtEmail_nhanvien.Location = new System.Drawing.Point(215, 517);
            this.txtEmail_nhanvien.Name = "txtEmail_nhanvien";
            this.txtEmail_nhanvien.Size = new System.Drawing.Size(329, 35);
            this.txtEmail_nhanvien.TabIndex = 7;
            this.txtEmail_nhanvien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_nhanvien_KeyUp);
            // 
            // txtDiachi_nhanvien
            // 
            this.txtDiachi_nhanvien.Location = new System.Drawing.Point(215, 377);
            this.txtDiachi_nhanvien.Name = "txtDiachi_nhanvien";
            this.txtDiachi_nhanvien.Size = new System.Drawing.Size(329, 35);
            this.txtDiachi_nhanvien.TabIndex = 5;
            // 
            // txtMa_nhanvien
            // 
            this.txtMa_nhanvien.Location = new System.Drawing.Point(215, 96);
            this.txtMa_nhanvien.Name = "txtMa_nhanvien";
            this.txtMa_nhanvien.ReadOnly = true;
            this.txtMa_nhanvien.Size = new System.Drawing.Size(140, 35);
            this.txtMa_nhanvien.TabIndex = 1;
            // 
            // txtTen_nhanvien
            // 
            this.txtTen_nhanvien.Location = new System.Drawing.Point(215, 167);
            this.txtTen_nhanvien.Name = "txtTen_nhanvien";
            this.txtTen_nhanvien.Size = new System.Drawing.Size(329, 35);
            this.txtTen_nhanvien.TabIndex = 2;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTimkiem.Location = new System.Drawing.Point(6, 46);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(343, 32);
            this.txtTimkiem.TabIndex = 11;
            this.txtTimkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimkiem_KeyUp);
            // 
            // cbotimnv
            // 
            this.cbotimnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotimnv.FormattingEnabled = true;
            this.cbotimnv.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cbotimnv.Location = new System.Drawing.Point(357, 45);
            this.cbotimnv.Name = "cbotimnv";
            this.cbotimnv.Size = new System.Drawing.Size(208, 38);
            this.cbotimnv.TabIndex = 12;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvNhanvien.Location = new System.Drawing.Point(6, 99);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.ReadOnly = true;
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanvien.Size = new System.Drawing.Size(1256, 622);
            this.dgvNhanvien.TabIndex = 2;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.HeaderText = "Mã Nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTENNV";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIOITINHNV";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYSINHNV";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DIACHINV";
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DIENTHOAINV";
            this.Column6.HeaderText = "SĐT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EMAILNV";
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtTimkiem);
            this.groupBox3.Controls.Add(this.cbotimnv);
            this.groupBox3.Controls.Add(this.dgvNhanvien);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 727);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(873, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(236, 65);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Nhân Viên";
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 840);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmNgaysinh_nhanvien;
        private System.Windows.Forms.TextBox txtEmail_nhanvien;
        private System.Windows.Forms.TextBox txtDiachi_nhanvien;
        private System.Windows.Forms.TextBox txtTen_nhanvien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ComboBox cboGioitinh_nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbotimnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lblEmail_nhanvien;
        private System.Windows.Forms.MaskedTextBox mskSdt_nhanvien;
        private System.Windows.Forms.TextBox txtMa_nhanvien;
    }
}