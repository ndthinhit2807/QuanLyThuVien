
namespace QuanLyThuVien
{
    partial class frmDausach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDausach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskMa_dausach = new System.Windows.Forms.MaskedTextBox();
            this.cboTacgia_dausach = new System.Windows.Forms.ComboBox();
            this.cboNxb_dausach = new System.Windows.Forms.ComboBox();
            this.cboTheloai_dausach = new System.Windows.Forms.ComboBox();
            this.txtNamxb_dausach = new System.Windows.Forms.TextBox();
            this.txtTen_dausach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTim_dausach = new System.Windows.Forms.TextBox();
            this.cboTim_dausach = new System.Windows.Forms.ComboBox();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnxoads = new System.Windows.Forms.Button();
            this.btnthemsuads = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.mskMa_dausach);
            this.groupBox1.Controls.Add(this.cboTacgia_dausach);
            this.groupBox1.Controls.Add(this.cboNxb_dausach);
            this.groupBox1.Controls.Add(this.cboTheloai_dausach);
            this.groupBox1.Controls.Add(this.btnxoads);
            this.groupBox1.Controls.Add(this.btnthemsuads);
            this.groupBox1.Controls.Add(this.txtNamxb_dausach);
            this.groupBox1.Controls.Add(this.txtTen_dausach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1286, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 727);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // mskMa_dausach
            // 
            this.mskMa_dausach.Location = new System.Drawing.Point(254, 156);
            this.mskMa_dausach.Mask = "DS0000";
            this.mskMa_dausach.Name = "mskMa_dausach";
            this.mskMa_dausach.Size = new System.Drawing.Size(137, 35);
            this.mskMa_dausach.TabIndex = 5;
            // 
            // cboTacgia_dausach
            // 
            this.cboTacgia_dausach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTacgia_dausach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboTacgia_dausach.FormattingEnabled = true;
            this.cboTacgia_dausach.Location = new System.Drawing.Point(252, 272);
            this.cboTacgia_dausach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTacgia_dausach.Name = "cboTacgia_dausach";
            this.cboTacgia_dausach.Size = new System.Drawing.Size(329, 38);
            this.cboTacgia_dausach.TabIndex = 3;
            // 
            // cboNxb_dausach
            // 
            this.cboNxb_dausach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNxb_dausach.FormattingEnabled = true;
            this.cboNxb_dausach.Location = new System.Drawing.Point(252, 330);
            this.cboNxb_dausach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNxb_dausach.Name = "cboNxb_dausach";
            this.cboNxb_dausach.Size = new System.Drawing.Size(329, 38);
            this.cboNxb_dausach.TabIndex = 3;
            // 
            // cboTheloai_dausach
            // 
            this.cboTheloai_dausach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheloai_dausach.FormattingEnabled = true;
            this.cboTheloai_dausach.Location = new System.Drawing.Point(252, 390);
            this.cboTheloai_dausach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTheloai_dausach.Name = "cboTheloai_dausach";
            this.cboTheloai_dausach.Size = new System.Drawing.Size(329, 38);
            this.cboTheloai_dausach.TabIndex = 3;
            // 
            // txtNamxb_dausach
            // 
            this.txtNamxb_dausach.Location = new System.Drawing.Point(254, 454);
            this.txtNamxb_dausach.Name = "txtNamxb_dausach";
            this.txtNamxb_dausach.Size = new System.Drawing.Size(137, 35);
            this.txtNamxb_dausach.TabIndex = 1;
            // 
            // txtTen_dausach
            // 
            this.txtTen_dausach.Location = new System.Drawing.Point(252, 215);
            this.txtTen_dausach.Name = "txtTen_dausach";
            this.txtTen_dausach.Size = new System.Drawing.Size(329, 35);
            this.txtTen_dausach.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà Xuất Bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Đầu Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đầu Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtTim_dausach);
            this.groupBox2.Controls.Add(this.cboTim_dausach);
            this.groupBox2.Controls.Add(this.dgvds);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1268, 727);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // txtTim_dausach
            // 
            this.txtTim_dausach.Location = new System.Drawing.Point(6, 46);
            this.txtTim_dausach.Name = "txtTim_dausach";
            this.txtTim_dausach.Size = new System.Drawing.Size(343, 35);
            this.txtTim_dausach.TabIndex = 1;
            this.txtTim_dausach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimds_KeyUp);
            // 
            // cboTim_dausach
            // 
            this.cboTim_dausach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim_dausach.FormattingEnabled = true;
            this.cboTim_dausach.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cboTim_dausach.Location = new System.Drawing.Point(357, 45);
            this.cboTim_dausach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTim_dausach.Name = "cboTim_dausach";
            this.cboTim_dausach.Size = new System.Drawing.Size(208, 38);
            this.cboTim_dausach.TabIndex = 3;
            // 
            // dgvds
            // 
            this.dgvds.AllowUserToAddRows = false;
            this.dgvds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvds.Location = new System.Drawing.Point(6, 99);
            this.dgvds.Name = "dgvds";
            this.dgvds.ReadOnly = true;
            this.dgvds.RowHeadersWidth = 51;
            this.dgvds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvds.Size = new System.Drawing.Size(1256, 622);
            this.dgvds.TabIndex = 1;
            this.dgvds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASACH";
            this.Column1.HeaderText = "Mã Đầu Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSACH";
            this.Column2.HeaderText = "Tên Đầu Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENTHELOAI";
            this.Column3.HeaderText = "Tên Thể Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TENTACGIA";
            this.Column4.HeaderText = "Tên Tác Giả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TENNXB";
            this.Column5.HeaderText = "Tên NXB";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NAMXUATBAN";
            this.Column6.HeaderText = "Năm Xuất Bản";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(873, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(208, 65);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Đầu Sách";
            // 
            // btnxoads
            // 
            this.btnxoads.Image = ((System.Drawing.Image)(resources.GetObject("btnxoads.Image")));
            this.btnxoads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoads.Location = new System.Drawing.Point(402, 618);
            this.btnxoads.Name = "btnxoads";
            this.btnxoads.Size = new System.Drawing.Size(91, 52);
            this.btnxoads.TabIndex = 2;
            this.btnxoads.Text = "Xoá";
            this.btnxoads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoads.UseVisualStyleBackColor = true;
            this.btnxoads.Click += new System.EventHandler(this.btnxoads_Click);
            // 
            // btnthemsuads
            // 
            this.btnthemsuads.Image = ((System.Drawing.Image)(resources.GetObject("btnthemsuads.Image")));
            this.btnthemsuads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemsuads.Location = new System.Drawing.Point(194, 618);
            this.btnthemsuads.Name = "btnthemsuads";
            this.btnthemsuads.Size = new System.Drawing.Size(165, 52);
            this.btnthemsuads.TabIndex = 2;
            this.btnthemsuads.Text = "Thêm / Sửa";
            this.btnthemsuads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemsuads.UseVisualStyleBackColor = true;
            this.btnthemsuads.Click += new System.EventHandler(this.btnthemsuads_Click);
            // 
            // frmDausach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 840);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDausach";
            this.Text = "Dausach";
            this.Load += new System.EventHandler(this.frmDausach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.Button btnxoads;
        private System.Windows.Forms.Button btnthemsuads;
        private System.Windows.Forms.TextBox txtTim_dausach;
        private System.Windows.Forms.TextBox txtTen_dausach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTacgia_dausach;
        private System.Windows.Forms.ComboBox cboTim_dausach;
        private System.Windows.Forms.ComboBox cboNxb_dausach;
        private System.Windows.Forms.ComboBox cboTheloai_dausach;
        private System.Windows.Forms.TextBox txtNamxb_dausach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskMa_dausach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}