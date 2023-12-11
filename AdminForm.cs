using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using DAQuanLyTrungTamTA;
//

namespace WFQuanLyTrungTamTiengAnh
{
    public partial class AdminForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string us;
        string pass;
        string role;
        DBTaiKhoan dbtk;
        DataTable dt;
        public AdminForm(string us,string pass)
        {
            InitializeComponent();
            this.us = us;
            this.pass = pass;
            dbtk = new DBTaiKhoan();
        }       

        private void btnStaff_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new QuanLyNhanVien();
            frm.Text = "Quản lý nhân viên";
            frm.ShowDialog();
            
            
        }

        private void btnProfessor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new QuanLyGiangVien();
            frm.Text = "Quản lý giảng viên";
            frm.ShowDialog();
            
        }

        private void btnCourse_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new QuanLyKhoaHoc();
            frm.Text = "Quản lý khóa học";
            frm.ShowDialog();
        }

        private void btnClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = new QuanLyLopHoc();
            frm.Text = "Quản lý lớp học";
            frm.ShowDialog();
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmTaiKhoan();
            f.Text = "Quản lý tài khoản";
            f.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Form f = new DoiPassWord(us, pass);
            f.Text = "Đổi mật khẩu";
            f.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new DangNhap();
            f.Text = "Đăng nhập";
            f.ShowDialog();
            AdminForm.ActiveForm.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new ThongTinLopHoc();
            f.Text = "Thông tin lớp học";
            f.ShowDialog();
        }

        private void btnThongtinKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new ThongTinKhoaHoc();
            f.Text = "Thông tin khóa học";
            f.ShowDialog();
        }

        private void btnHocvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new QuanLyHocVien();
            f.Text = "Quản lý học viên";
            f.ShowDialog();
        }

        private void btnDangKi_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            Form f = new GhiDanh();
            f.Text = "Đăng kí học viên";
            f.ShowDialog();
        }

        private void btnThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new PhieuThuHocPhi();
            f.Text = "Thu học phí";
            f.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                dt = dbtk.TimTaiKhoanNV(us).Tables[0];
                //
                role = dt.Rows[0][2].ToString();
               
                if(role == "1")
                {
                    rbQuanLy.Visible = false;
                }

            }
            catch
            {

            }
        }

        private void btnThongTinCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new ThongTinCaNhan(us);
            f.Text = "Thông tin cá nhân";
            f.ShowDialog();
        }
    }
}