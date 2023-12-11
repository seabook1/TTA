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
namespace WFQuanLyTrungTamTiengAnh
{
    public partial class QuanLyKhoaHoc : Form
    {
        DBKhoaHoc dbkh = null;
        DataTable dtkh = null;
        DataTable dtmh = null;
        DBMonHoc dbmh = null;
        bool Them;
        public QuanLyKhoaHoc()
        {
            InitializeComponent();
            dbkh = new DBKhoaHoc();
            dbmh = new DBMonHoc();
            groupControl1.Enabled = false;
        }

        private void QuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
     
                dtmh = new DataTable();
                dtmh.Clear();
                dtmh = dbmh.LayMonHoc().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView               

                (dataGridView1.Columns["MonHoc"] as
                DataGridViewComboBoxColumn).DataSource = dtmh;
                (dataGridView1.Columns["MonHoc"] as
                DataGridViewComboBoxColumn).DisplayMember =
                "TenMH";
                (dataGridView1.Columns["MonHoc"] as
                DataGridViewComboBoxColumn).ValueMember =
                "MaMH";


                dtkh = new DataTable();
                dtkh.Clear();
                dtkh = dbkh.LayKhoaHoc().Tables[0];

                dataGridView1.DataSource = dtkh;

                txtMaKhoaHoc.ResetText();
                txtTenKhoaHoc.ResetText();
                cbMonHoc.ResetText();
                txtHocPhi.ResetText();

                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                panel.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTrove.Enabled = true;

            }
            catch (SqlException)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kích hoạt biến Sửa 
                Them = true;
                
                this.cbMonHoc.DataSource = dtmh;
                this.cbMonHoc.DisplayMember = "TenMH";
                this.cbMonHoc.ValueMember = "MaMH";
                // Cho phép thao tác trên Panel 
                // Thứ tự dòng hiện hành 
                int r = dataGridView1.CurrentCell.RowIndex;
                txtMaKhoaHoc.ResetText();
                txtTenKhoaHoc.ResetText();
                cbMonHoc.ResetText();
                txtHocPhi.ResetText();
                // Cho thao tác trên các nút Lưu / Hủy / Panel 
                this.btnLuu.Enabled = true;
                this.btnHuy.Enabled = true;
                this.panel.Enabled = true;
                // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTrove.Enabled = false;
                btnTimKiem.Enabled = false;
                // Đưa con trỏ đến TextField txtMaKH            
                this.txtMaKhoaHoc.Focus();
            }
            catch (Exception)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Đưa dữ liệu lên ComboBox 
            this.cbMonHoc.DataSource = dtmh;
            this.cbMonHoc.DisplayMember = "TenMH";
            this.cbMonHoc.ValueMember = "MaMH";
            // Cho phép thao tác trên Panel 
            // Thứ tự dòng hiện hành 
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaKhoaHoc.Text =
            dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtTenKhoaHoc.Text =
            dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.cbMonHoc.SelectedValue =
            dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtHocPhi.Text =
            dataGridView1.Rows[r].Cells[3].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTrove.Enabled = false;
            btnTimKiem.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH            
            this.txtMaKhoaHoc.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strMAKH =
                dataGridView1.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                string err = "";
                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = dbkh.XoaKhoaHoc(ref err, strMAKH);
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
                    }
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
               // MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            txtMaKhoaHoc.ResetText();
            txtTenKhoaHoc.ResetText();
            cbMonHoc.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTrove.Enabled = true;
            btnTimKiem.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel.Enabled = false;
            dataGridView1_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            if (Them)
            {
                try
                {

                    // Lệnh Insert InTo 
                    bool f = dbkh.ThemKhoaHoc(ref err,
                    this.txtMaKhoaHoc.Text.ToString(),
                    this.txtTenKhoaHoc.Text.ToString(),
                    this.cbMonHoc.SelectedValue.ToString(),
                    double.Parse(this.txtHocPhi.Text.ToString()));
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm chưa xong!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else // Sua du lieu
            {
                try
                {

                    // Lệnh Insert InTo 
                    bool f = dbkh.CapNhatKhoaHoc(ref err,
                    this.txtMaKhoaHoc.Text.ToString(),
                    this.txtTenKhoaHoc.Text.ToString(),
                    this.cbMonHoc.SelectedValue.ToString(),
                    double.Parse(this.txtHocPhi.Text.ToString()));
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không cập nhật được. Lỗi rồi!");
                }
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK) this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaKhoaHoc.Text =
            dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtTenKhoaHoc.Text =
            dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.cbMonHoc.SelectedValue =
            dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtHocPhi.Text =
            dataGridView1.Rows[r].Cells[3].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(groupControl1.Enabled==false)
            {
                groupControl1.Enabled = true;
                panel.Enabled = true;
                txtMaKhoaHoc.ResetText();
                txtTenKhoaHoc.ResetText();
                cbMonHoc.ResetText();
                txtHocPhi.ResetText();
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            else
            {
                groupControl1.Enabled = false;
                panel.Enabled = false;
                txtMaKhoaHoc.ResetText();
                txtTenKhoaHoc.ResetText();
                cbMonHoc.ResetText();
                txtHocPhi.ResetText();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnTimKiem.Enabled = false;

            }
        }

        private void txtMaKhoaHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdMaKhoaHoc.Checked)
                {

                    DataView dtv = new DataView(dtkh);
                    dtv.RowFilter = string.Format("MaKH LIKE '%{0}%'", txtMaKhoaHoc.Text);
                    dataGridView1.DataSource = dtv.ToTable();
                }
            }
            catch
            {
                LoadData();
            }
        }

        private void txtTenKhoaHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdTenKhoaHoc.Checked)
                {

                    DataView dtv = new DataView(dtkh);
                    dtv.RowFilter = string.Format("TenKH LIKE '%{0}%'", txtTenKhoaHoc.Text);
                    dataGridView1.DataSource = dtv.ToTable();
                }
            }
            catch
            {
                LoadData();
            }
        }

        private void rdMaKhoaHoc_CheckedChanged(object sender, EventArgs e)
        {
            txtTenKhoaHoc.Enabled = false;
            cbMonHoc.Enabled = false;
            txtHocPhi.Enabled=false;
            txtMaKhoaHoc.Enabled = true;
        }

        private void rdTenKhoaHoc_CheckedChanged(object sender, EventArgs e)
        {
            txtTenKhoaHoc.Enabled = true;
            txtMaKhoaHoc.Enabled = false;
            txtHocPhi.Enabled = false;
            cbMonHoc.Enabled = false;
        }

    }
}
