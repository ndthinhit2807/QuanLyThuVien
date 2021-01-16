
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskdg = new System.Windows.Forms.MaskedTextBox();
            this.btnxoadg = new System.Windows.Forms.Button();
            this.btnthemsuadg = new System.Windows.Forms.Button();
            this.txtsdtdg = new System.Windows.Forms.TextBox();
            this.txtdiachidg = new System.Windows.Forms.TextBox();
            this.txttendg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimdg = new System.Windows.Forms.TextBox();
            this.cbotimdg = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdg
            // 
            this.dgvdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.maskdg);
            this.groupBox1.Controls.Add(this.btnxoadg);
            this.groupBox1.Controls.Add(this.btnthemsuadg);
            this.groupBox1.Controls.Add(this.txtsdtdg);
            this.groupBox1.Controls.Add(this.txtdiachidg);
            this.groupBox1.Controls.Add(this.txttendg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1286, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 727);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // maskdg
            // 
            this.maskdg.Location = new System.Drawing.Point(252, 230);
            this.maskdg.Mask = "DG0000";
            this.maskdg.Name = "maskdg";
            this.maskdg.Size = new System.Drawing.Size(137, 35);
            this.maskdg.TabIndex = 18;
            // 
            // btnxoadg
            // 
            this.btnxoadg.Image = ((System.Drawing.Image)(resources.GetObject("btnxoadg.Image")));
            this.btnxoadg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoadg.Location = new System.Drawing.Point(402, 618);
            this.btnxoadg.Name = "btnxoadg";
            this.btnxoadg.Size = new System.Drawing.Size(91, 52);
            this.btnxoadg.TabIndex = 2;
            this.btnxoadg.Text = "Xoá";
            this.btnxoadg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoadg.UseVisualStyleBackColor = true;
            this.btnxoadg.Click += new System.EventHandler(this.btnxoadg_Click);
            // 
            // btnthemsuadg
            // 
            this.btnthemsuadg.Image = ((System.Drawing.Image)(resources.GetObject("btnthemsuadg.Image")));
            this.btnthemsuadg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemsuadg.Location = new System.Drawing.Point(194, 618);
            this.btnthemsuadg.Name = "btnthemsuadg";
            this.btnthemsuadg.Size = new System.Drawing.Size(165, 52);
            this.btnthemsuadg.TabIndex = 2;
            this.btnthemsuadg.Text = "Thêm / Sửa";
            this.btnthemsuadg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemsuadg.UseVisualStyleBackColor = true;
            this.btnthemsuadg.Click += new System.EventHandler(this.btnthemsuadg_Click);
            // 
            // txtsdtdg
            // 
            this.txtsdtdg.Location = new System.Drawing.Point(252, 395);
            this.txtsdtdg.Name = "txtsdtdg";
            this.txtsdtdg.Size = new System.Drawing.Size(329, 35);
            this.txtsdtdg.TabIndex = 1;
            // 
            // txtdiachidg
            // 
            this.txtdiachidg.Location = new System.Drawing.Point(252, 282);
            this.txtdiachidg.Name = "txtdiachidg";
            this.txtdiachidg.Size = new System.Drawing.Size(329, 35);
            this.txtdiachidg.TabIndex = 1;
            // 
            // txttendg
            // 
            this.txttendg.Location = new System.Drawing.Point(252, 340);
            this.txttendg.Name = "txttendg";
            this.txttendg.Size = new System.Drawing.Size(329, 35);
            this.txttendg.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Độc Giả";
            // 
            // txttimdg
            // 
            this.txttimdg.Location = new System.Drawing.Point(6, 46);
            this.txttimdg.Name = "txttimdg";
            this.txttimdg.Size = new System.Drawing.Size(343, 35);
            this.txttimdg.TabIndex = 1;
            this.txttimdg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimdg_KeyUp);
            // 
            // cbotimdg
            // 
            this.cbotimdg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotimdg.FormattingEnabled = true;
            this.cbotimdg.Items.AddRange(new object[] {
            "Mã",
            "Tên",
            "Địa Chỉ",
            "SĐT"});
            this.cbotimdg.Location = new System.Drawing.Point(357, 45);
            this.cbotimdg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotimdg.Name = "cbotimdg";
            this.cbotimdg.Size = new System.Drawing.Size(208, 38);
            this.cbotimdg.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txttimdg);
            this.groupBox3.Controls.Add(this.cbotimdg);
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
        private System.Windows.Forms.TextBox txttimdg;
        private System.Windows.Forms.TextBox txtdiachidg;
        private System.Windows.Forms.TextBox txttendg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsdtdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbotimdg;
        private System.Windows.Forms.MaskedTextBox maskdg;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}