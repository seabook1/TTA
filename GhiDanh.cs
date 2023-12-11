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
    public partial class GhiDanh : Form
    {
        DA_hocvien dbHV = new DA_hocvien();
        DataSet lop = new DataSet();
        DataSet khoa = new DataSet();
        DBLopHoc dblh;
        public GhiDanh()
        {
            InitializeComponent();
            dblh = new DBLopHoc();
        }

        private void datablind()
        {
            string[] g = new string[2];
            g[0] = "Nam"; g[1] = "Nữ";
            cbxgender.DataSource = g;
            cbxkhoa.DataSource = dbHV.getkhoahoc().Tables[0];
            cbxkhoa.DisplayMember = "TenKH";
            cbxkhoa.ValueMember = "MaKH";
            //
            cbxlop.DataSource = dblh.LayLopHoc().Tables[0];
            cbxlop.DisplayMember = "TenLH";
            cbxlop.ValueMember = "MaLH";

        }
        private void btnLamlai_click(object sender, EventArgs e)
        {
           
            
        }
        private void btnTrove_click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void GhiDanh_Load(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit6.Text = "";
            textEdit8.Text = "";
            datablind();
        }

        private void cbxkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtno.DataSource = dbHV.getkhoahoc2(cbxkhoa.SelectedValue.ToString()).Tables[0];
            txtno.DisplayMember = "HocPhi";
            txtno.ValueMember = "HocPhi";
        }

        private void cbxlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbxlop.DataSource = dbHV.getlophoc(cbxkhoa.SelectedValue.ToString()).Tables[0];
            //cbxlop.DisplayMember = "TenLH";
            //cbxlop.ValueMember = "MaLH";
        }

        private void btnGhidanh_Click_1(object sender, EventArgs e)
        {

            string err = "";
            if (!dbHV.insertHV(ref err, textEdit1.Text.ToString(),
                textEdit2.Text.ToString(),
                dateEdit1.Text, textEdit8.Text.ToString(),
                textEdit6.Text.ToString(), cbxgender.Text.ToString(),
                cbxlop.SelectedValue.ToString(), textEdit4.Text.ToString(),
                textEdit3.Text.ToString(), double.Parse(txtno.Text)))
            MessageBox.Show(err);
            else
            {
                datablind();
                MessageBox.Show("Ghi danh thanh cong");
            }
        }

        private void btnLamlai_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit6.Text = "";
            textEdit8.Text = "";
            datablind();
        }
    }
}
