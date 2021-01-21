
namespace QuanLyThuVien
{
    partial class frmTheloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheloai));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskMa_theloai = new System.Windows.Forms.MaskedTextBox();
            this.txtTen_theloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbotimds = new System.Windows.Forms.ComboBox();
            this.txtTimtl = new System.Windows.Forms.TextBox();
            this.dgvTheloai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLammoi_theloai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnLammoi_theloai);
            this.groupBox1.Controls.Add(this.mskMa_theloai);
            this.groupBox1.Controls.Add(this.txtTen_theloai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1286, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 727);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // mskMa_theloai
            // 
            this.mskMa_theloai.Location = new System.Drawing.Point(230, 239);
            this.mskMa_theloai.Name = "mskMa_theloai";
            this.mskMa_theloai.ReadOnly = true;
            this.mskMa_theloai.Size = new System.Drawing.Size(140, 36);
            this.mskMa_theloai.TabIndex = 20;
            // 
            // txtTen_theloai
            // 
            this.txtTen_theloai.Location = new System.Drawing.Point(230, 311);
            this.txtTen_theloai.Name = "txtTen_theloai";
            this.txtTen_theloai.Size = new System.Drawing.Size(329, 36);
            this.txtTen_theloai.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Thể Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Thể Loại";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(138, 413);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 53);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm / Sửa";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(322, 413);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 53);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbotimds
            // 
            this.cbotimds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotimds.FormattingEnabled = true;
            this.cbotimds.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cbotimds.Location = new System.Drawing.Point(357, 45);
            this.cbotimds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotimds.Name = "cbotimds";
            this.cbotimds.Size = new System.Drawing.Size(208, 38);
            this.cbotimds.TabIndex = 3;
            // 
            // txtTimtl
            // 
            this.txtTimtl.Location = new System.Drawing.Point(6, 46);
            this.txtTimtl.Name = "txtTimtl";
            this.txtTimtl.Size = new System.Drawing.Size(343, 35);
            this.txtTimtl.TabIndex = 11;
            this.txtTimtl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimtl_KeyUp);
            // 
            // dgvTheloai
            // 
            this.dgvTheloai.AllowUserToAddRows = false;
            this.dgvTheloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTheloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTheloai.Location = new System.Drawing.Point(6, 99);
            this.dgvTheloai.Name = "dgvTheloai";
            this.dgvTheloai.ReadOnly = true;
            this.dgvTheloai.RowHeadersWidth = 51;
            this.dgvTheloai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheloai.Size = new System.Drawing.Size(1256, 622);
            this.dgvTheloai.TabIndex = 8;
            this.dgvTheloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheloai_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATHELOAI";
            this.Column1.HeaderText = "Mã Thể Loại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTHELOAI";
            this.Column2.HeaderText = "Tên Thể Loại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.cbotimds);
            this.groupBox3.Controls.Add(this.dgvTheloai);
            this.groupBox3.Controls.Add(this.txtTimtl);
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
            this.labelControl1.Location = new System.Drawing.Point(842, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 65);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Thể Loại";
            // 
            // btnLammoi_theloai
            // 
            this.btnLammoi_theloai.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi_theloai.Image")));
            this.btnLammoi_theloai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi_theloai.Location = new System.Drawing.Point(439, 412);
            this.btnLammoi_theloai.Name = "btnLammoi_theloai";
            this.btnLammoi_theloai.Size = new System.Drawing.Size(148, 52);
            this.btnLammoi_theloai.TabIndex = 28;
            this.btnLammoi_theloai.Text = "Làm Mới";
            this.btnLammoi_theloai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi_theloai.UseVisualStyleBackColor = true;
            this.btnLammoi_theloai.Click += new System.EventHandler(this.btnLammoi_theloai_Click);
            // 
            // frmTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 840);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTheloai";
            this.Text = "Theloai";
            this.Load += new System.EventHandler(this.Theloai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTheloai;
        private System.Windows.Forms.TextBox txtTimtl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen_theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cbotimds;
        private System.Windows.Forms.MaskedTextBox mskMa_theloai;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnLammoi_theloai;
    }
}