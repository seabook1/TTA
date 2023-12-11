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

namespace WFQuanLyTrungTamTiengAnh
{
    public partial class QuanLyNhanVien : Form
    {
        DA_nhanvien dbnv;
        DBTrangChu tr;
        DataTable dt = new DataTable();
        DataTable dtt = new DataTable();
        private int viec;
  
        public QuanLyNhanVien()
        {
            InitializeComponent();
            dbnv = new DA_nhanvien();
            tr = new DBTrangChu();
         
        }
        private void DataBind()
        {
            string[] g = new string[2];
            g[0] = "Nam"; g[1] = "Nữ";
            cbxgender.DataSource = g;
            dt = dbnv.getnhanvien().Tables[0];
            dataGridView1.DataSource = dt;

            txtcm.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtid.DataBindings.Clear();
            txtname.DataBindings.Clear();
            cbxgender.DataBindings.Clear();
            txtchuc.DataBindings.Clear();
            txtdt.DataBindings.Clear();
            txtluong.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            pictureEdit1.DataBindings.Clear();


            txtcm.DataBindings.Add("Text", dt, "CMND");
            txtdiachi.DataBindings.Add("Text", dt, "DChi");
            txtid.DataBindings.Add("Text", dt, "MaNV");
            txtname.DataBindings.Add("Text", dt, "HoTen");
            cbxgender.DataBindings.Add("Text", dt, "GioiTinh");
            txtchuc.DataBindings.Add("Text", dt, "ChucVu");
            txtdt.DataBindings.Add("Text", dt, "SDT");
            txtluong.DataBindings.Add("Text", dt, "Luong");
            dateEdit1.DataBindings.Add("Text", dt, "NgSinh");
            pictureEdit1.DataBindings.Add("Image", dt, "HinhAnh",true);
        }
        private void DataBindS_id(string id)
        {
            string[] g = new string[2];
            g[0] = "Nam"; g[1] = "Nữ";
            cbxgender.DataSource = g;
            dt = dbnv.timnhanvien_id(id).Tables[0];
            dataGridView1.DataSource = dt;
            txtcm.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtid.DataBindings.Clear();
            txtname.DataBindings.Clear();
            cbxgender.DataBindings.Clear();
            txtchuc.DataBindings.Clear();
            txtdt.DataBindings.Clear();
            txtluong.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            pictureEdit1.DataBindings.Clear();


            txtcm.DataBindings.Add("Text", dt, "CMND");
            txtdiachi.DataBindings.Add("Text", dt, "DChi");
            txtid.DataBindings.Add("Text", dt, "MaNV");
            txtname.DataBindings.Add("Text", dt, "HoTen");
            cbxgender.DataBindings.Add("Text", dt, "GioiTinh");
            txtchuc.DataBindings.Add("Text", dt, "ChucVu");
            txtdt.DataBindings.Add("Text", dt, "SDT");
            txtluong.DataBindings.Add("Text", dt, "Luong");
            dateEdit1.DataBindings.Add("Text", dt, "NgSinh");
            pictureEdit1.DataBindings.Add("Text", dt, "HinhAnh");
        }
        private void DataBind_name(string name)
        {
            string[] g = new string[2];
            g[0] = "Nam"; g[1] = "Nữ";
            cbxgender.DataSource = g;
            dt = dbnv.timnhanvien_name(name).Tables[0];
            dataGridView1.DataSource = dt;
            txtcm.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtid.DataBindings.Clear();
            txtname.DataBindings.Clear();
            cbxgender.DataBindings.Clear();
            txtchuc.DataBindings.Clear();
            txtdt.DataBindings.Clear();
            txtluong.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            pictureEdit1.DataBindings.Clear();


            txtcm.DataBindings.Add("Text", dt, "CMND");
            txtdiachi.DataBindings.Add("Text", dt, "DChi");
            txtid.DataBindings.Add("Text", dt, "MaNV");
            txtname.DataBindings.Add("Text", dt, "HoTen");
            cbxgender.DataBindings.Add("Text", dt, "GioiTinh");
            txtchuc.DataBindings.Add("Text", dt, "ChucVu");
            txtdt.DataBindings.Add("Text", dt, "SDT");
            txtluong.DataBindings.Add("Text", dt, "Luong");
            dateEdit1.DataBindings.Add("Text", dt, "NgSinh");
            pictureEdit1.DataBindings.Add("Text", dt, "HinhAnh");
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            DataBind();
            panel1.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            groupControl1.Enabled = false;
        }
        static int tthai = -1;
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (tthai == -1)
            {
                panel1.Enabled = true;
                txtcm.Text = "";
                txtdiachi.Text = "";
                txtid.Text = "";
                txtname.Text = "";
                


                DataBind();
                groupControl1.Enabled = true;
                tthai = tthai * -1;
            }
            else
            if (tthai == 1)
            {
                panel1.Enabled = false;


                groupControl1.Enabled = false;
                tthai = tthai * -1;
                DataBind();
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimkiem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnTrove.Enabled = true;
            dataGridView1.Enabled = true;
            string err = "";
            if (viec == 1)
            {
                try
                {
                    txtluong.DataBindings.Clear();
                    Image img = pictureEdit1.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    double t = double.Parse(txtluong.Text.ToString());
                    if (!dbnv.insertNV(ref err, txtid.Text.ToString(),
                        txtname.Text.ToString(),
                        dateEdit1.Text,
                        cbxgender.Text.ToString(),
                        txtcm.Text.ToString(),
                        txtdt.Text.ToString(),
                        txtdiachi.Text.ToString(),
                        t,
                        txtchuc.Text.ToString(),
                        arr
                        ))
                        MessageBox.Show(err);
                    else
                    {
                        DataBind();
                        MessageBox.Show("Them thanh cong");
                    }
                }
                catch
                {
                    MessageBox.Show("Nhập sai rồi","Error",MessageBoxButtons.OK);
                }
                   
            }
            if (viec == 2)
            {
                try
                {
                    Image img = pictureEdit1.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    if (!dbnv.updateNV(ref err, txtid.Text.ToString(),
                        txtname.Text.ToString(),
                        dateEdit1.Text,
                        cbxgender.Text.ToString(),
                        txtcm.Text.ToString(),
                        txtdt.Text.ToString(),
                        txtdiachi.Text.ToString(),
                        double.Parse(txtluong.Text.ToString()),
                        txtchuc.Text.ToString(),
                        arr
                        ))
                        MessageBox.Show(err);
                    else
                    {
                        DataBind();
                        MessageBox.Show("Sua thanh cong");
                    }
                }
                catch
                {
                    MessageBox.Show("Nhập sai rồi", "Error", MessageBoxButtons.OK);
                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimkiem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnTrove.Enabled = true;
            dataGridView1.Enabled = true;
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!dbnv.deleteNV(ref err, txtid.Text.ToString())) MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Xoa thanh cong");
            }
        }
        void clearfrom()
        {
            txtcm.Clear();
            txtdiachi.Clear();
            txtid.Clear();
            txtname.Clear();
            pictureEdit1.Image = null;
            txtluong.Clear();
            txtchuc.Clear();
            txtdt.Clear();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            panel1.Enabled = true;
            
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnTrove.Enabled = false;
            dataGridView1.Enabled = false;
            viec = 1;
            clearfrom();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnlayanh_Click(object sender, EventArgs e)
        {
            ofd.Title = "hinh anh";
            ofd.InitialDirectory = @"Pictures";
            ofd.Filter = "Image|*.png;*.jpg;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureEdit1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnTrove.Enabled = false;
            dataGridView1.Enabled = false;
            viec = 2;
        }

        private void txtid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tthai == 1)
            {
                if (rbtnid.Checked)
                {
                    DataBindS_id(txtid.Text.ToString());
                }
                e.Handled = true;
            }
        }

        private void txtname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tthai == 1)
            {
                if (rbtnname.Checked)
                {
                    DataBind_name(txtname.Text.ToString());
                }
                e.Handled = true;
            }
        }
    }
}
