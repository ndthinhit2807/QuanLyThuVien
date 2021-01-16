
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbotimtg = new System.Windows.Forms.ComboBox();
            this.txtTimkiemtg = new System.Windows.Forms.TextBox();
            this.dgvtacgia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoatg = new System.Windows.Forms.Button();
            this.btnthemsuatg = new System.Windows.Forms.Button();
            this.txttentg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.masktg = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.masktg);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvtacgia);
            this.groupBox1.Controls.Add(this.btnxoatg);
            this.groupBox1.Controls.Add(this.btnthemsuatg);
            this.groupBox1.Controls.Add(this.txttentg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 680);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbotimtg);
            this.groupBox2.Controls.Add(this.txtTimkiemtg);
            this.groupBox2.Location = new System.Drawing.Point(487, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 91);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // cbotimtg
            // 
            this.cbotimtg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotimtg.FormattingEnabled = true;
            this.cbotimtg.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.cbotimtg.Location = new System.Drawing.Point(403, 32);
            this.cbotimtg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotimtg.Name = "cbotimtg";
            this.cbotimtg.Size = new System.Drawing.Size(208, 38);
            this.cbotimtg.TabIndex = 3;
            // 
            // txtTimkiemtg
            // 
            this.txtTimkiemtg.Location = new System.Drawing.Point(33, 33);
            this.txtTimkiemtg.Name = "txtTimkiemtg";
            this.txtTimkiemtg.Size = new System.Drawing.Size(343, 35);
            this.txtTimkiemtg.TabIndex = 1;
            this.txtTimkiemtg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimkiemtg_KeyUp);
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
            this.dgvtacgia.Location = new System.Drawing.Point(6, 227);
            this.dgvtacgia.Name = "dgvtacgia";
            this.dgvtacgia.RowHeadersWidth = 51;
            this.dgvtacgia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtacgia.Size = new System.Drawing.Size(1290, 447);
            this.dgvtacgia.TabIndex = 1;
            this.dgvtacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtacgia_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATACGIA";
            this.Column1.HeaderText = "Mã Tác Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTACGIA";
            this.Column2.HeaderText = "Tên Tác Giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnxoatg
            // 
            this.btnxoatg.Image = ((System.Drawing.Image)(resources.GetObject("btnxoatg.Image")));
            this.btnxoatg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoatg.Location = new System.Drawing.Point(375, 140);
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
            this.btnthemsuatg.Location = new System.Drawing.Point(174, 140);
            this.btnthemsuatg.Name = "btnthemsuatg";
            this.btnthemsuatg.Size = new System.Drawing.Size(162, 49);
            this.btnthemsuatg.TabIndex = 2;
            this.btnthemsuatg.Text = "Thêm / Sửa";
            this.btnthemsuatg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemsuatg.UseVisualStyleBackColor = true;
            this.btnthemsuatg.Click += new System.EventHandler(this.btnthemsuatg_Click);
            // 
            // txttentg
            // 
            this.txttentg.Location = new System.Drawing.Point(810, 64);
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(329, 35);
            this.txttentg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tác Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tác Giả";
            // 
            // masktg
            // 
            this.masktg.Location = new System.Drawing.Point(292, 64);
            this.masktg.Mask = "TG0000";
            this.masktg.Name = "masktg";
            this.masktg.Size = new System.Drawing.Size(329, 35);
            this.masktg.TabIndex = 21;
            // 
            // frmTacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 704);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTacgia";
            this.Text = "Tacgia";
            this.Load += new System.EventHandler(this.frmTacgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoatg;
        private System.Windows.Forms.Button btnthemsuatg;
        private System.Windows.Forms.TextBox txtTimkiemtg;
        private System.Windows.Forms.TextBox txttentg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbotimtg;
        private System.Windows.Forms.MaskedTextBox masktg;
    }
}