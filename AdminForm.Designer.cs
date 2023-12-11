namespace WFQuanLyTrungTamTiengAnh
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.btnProfessor = new DevExpress.XtraBars.BarButtonItem();
            this.btnCourse = new DevExpress.XtraBars.BarButtonItem();
            this.btnClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongtinLH = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongtinKH = new DevExpress.XtraBars.BarButtonItem();
            this.rbTrangChu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNhanvien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnLogin,
            this.btnLogout,
            this.btnStaff,
            this.btnProfessor,
            this.btnCourse,
            this.btnClass,
            this.btnTaiKhoan,
            this.btnThongtinLH,
            this.btnHocvien,
            this.btnDangKi,
            this.btnThuTien,
            this.btnDangXuat,
            this.btnThongTinCaNhan,
            this.btnDoiMK,
            this.btnThongtinKH});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbTrangChu,
            this.rbQuanLy,
            this.rbNhanvien});
            this.ribbon.Size = new System.Drawing.Size(1250, 154);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Login";
            this.btnLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogin.Glyph")));
            this.btnLogin.Id = 1;
            this.btnLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogin.LargeGlyph")));
            this.btnLogin.LargeWidth = 80;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Exit";
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 3;
            this.btnLogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.LargeGlyph")));
            this.btnLogout.LargeWidth = 80;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnStaff
            // 
            this.btnStaff.Caption = "Quản lý nhân viên";
            this.btnStaff.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStaff.Glyph")));
            this.btnStaff.Id = 8;
            this.btnStaff.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStaff.LargeGlyph")));
            this.btnStaff.LargeWidth = 80;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaff_ItemClick);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Caption = "Quản lý giảng viên";
            this.btnProfessor.Id = 9;
            this.btnProfessor.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.teacher_icon;
            this.btnProfessor.LargeWidth = 80;
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProfessor_ItemClick);
            // 
            // btnCourse
            // 
            this.btnCourse.Caption = "Quản lý môn học";
            this.btnCourse.Id = 10;
            this.btnCourse.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.Courses_icon;
            this.btnCourse.LargeWidth = 80;
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCourse_ItemClick);
            // 
            // btnClass
            // 
            this.btnClass.Caption = "Quản lý lớp học";
            this.btnClass.Id = 11;
            this.btnClass.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources._class;
            this.btnClass.LargeWidth = 80;
            this.btnClass.Name = "btnClass";
            this.btnClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClass_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Quản lý tài khoản";
            this.btnTaiKhoan.Id = 12;
            this.btnTaiKhoan.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.manager_account;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnThongtinLH
            // 
            this.btnThongtinLH.Caption = "Thông tin lớp học";
            this.btnThongtinLH.Id = 13;
            this.btnThongtinLH.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.Info;
            this.btnThongtinLH.Name = "btnThongtinLH";
            this.btnThongtinLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnHocvien
            // 
            this.btnHocvien.Caption = "Quản lý học viên";
            this.btnHocvien.Id = 14;
            this.btnHocvien.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.Student_3_128;
            this.btnHocvien.Name = "btnHocvien";
            this.btnHocvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocvien_ItemClick);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Caption = "Đăng kí";
            this.btnDangKi.Id = 15;
            this.btnDangKi.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.sign_up_128;
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKi_ItemClick);
            // 
            // btnThuTien
            // 
            this.btnThuTien.Caption = "Thu tiền";
            this.btnThuTien.Glyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.dollar_128;
            this.btnThuTien.Id = 16;
            this.btnThuTien.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.dollar_128;
            this.btnThuTien.Name = "btnThuTien";
            this.btnThuTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuTien_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 17;
            this.btnDangXuat.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.log_out;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Caption = "Thông tin cá nhân";
            this.btnThongTinCaNhan.Id = 18;
            this.btnThongTinCaNhan.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.information_person;
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinCaNhan_ItemClick);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 19;
            this.btnDoiMK.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.change_password_128;
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // btnThongtinKH
            // 
            this.btnThongtinKH.Caption = "Thông tin khóa học";
            this.btnThongtinKH.Id = 20;
            this.btnThongtinKH.LargeGlyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.information_khoahoc;
            this.btnThongtinKH.Name = "btnThongtinKH";
            this.btnThongtinKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongtinKH_ItemClick);
            // 
            // rbTrangChu
            // 
            this.rbTrangChu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup11});
            this.rbTrangChu.Image = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.house_icon__1_;
            this.rbTrangChu.Name = "rbTrangChu";
            this.rbTrangChu.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "System";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnThongTinCaNhan);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.rbQuanLy.Image = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.administrator_icon;
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStaff);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProfessor);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCourse);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnClass);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ImageIndex = 1;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTaiKhoan);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // rbNhanvien
            // 
            this.rbNhanvien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.rbNhanvien.Image = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.Businessman_icon;
            this.rbNhanvien.Name = "rbNhanvien";
            this.rbNhanvien.Text = "Nhân viên";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnThongtinLH);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnThongtinKH);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnHocvien);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnDangKi);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.Glyph = global::WFQuanLyTrungTamTiengAnh.Properties.Resources.dollar_128;
            this.ribbonPageGroup10.ItemLinks.Add(this.btnThuTien);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 608);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1250, 31);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1250, 639);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbTrangChu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnStaff;
        private DevExpress.XtraBars.BarButtonItem btnProfessor;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnCourse;
        private DevExpress.XtraBars.BarButtonItem btnClass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbNhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnThongtinLH;
        private DevExpress.XtraBars.BarButtonItem btnHocvien;
        private DevExpress.XtraBars.BarButtonItem btnDangKi;
        private DevExpress.XtraBars.BarButtonItem btnThuTien;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThongTinCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem btnThongtinKH;
    }
}