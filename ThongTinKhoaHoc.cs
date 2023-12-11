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
    public partial class ThongTinKhoaHoc : Form
    {
        DBKhoaHoc dbkh = null;
        DataTable dtkh = null;
        DataTable dtmh = null;
        DBMonHoc dbmh = null;
        public ThongTinKhoaHoc()
        {
            InitializeComponent();
            dbkh = new DBKhoaHoc();
            dbmh = new DBMonHoc();
        }

        private void ThôngTinKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dtkh = new DataTable();
            dtkh.Clear();
            dtkh = dbkh.LayKhoaHoc().Tables[0];
            dataGridView1.DataSource = dtkh;
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

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadData();
            }
            else
            {
                if (rdMaKhoaHoc.Checked)
                {
                    DataView dtv = new DataView(dtkh);
                    dtv.RowFilter = string.Format("MaKH LIKE '%{0}%'", txtTimKiem.Text);
                    dataGridView1.DataSource = dtv.ToTable();
                }
                if (rdTenKhoaHoc.Checked)
                {
                    DataView dtv = new DataView(dtkh);
                    dtv.RowFilter = string.Format("TenKH LIKE '%{0}%'", txtTimKiem.Text);
                    dataGridView1.DataSource = dtv.ToTable();
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

        private void rdMaKhoaHoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                LoadData();
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
