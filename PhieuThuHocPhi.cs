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
    public partial class PhieuThuHocPhi : Form
    {
        DA_phieuthu dbPT = new DA_phieuthu();
        DA_nhanvien dbNV = new DA_nhanvien();
        DA_hocvien dbHV = new DA_hocvien();
        DataTable dt = new DataTable();
        public PhieuThuHocPhi()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dt = dbPT.getphieuthu().Tables[0];
                      
            cbx_khoahoc.DataSource = dbPT.getkhoahoc().Tables[0];
            cbx_khoahoc.DisplayMember = "TenKH";
            cbx_khoahoc.ValueMember = "MaKH";
            cbx_nguoinop.DataSource = dbHV.gethocvien().Tables[0];
            cbx_nguoinop.DisplayMember = "TenHocVien";
            cbx_nguoinop.ValueMember = "MaHocVien";
            cbx_nguoithu.DataSource = dbNV.getnhanvien().Tables[0];
            cbx_nguoithu.DisplayMember = "TenNV";
            cbx_nguoithu.ValueMember = "MaNV";
            dataGridView1.DataSource = dt;
            
            txt_lido.DataBindings.Clear();
            txt_sophieu.DataBindings.Clear();
            txt_sotien.DataBindings.Clear();
            
            cbx_khoahoc.DataBindings.Clear();
            cbx_lophoc.DataBindings.Clear();
            cbx_nguoinop.DataBindings.Clear();
            cbx_nguoithu.DataBindings.Clear();


            txt_lido.DataBindings.Add("Text", dt, "KhoanThu");
            txt_sophieu.DataBindings.Add("Text", dt, "SoPT");
            txt_sotien.DataBindings.Add("Text", dt, "TienThu");
            cbx_nguoinop.DataBindings.Add("Text", dt, "MaHV");
            cbx_nguoithu.DataBindings.Add("Text", dt, "NguoiThu");




        }
        private void btn_Lamlai_Click(object sender, EventArgs e)
        {
                       
            txt_lido.Clear();
            txt_sophieu.Clear();
            txt_sotien.Clear();
            
        }
        private void btn_Trove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string err = "";
            if ((!dbPT.insertPT(ref err, txt_sophieu.Text.ToString(), cbx_nguoithu.SelectedValue.ToString(), date_Ngaythu.Text, txt_lido.Text.ToString(), double.Parse(txt_sotien.Text.ToString()), cbx_nguoinop.SelectedValue.ToString()))
                || (!dbHV.suahocphi(ref err, cbx_nguoinop.SelectedValue.ToString(), double.Parse(txt_sotien.Text.ToString()))))
                MessageBox.Show(err);
            else {

                DataBind();MessageBox.Show("Them thanh cong");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            
        }

        private void PhieuThuHocPhi_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void cbx_khoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_lophoc.DataSource = dbHV.getlophoc(cbx_khoahoc.SelectedValue.ToString()).Tables[0];
            cbx_lophoc.DisplayMember = "TenLH";
            cbx_lophoc.ValueMember = "MaLH";
        }

        private void cbx_lophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_nguoinop.DataSource = dbHV.gethocvien2(cbx_lophoc.SelectedValue.ToString()).Tables[0];
            cbx_nguoinop.DisplayMember = "TenHocVien";
            cbx_nguoinop.ValueMember = "MaHocVien";
        }
    }
}
