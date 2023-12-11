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
    public partial class ThongTinLopHoc : Form
    {
        DBLopHoc dblh = null;
        DataTable dtlh = null;
        DBGiangVien dbgv = null;
        DBKhoaHoc dbkh = null;
        DataTable dtgv = null;
        DataTable dtkh = null;
        public ThongTinLopHoc()
        {
            InitializeComponent();
            dblh = new DBLopHoc();
            dbgv = new DBGiangVien();
            dbkh = new DBKhoaHoc();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                LoadData();
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

                btnTrove.Enabled = true;
            }
            catch(Exception)
            {

            }
        }

        private void ThongTinLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadData();
            }
            else
            {
                if (rdMaLopHoc.Checked)
                {
                    DataView dtv = new DataView(dtlh);
                    dtv.RowFilter = string.Format("MaLH LIKE '%{0}%'", txtTimKiem.Text);
                    dataGridView1.DataSource = dtv.ToTable();
                }
                if (rdTenLopHoc.Checked)
                {
                    DataView dtv = new DataView(dtlh);
                    dtv.RowFilter = string.Format("TenLH LIKE '%{0}%'", txtTimKiem.Text);
                    dataGridView1.DataSource = dtv.ToTable();
                }
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnTimKiem.PerformClick();
            }
        }
    }
}
