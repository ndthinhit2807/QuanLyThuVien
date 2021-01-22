
namespace QuanLyThuVien
{
    partial class frmTacgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacgia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLammoi_tacgia = new System.Windows.Forms.Button();
            this.mskMa_tacgia = new System.Windows.Forms.MaskedTextBox();
            this.btnxoatg = new System.Windows.Forms.Button();
            this.btnthemsuatg = new System.Windows.Forms.Button();
            this.txtTen_tacgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtacgia = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboTim_tacgia = new System.Windows.Forms.ComboBox();
            this.txtTim_tacgia = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnLammoi_tacgia);
            this.groupBox1.Controls.Add(this.mskMa_tacgia);
            this.groupBox1.Controls.Add(this.btnxoatg);
            this.groupBox1.Controls.Add(this.btnthemsuatg);
            this.groupBox1.Controls.Add(this.txtTen_tacgia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1286, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 727);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // btnLammoi_tacgia
            // 
            this.btnLammoi_tacgia.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi_tacgia.Image")));
            this.btnLammoi_tacgia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi_tacgia.Location = new System.Drawing.Point(432, 380);
            this.btnLammoi_tacgia.Name = "btnLammoi_tacgia";
            this.btnLammoi_tacgia.Size = new System.Drawing.Size(148, 52);
            this.btnLammoi_tacgia.TabIndex = 28;
            this.btnLammoi_tacgia.Text = "Làm Mới";
            this.btnLammoi_tacgia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi_tacgia.UseVisualStyleBackColor = true;
            this.btnLammoi_tacgia.Click += new System.EventHandler(this.btnLammoi_tacgia_Click);
            // 
            // mskMa_tacgia
            // 
            this.mskMa_tacgia.Location = new System.Drawing.Point(243, 202);
            this.mskMa_tacgia.Name = "mskMa_tacgia";
            this.mskMa_tacgia.ReadOnly = true;
            this.mskMa_tacgia.Size = new System.Drawing.Size(140, 35);
            this.mskMa_tacgia.TabIndex = 21;
            // 
            // btnxoatg
            // 
            this.btnxoatg.Image = ((System.Drawing.Image)(resources.GetObject("btnxoatg.Image")));
            this.btnxoatg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoatg.Location = new System.Drawing.Point(313, 380);
            this.btnxoatg.Name = "btnxoatg";
            this.btnxoatg.Size = new System.Drawing.Size(85, 49);
            this.btnxoatg.TabIndex = 2;
            this.btnxoatg.Text = "Xoá";
            this.btnxoatg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoatg.UseVisualStyleBackColor = true;
            this.btnxoatg.Click += new System.EventHandler(this.btnxoatg_Click);
            // 
            // btnthemsuatg
            // 
            this.btnthemsuatg.Image = ((System.Drawing.Image)(resources.GetObject("btnthemsuatg.Image")));
            this.btnthemsuatg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemsuatg.Location = new System.Drawing.Point(117, 380);
            this.btnthemsuatg.Name = "btnthemsuatg";
            this.btnthemsuatg.Size = new System.Drawing.Size(162, 49);
            this.btnthemsuatg.TabIndex = 2;
            this.btnthemsuatg.Text = "Thêm / Sửa";
            this.btnthemsuatg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemsuatg.UseVisualStyleBackColor = true;
            this.btnthemsuatg.Click += new System.EventHandler(this.btnthemsuatg_Click);
            // 
            // txtTen_tacgia
            // 
            this.txtTen_tacgia.Location = new System.Drawing.Point(243, 277);
            this.txtTen_tacgia.Name = "txtTen_tacgia";
            this.txtTen_tacgia.Size = new System.Drawing.Size(329, 35);
            this.txtTen_tacgia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tác Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tác Giả";
            // 
            // dgvtacgia
            // 
            this.dgvtacgia.AllowUserToAddRows = false;
            this.dgvtacgia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvtacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvtacgia.Location = new System.Drawing.Point(6, 99);
            this.dgvtacgia.Name = "dgvtacgia";
            this.dgvtacgia.RowHeadersWidth = 51;
            this.dgvtacgia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtacgia.Size = new System.Drawing.Size(1256, 622);
            this.dgvtacgia.TabIndex = 1;
            this.dgvtacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtacgia_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.cboTim_tacgia);
            this.groupBox3.Controls.Add(this.txtTim_tacgia);
            this.groupBox3.Controls.Add(this.dgvtacgia);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 727);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // cboTim_tacgia
            // 
            this.cboTim_tacgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim_tacgia.FormattingEnabled = true;
            this.cboTim_tacgia.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cboTim_tacgia.Location = new System.Drawing.Point(357, 45);
            this.cboTim_tacgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTim_tacgia.Name = "cboTim_tacgia";
            this.cboTim_tacgia.Size = new System.Drawing.Size(208, 38);
            this.cboTim_tacgia.TabIndex = 3;
            // 
            // txtTim_tacgia
            // 
            this.txtTim_tacgia.Location = new System.Drawing.Point(6, 46);
            this.txtTim_tacgia.Name = "txtTim_tacgia";
            this.txtTim_tacgia.Size = new System.Drawing.Size(343, 35);
            this.txtTim_tacgia.TabIndex = 11;
            this.txtTim_tacgia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTim_tacgia_KeyUp_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(957, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(160, 65);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tác Giả";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTACGIA";
            this.Column2.HeaderText = "Tên Tác Giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATACGIA";
            this.Column1.HeaderText = "Mã Tác Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmTacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 840);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTacgia";
            this.Text = "Tacgia";
            this.Load += new System.EventHandler(this.frmTacgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoatg;
        private System.Windows.Forms.Button btnthemsuatg;
        private System.Windows.Forms.TextBox txtTen_tacgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtacgia;
        private System.Windows.Forms.MaskedTextBox mskMa_tacgia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboTim_tacgia;
        private System.Windows.Forms.TextBox txtTim_tacgia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnLammoi_tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}