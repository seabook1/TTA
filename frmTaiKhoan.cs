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
//

namespace WFQuanLyTrungTamTiengAnh
{
    public partial class frmTaiKhoan : Form
    {
        DBTaiKhoan db;
        DataSet ds = new DataSet();
        DataTable dt;
        DataTable dtnv;
        DA_nhanvien danv;
        bool them;
        string manv;
        public frmTaiKhoan()
        {
            InitializeComponent();
            db = new DBTaiKhoan();
            danv = new DA_nhanvien();
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
        void txtRestext()
        {
            txtTaiKhoan.ResetText();
            txtMatKhau.ResetText();
            txtRole.ResetText();
            cbxMaNV.ResetText();
        }
        void combx()
        {
            dtnv = new DataTable();
            dtnv.Clear();
            dtnv = danv.getnhanvien().Tables[0];
            //
            this.cbxMaNV.DataSource = dtnv;
            this.cbxMaNV.DisplayMember = "HoTen";
            this.cbxMaNV.ValueMember = "MaNV";
        }
        void loadData()
        {
            //
            try
            {
                dtnv = new DataTable();
                dtnv.Clear();
                dtnv = danv.getnhanvien().Tables[0];
                //
              
                dt = new DataTable();
                dt.Clear();
                dt = db.LayTaiKhoan().Tables[0];
                //
                dgvTaiKhoan.DataSource = dt;
                //
                (dgvTaiKhoan.Columns["MaNV"] as
                  DataGridViewComboBoxColumn).DataSource = dtnv;
                (dgvTaiKhoan.Columns["MaNV"] as
                    DataGridViewComboBoxColumn).DisplayMember = "HoTen";
                (dgvTaiKhoan.Columns["MaNV"] as
                    DataGridViewComboBoxColumn).ValueMember = "MaNV";
                txtRestext();
                //
                btnEnable();
                panel1.Enabled = false;
                dgvTaiKhoan_CellClick(null, null);
            }
            catch
            {

            }

        }
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                combx();
                int r = dgvTaiKhoan.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                this.txtTaiKhoan.Text =
                dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();
                this.txtMatKhau.Text =
                dgvTaiKhoan.Rows[r].Cells[1].Value.ToString();

                //this.txtRole.Text =
                //dgvTaiKhoan.Rows[r].Cells[2].Value.ToString();
                this.cbxMaNV.SelectedValue =
                dgvTaiKhoan.Rows[r].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = false;
            txtRole.Enabled = false;
            cbxMaNV.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            
            panel1.Enabled = true;
            combx();
            txtRestext();
            //
            
            btnEnaletrue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            them = false;
            panel1.Enabled = true;
            combx();
            txtTaiKhoan.Enabled = false;

           
            btnEnaletrue();

            // Đưa con trỏ đến TextField txtMKH           
            this.txtTaiKhoan.Focus();
            dgvTaiKhoan_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // lay thu tu record hien hanh
                int r = dgvTaiKhoan.CurrentCell.RowIndex;
                // lay ma ve cua record hien hanh
                string strMaTK = dgvTaiKhoan.Rows[r].Cells[0].Value.ToString();

                //thong bao xoa
                DialogResult thongbao = MessageBox.Show("Ban chac xoa thong tin nay?", "Thong Bao",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                string err = "";
                if (thongbao == DialogResult.OK)
                {
                    // thuc hien cau lenh
                    bool f = db.XoaTaiKhoan(ref err, strMaTK);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtRestext();
            panel1.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            btnEnable();
            dgvTaiKhoan_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            string err = "";
            if (them)
            {
                try
                {
                    // len insert Into
                    bool f = db.ThemTaiKhoan(ref err,
                        this.txtTaiKhoan.Text.ToString(),
                         this.txtMatKhau.Text.ToString(),
                         Int32.Parse(txtRole.Text.ToString()),
                        cbxMaNV.SelectedValue.ToString());
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
                catch (SqlException)
                {
                    //MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else // Sua du lieu
            {
                try
                {

                    // Lệnh Cap nhat 
                    bool f = db.CapNhatTaiKhoan(ref err,
                        this.txtTaiKhoan.Text.ToString(),
                         this.txtMatKhau.Text.ToString(),
                         Int32.Parse(txtRole.Text.ToString()),
                         cbxMaNV.SelectedValue.ToString());
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        loadData();
                        // Thông báo 
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Cap nhat khong thanh con!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    // MessageBox.Show("Không cập nhật được. Lỗi rồi!");
                }
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
