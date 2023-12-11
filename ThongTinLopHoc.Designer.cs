namespace WFQuanLyTrungTamTiengAnh
{
    partial class ThongTinLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinLopHoc));
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdTenLopHoc = new System.Windows.Forms.RadioButton();
            this.rdMaLopHoc = new System.Windows.Forms.RadioButton();
            this.btnTrove = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoaHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GiangVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(316, 44);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem.Size = new System.Drawing.Size(229, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdTenLopHoc);
            this.groupControl1.Controls.Add(this.rdMaLopHoc);
            this.groupControl1.Location = new System.Drawing.Point(3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(307, 66);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // rdTenLopHoc
            // 
            this.rdTenLopHoc.AutoSize = true;
            this.rdTenLopHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTenLopHoc.Location = new System.Drawing.Point(202, 36);
            this.rdTenLopHoc.Name = "rdTenLopHoc";
            this.rdTenLopHoc.Size = new System.Drawing.Size(102, 20);
            this.rdTenLopHoc.TabIndex = 7;
            this.rdTenLopHoc.TabStop = true;
            this.rdTenLopHoc.Text = "Tên lớp học\r\n";
            this.rdTenLopHoc.UseVisualStyleBackColor = true;
            // 
            // rdMaLopHoc
            // 
            this.rdMaLopHoc.AutoSize = true;
            this.rdMaLopHoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaLopHoc.Location = new System.Drawing.Point(5, 36);
            this.rdMaLopHoc.Name = "rdMaLopHoc";
            this.rdMaLopHoc.Size = new System.Drawing.Size(96, 20);
            this.rdMaLopHoc.TabIndex = 6;
            this.rdMaLopHoc.TabStop = true;
            this.rdMaLopHoc.Text = "Mã lớp học\r\n";
            this.rdMaLopHoc.UseVisualStyleBackColor = true;
            // 
            // btnTrove
            // 
            this.btnTrove.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTrove.Appearance.Options.UseFont = true;
            this.btnTrove.Image = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.back;
            this.btnTrove.Location = new System.Drawing.Point(587, 329);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(117, 36);
            this.btnTrove.TabIndex = 3;
            this.btnTrove.Text = "Trở về\r\n";
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(560, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(117, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLH,
            this.TenLH,
            this.DChi,
            this.SoLuong,
            this.NgBatDau,
            this.NgKetThuc,
            this.KhoaHoc,
            this.GiangVien});
            this.dataGridView1.Location = new System.Drawing.Point(4, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 236);
            this.dataGridView1.TabIndex = 5;
            // 
            // MaLH
            // 
            this.MaLH.DataPropertyName = "MaLH";
            this.MaLH.HeaderText = "Mã lớp học";
            this.MaLH.Name = "MaLH";
            // 
            // TenLH
            // 
            this.TenLH.DataPropertyName = "TenLH";
            this.TenLH.HeaderText = "Tên lớp học";
            this.TenLH.Name = "TenLH";
            // 
            // DChi
            // 
            this.DChi.DataPropertyName = "DChi";
            this.DChi.HeaderText = "Địa chỉ";
            this.DChi.Name = "DChi";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // NgBatDau
            // 
            this.NgBatDau.DataPropertyName = "NgBatDau";
            this.NgBatDau.HeaderText = "Ngày bắt đầu";
            this.NgBatDau.Name = "NgBatDau";
            // 
            // NgKetThuc
            // 
            this.NgKetThuc.DataPropertyName = "NgKetThuc";
            this.NgKetThuc.HeaderText = "Ngày kết thúc";
            this.NgKetThuc.Name = "NgKetThuc";
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.DataPropertyName = "MaKH";
            this.KhoaHoc.HeaderText = "Khóa học";
            this.KhoaHoc.Name = "KhoaHoc";
            this.KhoaHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KhoaHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GiangVien
            // 
            this.GiangVien.DataPropertyName = "MaGV";
            this.GiangVien.HeaderText = "Giảng viên";
            this.GiangVien.Name = "GiangVien";
            // 
            // ThongTinLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ThongTinLopHoc";
            this.Text = "ThongTinLopHoc";
            this.Load += new System.EventHandler(this.ThongTinLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdMaLopHoc;
        private System.Windows.Forms.RadioButton rdTenLopHoc;
        private DevExpress.XtraEditors.SimpleButton btnTrove;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgKetThuc;
        private System.Windows.Forms.DataGridViewComboBoxColumn KhoaHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn GiangVien;
    }
}