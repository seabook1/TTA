using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAQuanLyTrungTamTA;

namespace WFQuanLyTrungTamTiengAnh
{
    public partial class DangNhap : Form
    {

        DataTable dt;
        DBTaiKhoan db;
        string tk;
        string pass;
        public DangNhap()
        {
            InitializeComponent();
            db = new DBTaiKhoan();
        }
        
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTaikhoan.Enabled = true;
            txtMatkhau.Enabled = true;
        }
        
        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            try
            {

                dt = new DataTable();
                dt.Clear();
                dt = db.DangNhapTK(txtTaikhoan.Text, txtMatkhau.Text).Tables[0];
                tk = dt.Rows[0][0].ToString();
                pass = dt.Rows[0][1].ToString();
                if (tk == txtTaikhoan.Text.ToString() && pass == txtMatkhau.Text.ToString())
                {
                    Form f = new AdminForm(tk, pass);
                    f.Text = "Trung tâm tiếng anh";
                    f.ShowDialog();
                    DangNhap.ActiveForm.Close();
                }
                else
                if(tk != txtTaikhoan.Text.ToString() || pass != txtMatkhau.Text.ToString())
                {
                    MessageBox.Show("Tài khoản và Mật khẩu không chính xác. Vui lòng kiểm tra lại!!!");
                    txtTaikhoan.ResetText();
                    txtMatkhau.ResetText();
                    txtTaikhoan.Focus();
                }
            }
            catch
            {
              
            }
            
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn chắc muốn thoát khỏi đăng nhập", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(traloi == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtTaikhoan.ResetText();
                txtMatkhau.ResetText();
                txtTaikhoan.Focus();
            }
        }
    }
}
