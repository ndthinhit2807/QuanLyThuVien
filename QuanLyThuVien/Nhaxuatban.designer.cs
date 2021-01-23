
namespace QuanLyThuVien
{
    partial class frmNxb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNxb));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLammoi_nxb = new System.Windows.Forms.Button();
            this.lbltestsdt_nxb = new System.Windows.Forms.Label();
            this.mskSdt_nxb = new System.Windows.Forms.MaskedTextBox();
            this.mskMa_nxb = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi_nxb = new System.Windows.Forms.TextBox();
            this.txtTen_nxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTim_nxb = new System.Windows.Forms.TextBox();
            this.cboTim_nxb = new System.Windows.Forms.ComboBox();
            this.dgvnhaxuatban = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaxuatban)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnLammoi_nxb);
            this.groupBox1.Controls.Add(this.lbltestsdt_nxb);
            this.groupBox1.Controls.Add(this.mskSdt_nxb);
            this.groupBox1.Controls.Add(this.mskMa_nxb);
            this.groupBox1.Controls.Add(this.txtDiachi_nxb);
            this.groupBox1.Controls.Add(this.txtTen_nxb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1286, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 727);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // btnLammoi_nxb
            // 
            this.btnLammoi_nxb.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi_nxb.Image")));
            this.btnLammoi_nxb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi_nxb.Location = new System.Drawing.Point(417, 443);
            this.btnLammoi_nxb.Name = "btnLammoi_nxb";
            this.btnLammoi_nxb.Size = new System.Drawing.Size(148, 52);
            this.btnLammoi_nxb.TabIndex = 28;
            this.btnLammoi_nxb.Text = "Làm Mới";
            this.btnLammoi_nxb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi_nxb.UseVisualStyleBackColor = true;
            this.btnLammoi_nxb.Click += new System.EventHandler(this.btnLammoi_nxb_Click);
            // 
            // lbltestsdt_nxb
            // 
            this.lbltestsdt_nxb.AutoSize = true;
            this.lbltestsdt_nxb.ForeColor = System.Drawing.Color.Red;
            this.lbltestsdt_nxb.Location = new System.Drawing.Point(236, 314);
            this.lbltestsdt_nxb.Name = "lbltestsdt_nxb";
            this.lbltestsdt_nxb.Size = new System.Drawing.Size(86, 30);
            this.lbltestsdt_nxb.TabIndex = 15;
            this.lbltestsdt_nxb.Text = "Test sdt";
            // 
            // mskSdt_nxb
            // 
            this.mskSdt_nxb.Location = new System.Drawing.Point(241, 347);
            this.mskSdt_nxb.Mask = "0000000000";
            this.mskSdt_nxb.Name = "mskSdt_nxb";
            this.mskSdt_nxb.Size = new System.Drawing.Size(140, 36);
            this.mskSdt_nxb.TabIndex = 4;
            this.mskSdt_nxb.Click += new System.EventHandler(this.mskSdt_nxb_Click);
            this.mskSdt_nxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskSdt_nxb_KeyUp);
            // 
            // mskMa_nxb
            // 
            this.mskMa_nxb.Location = new System.Drawing.Point(241, 128);
            this.mskMa_nxb.Name = "mskMa_nxb";
            this.mskMa_nxb.ReadOnly = true;
            this.mskMa_nxb.Size = new System.Drawing.Size(140, 36);
            this.mskMa_nxb.TabIndex = 1;
            // 
            // txtDiachi_nxb
            // 
            this.txtDiachi_nxb.Location = new System.Drawing.Point(241, 274);
            this.txtDiachi_nxb.Name = "txtDiachi_nxb";
            this.txtDiachi_nxb.Size = new System.Drawing.Size(329, 36);
            this.txtDiachi_nxb.TabIndex = 3;
            // 
            // txtTen_nxb
            // 
            this.txtTen_nxb.Location = new System.Drawing.Point(241, 201);
            this.txtTen_nxb.Name = "txtTen_nxb";
            this.txtTen_nxb.Size = new System.Drawing.Size(329, 36);
            this.txtTen_nxb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Địa Chỉ NXB";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(297, 443);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 52);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(103, 443);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 52);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm / Sửa";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // txtTim_nxb
            // 
            this.txtTim_nxb.Location = new System.Drawing.Point(6, 46);
            this.txtTim_nxb.Name = "txtTim_nxb";
            this.txtTim_nxb.Size = new System.Drawing.Size(343, 35);
            this.txtTim_nxb.TabIndex = 7;
            this.txtTim_nxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // cboTim_nxb
            // 
            this.cboTim_nxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim_nxb.FormattingEnabled = true;
            this.cboTim_nxb.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cboTim_nxb.Location = new System.Drawing.Point(357, 45);
            this.cboTim_nxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTim_nxb.Name = "cboTim_nxb";
            this.cboTim_nxb.Size = new System.Drawing.Size(208, 38);
            this.cboTim_nxb.TabIndex = 8;
            this.cboTim_nxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotimds_KeyUp);
            // 
            // dgvnhaxuatban
            // 
            this.dgvnhaxuatban.AllowUserToAddRows = false;
            this.dgvnhaxuatban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhaxuatban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhaxuatban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvnhaxuatban.Location = new System.Drawing.Point(6, 99);
            this.dgvnhaxuatban.Name = "dgvnhaxuatban";
            this.dgvnhaxuatban.ReadOnly = true;
            this.dgvnhaxuatban.RowHeadersWidth = 51;
            this.dgvnhaxuatban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhaxuatban.Size = new System.Drawing.Size(1256, 622);
            this.dgvnhaxuatban.TabIndex = 13;
            this.dgvnhaxuatban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhaxuatban_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANXB";
            this.Column1.HeaderText = "Mã NXB";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNXB";
            this.Column2.HeaderText = "Tên NXB";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHINXB";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DIENTHOAIXB";
            this.Column4.HeaderText = "SĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtTim_nxb);
            this.groupBox3.Controls.Add(this.cboTim_nxb);
            this.groupBox3.Controls.Add(this.dgvnhaxuatban);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 727);
            this.groupBox3.TabIndex = 12;
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
            this.labelControl1.Size = new System.Drawing.Size(310, 65);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Nhà Xuất Bản";
            // 
            // frmNxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 840);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNxb";
            this.Text = "Nhaxuatban";
            this.Load += new System.EventHandler(this.Nhaxuatban_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaxuatban)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvnhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim_nxb;
        private System.Windows.Forms.TextBox txtDiachi_nxb;
        private System.Windows.Forms.TextBox txtTen_nxb;
        private System.Windows.Forms.ComboBox cboTim_nxb;
        private System.Windows.Forms.MaskedTextBox mskMa_nxb;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox mskSdt_nxb;
        private System.Windows.Forms.Label lbltestsdt_nxb;
        private System.Windows.Forms.Button btnLammoi_nxb;
    }
}