
namespace QuanLyThuVien
{
    partial class frmDocgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocgia));
            this.dgvdg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskSdt_docgia = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail_docgia = new System.Windows.Forms.Label();
            this.dtmNgaysinh_docgia = new System.Windows.Forms.DateTimePicker();
            this.cboGioitinh_docgia = new System.Windows.Forms.ComboBox();
            this.mskMa_docgia = new System.Windows.Forms.MaskedTextBox();
            this.btnxoadg = new System.Windows.Forms.Button();
            this.btnthemsuadg = new System.Windows.Forms.Button();
            this.txtEmail_docgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi_docgia = new System.Windows.Forms.TextBox();
            this.txtTen_docgia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim_docgia = new System.Windows.Forms.TextBox();
            this.cboTim_docgia = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdg
            // 
            this.dgvdg.AllowUserToAddRows = false;
            this.dgvdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvdg.Location = new System.Drawing.Point(6, 99);
            this.dgvdg.Name = "dgvdg";
            this.dgvdg.ReadOnly = true;
            this.dgvdg.RowHeadersWidth = 51;
            this.dgvdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdg.Size = new System.Drawing.Size(1256, 622);
            this.dgvdg.TabIndex = 9;
            this.dgvdg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdg_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MADOCGIA";
            this.Column1.HeaderText = "Mã Độc Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDOCGIA";
            this.Column2.HeaderText = "Tên Độc Giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GIOITINH";
            this.Column6.HeaderText = "Giới Tính";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NGAYSINH";
            this.Column7.HeaderText = "Ngày Sinh";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDTDOCGIA";
            this.Column4.HeaderText = "SĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EMAIL";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.mskSdt_docgia);
            this.groupBox1.Controls.Add(this.lblEmail_docgia);
            this.groupBox1.Controls.Add(this.dtmNgaysinh_docgia);
            this.groupBox1.Controls.Add(this.cboGioitinh_docgia);
            this.groupBox1.Controls.Add(this.mskMa_docgia);
            this.groupBox1.Controls.Add(this.btnxoadg);
            this.groupBox1.Controls.Add(this.btnthemsuadg);
            this.groupBox1.Controls.Add(this.txtEmail_docgia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiachi_docgia);
            this.groupBox1.Controls.Add(this.txtTen_docgia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1286, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 727);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // mskSdt_docgia
            // 
            this.mskSdt_docgia.Location = new System.Drawing.Point(225, 447);
            this.mskSdt_docgia.Mask = "000000000";
            this.mskSdt_docgia.Name = "mskSdt_docgia";
            this.mskSdt_docgia.Size = new System.Drawing.Size(140, 35);
            this.mskSdt_docgia.TabIndex = 22;
            // 
            // lblEmail_docgia
            // 
            this.lblEmail_docgia.AutoSize = true;
            this.lblEmail_docgia.ForeColor = System.Drawing.Color.Red;
            this.lblEmail_docgia.Location = new System.Drawing.Point(220, 485);
            this.lblEmail_docgia.Name = "lblEmail_docgia";
            this.lblEmail_docgia.Size = new System.Drawing.Size(68, 30);
            this.lblEmail_docgia.TabIndex = 21;
            this.lblEmail_docgia.Text = "label6";
            // 
            // dtmNgaysinh_docgia
            // 
            this.dtmNgaysinh_docgia.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaysinh_docgia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaysinh_docgia.Location = new System.Drawing.Point(225, 307);
            this.dtmNgaysinh_docgia.Name = "dtmNgaysinh_docgia";
            this.dtmNgaysinh_docgia.Size = new System.Drawing.Size(140, 35);
            this.dtmNgaysinh_docgia.TabIndex = 3;
            // 
            // cboGioitinh_docgia
            // 
            this.cboGioitinh_docgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh_docgia.FormattingEnabled = true;
            this.cboGioitinh_docgia.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh_docgia.Location = new System.Drawing.Point(225, 235);
            this.cboGioitinh_docgia.Name = "cboGioitinh_docgia";
            this.cboGioitinh_docgia.Size = new System.Drawing.Size(140, 38);
            this.cboGioitinh_docgia.TabIndex = 2;
            // 
            // mskMa_docgia
            // 
            this.mskMa_docgia.Location = new System.Drawing.Point(225, 97);
            this.mskMa_docgia.Name = "mskMa_docgia";
            this.mskMa_docgia.ReadOnly = true;
            this.mskMa_docgia.Size = new System.Drawing.Size(140, 35);
            this.mskMa_docgia.TabIndex = 0;
            // 
            // btnxoadg
            // 
            this.btnxoadg.Image = ((System.Drawing.Image)(resources.GetObject("btnxoadg.Image")));
            this.btnxoadg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoadg.Location = new System.Drawing.Point(384, 596);
            this.btnxoadg.Name = "btnxoadg";
            this.btnxoadg.Size = new System.Drawing.Size(91, 52);
            this.btnxoadg.TabIndex = 8;
            this.btnxoadg.Text = "Xoá";
            this.btnxoadg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoadg.UseVisualStyleBackColor = true;
            this.btnxoadg.Click += new System.EventHandler(this.btnxoadg_Click);
            // 
            // btnthemsuadg
            // 
            this.btnthemsuadg.Image = ((System.Drawing.Image)(resources.GetObject("btnthemsuadg.Image")));
            this.btnthemsuadg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemsuadg.Location = new System.Drawing.Point(197, 596);
            this.btnthemsuadg.Name = "btnthemsuadg";
            this.btnthemsuadg.Size = new System.Drawing.Size(165, 52);
            this.btnthemsuadg.TabIndex = 7;
            this.btnthemsuadg.Text = "Thêm / Sửa";
            this.btnthemsuadg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemsuadg.UseVisualStyleBackColor = true;
            this.btnthemsuadg.Click += new System.EventHandler(this.btnthemsuadg_Click);
            // 
            // txtEmail_docgia
            // 
            this.txtEmail_docgia.Location = new System.Drawing.Point(225, 517);
            this.txtEmail_docgia.Name = "txtEmail_docgia";
            this.txtEmail_docgia.Size = new System.Drawing.Size(329, 35);
            this.txtEmail_docgia.TabIndex = 6;
            this.txtEmail_docgia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_docgia_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // txtDiachi_docgia
            // 
            this.txtDiachi_docgia.Location = new System.Drawing.Point(225, 377);
            this.txtDiachi_docgia.Name = "txtDiachi_docgia";
            this.txtDiachi_docgia.Size = new System.Drawing.Size(329, 35);
            this.txtDiachi_docgia.TabIndex = 4;
            // 
            // txtTen_docgia
            // 
            this.txtTen_docgia.Location = new System.Drawing.Point(225, 167);
            this.txtTen_docgia.Name = "txtTen_docgia";
            this.txtTen_docgia.Size = new System.Drawing.Size(329, 35);
            this.txtTen_docgia.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới Tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Độc Giả";
            // 
            // txtTim_docgia
            // 
            this.txtTim_docgia.Location = new System.Drawing.Point(6, 46);
            this.txtTim_docgia.Name = "txtTim_docgia";
            this.txtTim_docgia.Size = new System.Drawing.Size(343, 35);
            this.txtTim_docgia.TabIndex = 10;
            this.txtTim_docgia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimdg_KeyUp);
            // 
            // cboTim_docgia
            // 
            this.cboTim_docgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim_docgia.FormattingEnabled = true;
            this.cboTim_docgia.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cboTim_docgia.Location = new System.Drawing.Point(357, 45);
            this.cboTim_docgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTim_docgia.Name = "cboTim_docgia";
            this.cboTim_docgia.Size = new System.Drawing.Size(208, 38);
            this.cboTim_docgia.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtTim_docgia);
            this.groupBox3.Controls.Add(this.cboTim_docgia);
            this.groupBox3.Controls.Add(this.dgvdg);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 727);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(861, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(174, 65);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Độc Giả";
            // 
            // frmDocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 840);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDocgia";
            this.Text = "x";
            this.Load += new System.EventHandler(this.frmDocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoadg;
        private System.Windows.Forms.Button btnthemsuadg;
        private System.Windows.Forms.TextBox txtTim_docgia;
        private System.Windows.Forms.TextBox txtTen_docgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTim_docgia;
        private System.Windows.Forms.MaskedTextBox mskMa_docgia;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtEmail_docgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmNgaysinh_docgia;
        private System.Windows.Forms.ComboBox cboGioitinh_docgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiachi_docgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblEmail_docgia;
        private System.Windows.Forms.MaskedTextBox mskSdt_docgia;
    }
}