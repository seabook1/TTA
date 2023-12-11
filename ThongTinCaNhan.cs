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
using System.IO;

namespace WFQuanLyTrungTamTiengAnh
{
    public partial class ThongTinCaNhan : Form
    {
        DBTrangChu tr;
        DataTable dttr;
        DA_nhanvien dbnv;
       
        string username;
    
        Byte[] anh = new Byte[0];
        MemoryStream ms;
    
        public ThongTinCaNhan(string user)
        {
            InitializeComponent();
            username = user;
            tr = new DBTrangChu();
            dbnv = new DA_nhanvien();
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            //
            loadData();
            //MessageBox.Show(username);
       
        }
        void loadData()
        {
            try
            {
                dttr = new DataTable();
                dttr.Clear();
                dttr = tr.LayThongTinCN(username).Tables[0];
                //
                txtMaNV.Enabled = false;
                txtTenNV.Enabled = false;
                dNgSinh.Enabled = false;
                txtGTinh.Enabled = false;
                txtCMND.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtChucVu.Enabled = false;
                //
                btnLuu.Enabled = false;
                //
                txtMaNV.Text = dttr.Rows[0][0].ToString();
                txtTenNV.Text = dttr.Rows[0][1].ToString();
                dNgSinh.Text = dttr.Rows[0][2].ToString();
                txtGTinh.Text = dttr.Rows[0][3].ToString();
                txtCMND.Text = dttr.Rows[0][4].ToString();
                txtSDT.Text = dttr.Rows[0][5].ToString();
                txtDiaChi.Text = dttr.Rows[0][6].ToString();
                txtChucVu.Text = dttr.Rows[0][7].ToString();

                anh = (Byte[])(dttr.Rows[0][8]);
                ms = new MemoryStream(anh);
                picAnh.Image = Image.FromStream(ms);
                // this.picAnh.ImeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                MessageBox.Show("con chó");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnTroVe.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnTroVe.Enabled = true;
            string err = "";
            try
            {
                // len insert Into
                bool f = dbnv.CapNhatThongTinCN(ref err, txtMaNV.Text, txtSDT.Text, txtDiaChi.Text);
                if (f)
                {
                    loadData();
                    //
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong!\n\r" + "Lỗi:" + err);
                }
            }
            catch
            {
                //MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
