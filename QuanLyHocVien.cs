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
    public partial class QuanLyHocVien : Form
    {
        DA_hocvien dbHV = new DA_hocvien();
        DataSet dsHV = new DataSet();
        DataSet dsLop = new DataSet();
        DataSet dsKhoa = new DataSet();
        int viec;
        
        private void DataBind()
        {
            dsHV = dbHV.gethocvien();
            dsLop = dbHV.getlophoc2();
            dsKhoa = dbHV.getkhoahoc();

            //dsd = dbd.getChitietDv();
            //dsdv = dbdv.getDichVu();
            cbx2.DataSource = dsKhoa.Tables[0];
            cbx2.DisplayMember = "TenKH";
            cbx2.ValueMember = "MaKH";
            
            string[] g = new string[2];
            g[0] = "Nam"; g[1] = "Nữ";
            cbxgender.DataSource = g;
            dataGridView1.DataSource = dsHV.Tables[0];
            textEdit1.DataBindings.Clear();
            textEdit10.DataBindings.Clear();
            cbxgender.DataBindings.Clear();
            textEdit3.DataBindings.Clear();
            textEdit9.DataBindings.Clear();
            cbx1.DataBindings.Clear();
            cbx2.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            txtno.DataBindings.Clear();
            txtcm.DataBindings.Clear();
            txtmail.DataBindings.Clear();
            textEdit1.DataBindings.Add("Text", dsHV.Tables[0], "TenHocVien");
            textEdit10.DataBindings.Add("Text", dsHV.Tables[0], "MaHocVien");
            cbxgender.DataBindings.Add("Text", dsHV.Tables[0], "GioiTinh");
            textEdit3.DataBindings.Add("Text", dsHV.Tables[0], "DChi");
            textEdit9.DataBindings.Add("Text", dsHV.Tables[0], "SDT");
            cbx1.DataBindings.Add("Text", dsHV.Tables[0], "LopHoc");
            txtno.DataBindings.Add("Text", dsHV.Tables[0], "NoHocPhi");
            txtcm.DataBindings.Add("Text", dsHV.Tables[0], "CMND");
            txtmail.DataBindings.Add("Text", dsHV.Tables[0], "Email");
        }
        private void DataBindS_id(string id)
        {
            dsHV = dbHV.timHV_id(id);
            dsLop = dbHV.getlophoc2();
            dsKhoa = dbHV.getkhoahoc();

            
            cbx2.DataSource = dsKhoa.Tables[0];
            cbx2.DisplayMember = "TenKH";
            cbx2.ValueMember = "MaKH";
            
            string[] g = new string[2];
            g[0] = "Nam"; g[1] = "Nữ";
            cbxgender.DataSource = g;
            dataGridView1.DataSource = dsHV.Tables[0];
            textEdit1.DataBindings.Clear();
            textEdit10.DataBindings.Clear();
            cbxgender.DataBindings.Clear();
            textEdit3.DataBindings.Clear();
            textEdit9.DataBindings.Clear();
            cbx1.DataBindings.Clear();
            cbx2.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            txtno.DataBindings.Clear();
            txtcm.DataBindings.Clear();
            txtmail.DataBindings.Clear();
            textEdit1.DataBindings.Add("Text", dsHV.Tables[0], "TenHocVien");
            textEdit10.DataBindings.Add("Text", dsHV.Tables[0], "MaHocVien");
            cbxgender.DataBindings.Add("Text", dsHV.Tables[0], "GioiTinh");
            textEdit3.DataBindings.Add("Text", dsHV.Tables[0], "DChi");
            textEdit9.DataBindings.Add("Text", dsHV.Tables[0], "SDT");
            cbx1.DataBindings.Add("Text", dsHV.Tables[0], "LopHoc");
            txtno.DataBindings.Add("Text", dsHV.Tables[0], "NoHocPhi");
            txtcm.DataBindings.Add("Text", dsHV.Tables[0], "CMND");
            txtmail.DataBindings.Add("Text", dsHV.Tables[0], "Email");
        }
        private void DataBindS_name(string name)
        {
            dsHV = dbHV.timHV_name(name);
            dsLop = dbHV.getlophoc2();
            dsKhoa = dbHV.getkhoahoc();
            string[] g = new string[2];
            g[0] = "Nam"; g[1] = "Nữ";
            cbxgender.DataSource = g;

            cbx2.DataSource = dsKhoa.Tables[0];
            cbx2.DisplayMember = "TenKH";
            cbx2.ValueMember = "MaKH";
            

            dataGridView1.DataSource = dsHV.Tables[0];
            textEdit1.DataBindings.Clear();
            textEdit10.DataBindings.Clear();
            cbxgender.DataBindings.Clear();
            textEdit3.DataBindings.Clear();
            textEdit9.DataBindings.Clear();
            cbx1.DataBindings.Clear();
            cbx2.DataBindings.Clear();
            dateEdit1.DataBindings.Clear();
            txtno.DataBindings.Clear();
            txtcm.DataBindings.Clear();
            txtmail.DataBindings.Clear();
            textEdit1.DataBindings.Add("Text", dsHV.Tables[0], "TenHocVien");
            textEdit10.DataBindings.Add("Text", dsHV.Tables[0], "MaHocVien");
            cbxgender.DataBindings.Add("Text", dsHV.Tables[0], "GioiTinh");
            textEdit3.DataBindings.Add("Text", dsHV.Tables[0], "DChi");
            textEdit9.DataBindings.Add("Text", dsHV.Tables[0], "SDT");
            cbx1.DataBindings.Add("Text", dsHV.Tables[0], "LopHoc");
            txtno.DataBindings.Add("Text", dsHV.Tables[0], "NoHocPhi");
            txtcm.DataBindings.Add("Text", dsHV.Tables[0], "CMND");
            txtmail.DataBindings.Add("Text", dsHV.Tables[0], "Email");
        }




        public QuanLyHocVien()
        {
            InitializeComponent();
           // txtTimkiem.Visible = false;
        }


        static int tthai = -1;
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(tthai == -1) {
                pal_main.Enabled = true;
                textEdit1.Text = "";
                textEdit10.Text = "";
                cbxgender.Text = "";
                textEdit3.Text = "";
                textEdit9.Text = "";
                txtcm.Clear();
                txtmail.Clear();
                txtno.Clear();
                
                
                DataBind();
                groupControl1.Enabled = true;
                tthai = tthai * -1;
            }
            else
            if(tthai == 1)
            {
                pal_main.Enabled = false;
               
                
                groupControl1.Enabled = false;
                tthai = tthai * -1;
                DataBind();
            }

        }
     

        private void QuanLyHocVien_Load(object sender, EventArgs e)
        {
            DataBind();
            pal_main.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            groupControl1.Enabled = false;
        }

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            pal_main.Enabled = true;
            textEdit1.Text = "";
            textEdit10.Text = "";
            cbxgender.Text = "";
            textEdit3.Text = "";
            textEdit9.Text = "";
            txtcm.Clear();
            txtmail.Clear();
            txtno.Clear();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnTrove.Enabled = false;
            dataGridView1.Enabled = false;
            viec = 1;
            
        }

        private void rBMaHV_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void rbTenHV_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            pal_main.Enabled = true;
            
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            pal_main.Enabled = false;

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
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            pal_main.Enabled = false;

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
                if (!dbHV.insertHV(ref err, textEdit10.Text.ToString(), textEdit1.Text.ToString(), dateEdit1.Text, txtcm.Text.ToString(), textEdit9.Text.ToString(), cbxgender.Text.ToString(), cbx1.SelectedValue.ToString(), textEdit3.Text.ToString(), txtmail.Text.ToString(), double.Parse(txtno.Text)))
                    MessageBox.Show(err);
                else {
                    DataBind();
                    MessageBox.Show("Them Thanh cong");
                }
            }
            if(viec == 2)
            {
                if (!dbHV.updateHV(ref err, textEdit10.Text.ToString(), textEdit1.Text.ToString(), dateEdit1.Text, txtcm.Text.ToString(), textEdit9.Text.ToString(), cbxgender.Text.ToString(), cbx1.SelectedValue.ToString(), textEdit3.Text.ToString(), txtmail.Text.ToString(), double.Parse(txtno.Text)))
                    MessageBox.Show(err);
                else
                {
                    DataBind();
                    MessageBox.Show("Sua Thanh cong");
                }
            }
            DataBind();

        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!dbHV.deleteHV(ref err, textEdit10.Text.ToString())) MessageBox.Show(err);
            else
            {
                DataBind();
                MessageBox.Show("Xoa Thanh cong");
            }
        }

        private void cbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx1.DataSource = dbHV.getlophoc(cbx2.SelectedValue.ToString()).Tables[0];
            cbx1.DisplayMember = "TenLH";
            cbx1.ValueMember = "MaLH";

        }

        private void textEdit10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tthai == 1)
            {
                if (rBMaHV.Checked)
                {
                    DataBindS_id(textEdit10.Text.ToString());
                }
                e.Handled = true;
            }
        }

        private void textEdit1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tthai == 1)
            {
                if (rbTenHV.Checked)
                {
                    DataBindS_name(textEdit1.Text.ToString());
                }
                e.Handled = true;
            }
        }
    }
}
