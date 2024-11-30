using QLCF_BLL;
using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF_GUI
{
    public partial class frmMon : Form
    {
        MonBLL monBLL = new MonBLL();
        private bool KT_DL()
        {
            if (txtmamon.Text == string.Empty)
            {
                MessageBox.Show("Ma mon khong duoc de trong!");
                return false;
            }

            if (txtmamon.Text == string.Empty)
            {
                MessageBox.Show("Ten mon khong duoc de trong!");
                return false;
            }
            decimal price;
            if (txtgia.Text == string.Empty || !decimal.TryParse(txtgia.Text, out price))
            {
                MessageBox.Show("Giá món không hợp lệ!");
                return false;
            }
            return true;
        }
        public frmMon()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string idMon = txtmamon.Text;
                string tenMon = txtTenMon.Text;
                decimal price = Convert.ToDecimal(txtgia.Text);
                string loai = cboLoai.Text;
                MonDTO mon = new MonDTO(idMon, tenMon, price, loai);
                bool kq = monBLL.AddMon(mon);

                if (kq == true)
                {
                    MessageBox.Show("THÊM MÓN THÀNH CÔNG!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("LỖI: Món đã tồn tại hoặc có lỗi xảy ra!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string idMon = txtmamon.Text;
                string tenMon = txtTenMon.Text;
                decimal price = Convert.ToDecimal(txtgia.Text);
                string loai = cboLoai.Text;
                MonDTO mon = new MonDTO(idMon, tenMon, price,loai);
                bool kq = monBLL.UpdateMon(mon);
                if (kq == true)
                {
                    MessageBox.Show("SUA THANH CONG");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                    MessageBox.Show("LOI");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kt = KT_DL();
            if (kt == true)
            {
                string idMon = txtmamon.Text;
                string tenMon = txtTenMon.Text;
                decimal price = Convert.ToDecimal(txtgia.Text);
                string loai = cboLoai.Text;
                MonDTO mon = new MonDTO(idMon, tenMon, price,loai);
                bool kq = monBLL.DeleteMon(mon);


                if (kq == true)
                {
                    MessageBox.Show("XÓA MÓN THÀNH CÔNG!");
                    Load_Grv(); // Cập nhật lại danh sách
                }
                else
                {
                    MessageBox.Show("LỖI: Không thể xóa món!");
                }
            }
        }
        public void Load_CBOLoai()
        {
            List<string> list = new List<string> { "CP", "TR", "ST", "NU" };
            cboLoai.DataSource = list;
        }
        public void Load_Grv()
        {
            MonBLL monBLL = new MonBLL();
            dgVMon.DataSource = monBLL.GetAllMon();

            // Thiết lập tên cột hiển thị và ẩn các cột không cần thiết
            if (dgVMon.Columns["IDMon"] != null)
            {
                dgVMon.Columns["IDMon"].Visible = false;
            }

            if (dgVMon.Columns["TenMon"] != null)
            {
                dgVMon.Columns["TenMon"].HeaderText = "Tên Món";
            }

            if (dgVMon.Columns["Gia"] != null)
            {
                dgVMon.Columns["Gia"].HeaderText = "Giá";
            }

            if (dgVMon.Columns["Loai"] != null)
            {
                dgVMon.Columns["Loai"].HeaderText = "Loại";
            }
        }


        private void frmMon_Load(object sender, EventArgs e)
        {
            Load_Grv();
            Load_CBOLoai();
        }

        
        private void dgVMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem hàng được click có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dgVMon.Rows[e.RowIndex];

                // Cập nhật các TextBox với dữ liệu từ hàng được chọn
                txtTenMon.Text = row.Cells["TenMon"].Value.ToString();
                txtgia.Text = row.Cells["Gia"].Value.ToString();
                txtmamon.Text = row.Cells["IDMon"].Value.ToString();
                cboLoai.Text = row.Cells["Loai"].Value.ToString();
            }
        }
    }
}
