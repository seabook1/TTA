namespace WFQuanLyTrungTamTiengAnh
{
    partial class ThongTinKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinKhoaHoc));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdTenKhoaHoc = new System.Windows.Forms.RadioButton();
            this.rdMaKhoaHoc = new System.Windows.Forms.RadioButton();
            this.btnTrove = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.rdTenKhoaHoc);
            this.groupControl1.Controls.Add(this.rdMaKhoaHoc);
            this.groupControl1.Location = new System.Drawing.Point(4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(293, 53);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // rdTenKhoaHoc
            // 
            this.rdTenKhoaHoc.AutoSize = true;
            this.rdTenKhoaHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTenKhoaHoc.Location = new System.Drawing.Point(178, 29);
            this.rdTenKhoaHoc.Name = "rdTenKhoaHoc";
            this.rdTenKhoaHoc.Size = new System.Drawing.Size(113, 20);
            this.rdTenKhoaHoc.TabIndex = 26;
            this.rdTenKhoaHoc.TabStop = true;
            this.rdTenKhoaHoc.Text = "Tên khóa học";
            this.rdTenKhoaHoc.UseVisualStyleBackColor = true;
            // 
            // rdMaKhoaHoc
            // 
            this.rdMaKhoaHoc.AutoSize = true;
            this.rdMaKhoaHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaKhoaHoc.Location = new System.Drawing.Point(8, 29);
            this.rdMaKhoaHoc.Name = "rdMaKhoaHoc";
            this.rdMaKhoaHoc.Size = new System.Drawing.Size(107, 20);
            this.rdMaKhoaHoc.TabIndex = 25;
            this.rdMaKhoaHoc.TabStop = true;
            this.rdMaKhoaHoc.Text = "Mã khóa học";
            this.rdMaKhoaHoc.UseVisualStyleBackColor = true;
            this.rdMaKhoaHoc.CheckedChanged += new System.EventHandler(this.rdMaKhoaHoc_CheckedChanged);
            // 
            // btnTrove
            // 
            this.btnTrove.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTrove.Appearance.Options.UseFont = true;
            this.btnTrove.Image = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.back;
            this.btnTrove.Location = new System.Drawing.Point(468, 357);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(104, 33);
            this.btnTrove.TabIndex = 25;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.MonHoc,
            this.HocPhi});
            this.dataGridView1.Location = new System.Drawing.Point(4, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 250);
            this.dataGridView1.TabIndex = 27;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khóa học";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khóa học";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // MonHoc
            // 
            this.MonHoc.DataPropertyName = "MaMH";
            this.MonHoc.HeaderText = "Môn học";
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Width = 150;
            // 
            // HocPhi
            // 
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Học phí";
            this.HocPhi.Name = "HocPhi";
            this.HocPhi.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Location = new System.Drawing.Point(4, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 41);
            this.panel1.TabIndex = 28;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(327, 8);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 28);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(3, 11);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem.Size = new System.Drawing.Size(293, 22);
            this.txtTimKiem.TabIndex = 23;
            // 
            // ThongTinKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnTrove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ThongTinKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThôngTinKhoaHoc";
            this.Load += new System.EventHandler(this.ThôngTinKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTrove;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdMaKhoaHoc;
        private System.Windows.Forms.RadioButton rdTenKhoaHoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocPhi;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
    }
}