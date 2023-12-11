using DAQuanLyTrungTamTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFQuanLyTrungTamTiengAnh
{
    public partial class QuanLyGiangVien : Form
    {
        DBGiangVien db;
        DataTable dtgv;
        //
        bool them;
        public QuanLyGiangVien()
        {
            InitializeComponent();
            db = new DBGiangVien();
        }

        void txtResetText()
        {
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtGioiTinh.ResetText();
            txtLuong.ResetText();
            txtMaGV.ResetText();
            txtSDT.ResetText();
            txtTenNV.ResetText();
        }
        void btnEnable()
        {
            //
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //
            btnTimkiem.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimkiem.Enabled = true;
            btnTrove.Enabled = true;
        }
        void btnEnaletrue()
        {
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTrove.Enabled = false;
            btnTimkiem.Enabled = false;
        }
        void loadData()
        {
            try
            {
                dtgv = new DataTable();
                dtgv.Clear();
                dtgv = db.LayGiangVien().Tables[0];
                //
                dgvGiangVien.DataSource = dtgv;
                //
                txtResetText();
                //
                btnEnable();
                panel1.Enabled = false;
                dgvGiangVien_CellClick(null, null);
            }
            catch
            {

            }
            
        }
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            // Xóa trống các đối tượng trong Panel 
            txtResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnEnable();
            dgvGiangVien_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            try
            {
                // lay thu tu record hien hanh
                int r = dgvGiangVien.CurrentCell.RowIndex;
                // lay ma ve cua record hien hanh
                string strMaGV = dgvGiangVien.Rows[r].Cells[0].Value.ToString();

                //thong bao xoa
                DialogResult thongbao = MessageBox.Show("Ban chac xoa thong tin nay?", "Thong Bao",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                string err = "";
                if (thongbao == DialogResult.OK)
                {
                    // thuc hien cau lenh
                    bool f = db.XoaGiangVien(ref err, strMaGV);
                    if (f)
                    {
                        loadData();
                        // thong bao
                        MessageBox.Show("Da xoa xong");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Error" + err);
                    }
                }
                else
                {
                    //MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                //MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            them = false;
            txtMaGV.Enabled = false;
            panel1.Enabled = true;
            // Thứ tự dòng hiện hành 
           
            btnEnaletrue();

            // Đưa con trỏ đến TextField txtMKH           
            this.txtMaGV.Focus();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            panel1.Enabled = true;
            txtResetText();
            txtMaGV.Enabled = true;
            //
            btnEnaletrue();
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtLuong.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
            txtCMND.Enabled = false;
            dNgSinh.Enabled = false;
           
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvGiangVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaGV.Text =
            dgvGiangVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNV.Text =
            dgvGiangVien.Rows[r].Cells[1].Value.ToString();
            this.dNgSinh.Text =
            dgvGiangVien.Rows[r].Cells[2].Value.ToString();
            this.txtGioiTinh.Text =
            dgvGiangVien.Rows[r].Cells[3].Value.ToString();
            this.txtDiaChi.Text =
            dgvGiangVien.Rows[r].Cells[4].Value.ToString();
            this.txtEmail.Text =
           dgvGiangVien.Rows[r].Cells[5].Value.ToString();
            this.txtSDT.Text =
           dgvGiangVien.Rows[r].Cells[6].Value.ToString();
            this.txtCMND.Text =
           dgvGiangVien.Rows[r].Cells[7].Value.ToString();
            this.txtLuong.Text =
           dgvGiangVien.Rows[r].Cells[8].Value.ToString();
        }

        private void txtTenNV_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text != null)

            {
                try
                {
                    dtgv = db.TimKiemGiangVien(txtTenNV.Text).Tables[0];
                    dgvGiangVien.DataSource = dtgv;
                }
                catch
                {
                    loadData();
                    panel1.Enabled = true;
                }
            }

        }

        private void txtMaGV_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text != null)

            {
                try
                {
                    dtgv = db.TimKiemMaGV(txtMaGV.Text).Tables[0];
                    dgvGiangVien.DataSource = dtgv;
                }
                catch
                {
                    loadData();
                    panel1.Enabled = true;
                }
            }
        }

    }
}
