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
    public partial class QuanLyLopHoc : Form
    {

        DBLopHoc dblh= null;
        DataTable dtlh = null;
        DBGiangVien dbgv = null;
        DBKhoaHoc dbkh = null;
        DataTable dtgv = null;
        DataTable dtkh = null;
        bool Them;

        public QuanLyLopHoc()
        {
            InitializeComponent();
            dblh = new DBLopHoc();
            dbgv = new DBGiangVien();
            dbkh = new DBKhoaHoc();
        }
        void LoadData()
        {
            try
            {
                dtgv = new DataTable();
                dtgv.Clear();
                dtgv = dblh.LayGiangVien().Tables[0];

                dtkh = new DataTable();
                dtkh.Clear();
                dtkh = dbkh.LayKhoaHoc().Tables[0];
                // Đưa dữ liệu lên ComboBox trong DataGridView  
                (dataGridView1.Columns["GiangVien"] as
                DataGridViewComboBoxColumn).DataSource = dtgv;
                (dataGridView1.Columns["GiangVien"] as
                DataGridViewComboBoxColumn).DisplayMember =
                "TenGiangVien";
                (dataGridView1.Columns["GiangVien"] as
                DataGridViewComboBoxColumn).ValueMember =
                "MaGiangVien";

                (dataGridView1.Columns["KhoaHoc"] as
                DataGridViewComboBoxColumn).DataSource = dtkh;
                (dataGridView1.Columns["KhoaHoc"] as
                DataGridViewComboBoxColumn).DisplayMember =
                "TenKH";
                (dataGridView1.Columns["KhoaHoc"] as
                DataGridViewComboBoxColumn).ValueMember =
                "MaKH";


                dtlh = new DataTable();
                dtlh.Clear();
                dtlh = dblh.LayLopHoc().Tables[0];

                dataGridView1.DataSource = dtlh;
                txtMaLopHoc.ResetText();
                txtTenLopHoc.ResetText();
                txtSoHocVien.ResetText();
                txtDiaChi.ResetText();
                cbTenKhoaHoc.ResetText();

                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                panel.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTrove.Enabled = true;

            }
            catch(SqlException)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kích hoạt biến Sửa 
                Them = true;
                // Đưa dữ liệu lên ComboBox 
                this.cbTenGiangVien.DataSource = dtgv;
                this.cbTenGiangVien.DisplayMember = "TenGiangVien";
                this.cbTenGiangVien.ValueMember = "MaGiangVien";


                this.cbTenKhoaHoc.DataSource = dtkh;
                this.cbTenKhoaHoc.DisplayMember = "TenKH";
                this.cbTenKhoaHoc.ValueMember = "MaKH";
                // Cho phép thao tác trên Panel 
                // Thứ tự dòng hiện hành 
                int r = dataGridView1.CurrentCell.RowIndex;
                txtMaLopHoc.ResetText();
                txtTenLopHoc.ResetText();
                dataGridView1.ResetText();
                txtSoHocVien.ResetText();
                txtDiaChi.ResetText();
                cbTenKhoaHoc.ResetText();
                // Cho thao tác trên các nút Lưu / Hủy / Panel 
                this.btnLuu.Enabled = true;
                this.btnHuy.Enabled = true;
                this.panel.Enabled = true;
                // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTrove.Enabled = false;
                // Đưa con trỏ đến TextField txtMaKH            
                this.txtMaLopHoc.Focus();
            }
            catch(Exception)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Đưa dữ liệu lên ComboBox 
            this.cbTenGiangVien.DataSource = dtgv;
            this.cbTenGiangVien.DisplayMember = "TenGiangVien";
            this.cbTenGiangVien.ValueMember = "MaGiangVien";


            this.cbTenKhoaHoc.DataSource = dtkh;
            this.cbTenKhoaHoc.DisplayMember = "TenKH";
            this.cbTenKhoaHoc.ValueMember = "MaKH";
            // Cho phép thao tác trên Panel 
            // Thứ tự dòng hiện hành 
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaLopHoc.Text =
            dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtTenLopHoc.Text =
            dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtSoHocVien.Text =
            dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.dtpNgayBatDau.Text =
            dataGridView1.Rows[r].Cells[4].Value.ToString();
            this.dtpNgayKetThuc.Text =
            dataGridView1.Rows[r].Cells[5].Value.ToString();
            this.cbTenKhoaHoc.SelectedValue =
            dataGridView1.Rows[r].Cells[6].Value.ToString();
            this.cbTenGiangVien.SelectedValue =
            dataGridView1.Rows[r].Cells[7].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTrove.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH            
            this.txtMaLopHoc.Focus();
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
                    bool f = dblh.XoaLopHoc(ref err, strMAKH);
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
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            txtMaLopHoc.ResetText();
            txtTenLopHoc.ResetText();
            dataGridView1.ResetText();
            txtSoHocVien.ResetText();
            txtDiaChi.ResetText();
            cbTenKhoaHoc.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTrove.Enabled = true;
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
                    bool f = dblh.ThemLopHoc(ref err,
                    this.txtMaLopHoc.Text.ToString(),
                    this.txtTenLopHoc.Text.ToString(),
                    this.txtDiaChi.Text.ToString(),
                    int.Parse(this.txtSoHocVien.Text.ToString()),
                    DateTime.Parse(this.dtpNgayBatDau.Text.ToString()),
                    DateTime.Parse(this.dtpNgayKetThuc.Text.ToString()),
                    this.cbTenKhoaHoc.SelectedItem.ToString(),
                    this.cbTenGiangVien.SelectedItem.ToString());
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
                    bool f = dblh.CapNhatLopHoc(ref err,
                    this.txtMaLopHoc.Text.ToString(),
                    this.txtTenLopHoc.Text.ToString(),
                    this.txtDiaChi.Text.ToString(),
                    int.Parse(this.txtSoHocVien.Text.ToString()),
                    DateTime.Parse(this.dtpNgayBatDau.Text.ToString()),
                    DateTime.Parse(this.dtpNgayKetThuc.Text.ToString()),
                    this.cbTenKhoaHoc.SelectedItem.ToString(),
                    this.cbTenGiangVien.SelectedItem.ToString());
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

        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaLopHoc.Text =
            dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtTenLopHoc.Text =
            dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtSoHocVien.Text =
            dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.dtpNgayBatDau.Text =
            dataGridView1.Rows[r].Cells[4].Value.ToString();
            this.dtpNgayKetThuc.Text =
            dataGridView1.Rows[r].Cells[5].Value.ToString();
            this.cbTenKhoaHoc.Text =
            dataGridView1.Rows[r].Cells[6].Value.ToString();
            this.cbTenGiangVien.Text =
            dataGridView1.Rows[r].Cells[7].Value.ToString();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text=="")
            {
                LoadData();
            }
            else
            {
                if (rdMaLop.Checked)
                {
                    DataView dtv = new DataView(dtlh);
                    dtv.RowFilter = string.Format("MaLH LIKE '%{0}%'", txtTimKiem.Text);
                    dataGridView1.DataSource = dtv.ToTable();
                }
                if(rdTenLopHoc.Checked)
                {
                    DataView dtv = new DataView(dtlh);
                    dtv.RowFilter = string.Format("TenLH LIKE '%{0}%'", txtTimKiem.Text);
                    dataGridView1.DataSource = dtv.ToTable();
                }
            }
        }
    }
}
