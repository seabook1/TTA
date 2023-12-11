using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAQuanLyTrungTamTA;
using System.Data.SqlClient;
//

namespace WFQuanLyTrungTamTiengAnh
{
    public partial class DoiPassWord : Form
    {

        string pass;
        string user;
        DBTaiKhoan db;
        DataSet ds = new DataSet();
        string kt;
        public DoiPassWord(string us, string pas)
        {
            InitializeComponent();
            user = us;
            pass = pas;
            db = new DBTaiKhoan();
            
        }
       void restext()
        {
            txtMaKhauMoi.ResetText();
            txtMatKhauConfig.ResetText();
            txtMatKhauCu.ResetText();
            txtMatKhauCu.Focus();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            string err = "";
            try
            {
                ds = db.KiemtraMK(pass);
                kt = ds.Tables[0].Rows[0][0].ToString();
                if (txtMatKhauCu.Text == kt)
                {
                    try
                    {
                        if (txtMaKhauMoi.TextLength.ToString() == txtMatKhauConfig.TextLength.ToString())
                        {
                            bool f = db.CapNhatTaiKhoanNV(ref err, user,
                                txtMaKhauMoi.Text.ToString());
                            if (f)
                            {
                                MessageBox.Show("Sửa mật khẩu thành công!!");
                                restext();
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng kiểm tra lại Pass!!");
                                restext();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kiểm tra lại Mật khẩu mới!!");
                            restext();

                        }
                    }
                    catch
                    {
                        //MessageBox.Show("Lỗi rồi!!");
                    }
                }
            }
            catch
            {

            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            restext();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiPassWord_Load(object sender, EventArgs e)
        {
           
        }
    }
}
