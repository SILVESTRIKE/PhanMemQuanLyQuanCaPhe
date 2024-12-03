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
    public partial class frmKho : Form
    {
        NguyenLieuBLL nglieuBLL = new NguyenLieuBLL();
        NhanVienDTO _nv = new NhanVienDTO();


        private bool KT_DL()
        {
            if (string.IsNullOrEmpty(txtMaNL.Text))
            {
                MessageBox.Show("Mã nguyên liệu không được để trống!");
                return false;
            }

            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Tên nguyên liệu không được để trống!");
                return false;
            }

            decimal slTon;
            if (string.IsNullOrEmpty(cboTon.Text) || !decimal.TryParse(cboTon.Text, out slTon))
            {
                MessageBox.Show("Số lượng tồn phải là số lớn hơn 0!");
                return false;
            }

            return true;
        }

        public frmKho()
        {
            InitializeComponent();
            var nv = Session.CurrentUser;
            dgVNguyenLieu.ReadOnly = true;
            dgVNguyenLieu.DefaultCellStyle.Font = new Font("Arial", 16); // Font dữ liệu
            dgVNguyenLieu.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold); // Font tiêu đề
            dgVNguyenLieu.RowTemplate.Height = 80; // Đặt chiều cao dòng (đơn vị: pixel)

            // Loại bỏ đường kẻ
            dgVNguyenLieu.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgVNguyenLieu.GridColor = Color.White;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KT_DL())
            {
                string idNguyenLieu = "NL" + (dgVNguyenLieu.RowCount + 1).ToString("D3");
                string tenNguyenLieu = txtTen.Text;
                double slTon = double.Parse(cboTon.Text);
                string dvTinh = cboDVT.Text;

                NguyenLieuDTO nguyenLieu = new NguyenLieuDTO(idNguyenLieu, tenNguyenLieu, slTon, dvTinh);
                bool kq = nglieuBLL.AddNguyenLieu(nguyenLieu);

                if (kq)
                {
                    MessageBox.Show("Thêm nguyên liệu thành công!");
                    Load_Grv();
                }
                else
                {
                    MessageBox.Show("Lỗi: Nguyên liệu đã tồn tại hoặc có lỗi xảy ra!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KT_DL())
            {
                DataGridViewRow selectedRow = dgVNguyenLieu.SelectedRows[0];

                string idNguyenLieu = selectedRow.Cells[0].Value.ToString();
                string tenNguyenLieu = txtTen.Text;
                double slTon = double.Parse(cboTon.Text);
                string dvTinh = cboDVT.Text;

                NguyenLieuDTO nguyenLieu = new NguyenLieuDTO(idNguyenLieu, tenNguyenLieu, slTon, dvTinh);
                bool kq = nglieuBLL.UpdateNguyenLieu(nguyenLieu);

                if (kq)
                {
                    MessageBox.Show("Sửa nguyên liệu thành công!");
                    Load_Grv();
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa nguyên liệu!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNL.Text))
            {
                string idNguyenLieu = txtMaNL.Text;
                bool kq = nglieuBLL.DeleteNguyenLieu(new NguyenLieuDTO { IDNguyenLieu = idNguyenLieu });

                if (kq)
                {
                    MessageBox.Show("Xóa nguyên liệu thành công!");
                    Load_Grv();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể xóa nguyên liệu!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu để xóa!");
            }
        }

        public void Load_Grv()
        {
            dgVNguyenLieu.DataSource = nglieuBLL.GetAllNgLieu();
        }

        public void Bindings()
        {
            txtMaNL.DataBindings.Clear();
            txtMaNL.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "IDNguyenLieu");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "TenNL");

            cboTon.DataBindings.Clear();
            cboTon.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "SLTon");

            cboDVT.DataBindings.Clear();
            cboDVT.DataBindings.Add("Text", dgVNguyenLieu.DataSource, "DVTinh");
        }

        public void LoadComboBoxDVT()
        {
            cboDVT.DataSource = nglieuBLL.GetAllNgLieu().Select(nl => nl.DVTinh).Distinct().ToList();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            Load_Grv();
            Bindings();
            LoadComboBoxDVT();

        }

        private void dgVNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem hàng được click có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dgVNguyenLieu.Rows[e.RowIndex];

                // Cập nhật các TextBox và ComboBox với dữ liệu từ hàng được chọn
                txtMaNL.Text = row.Cells["IDNguyenLieu"].Value.ToString();
                txtTen.Text = row.Cells["TenNL"].Value.ToString();
                cboTon.Text = row.Cells["SLTon"].Value.ToString();
                cboDVT.Text = row.Cells["DVTinh"].Value.ToString();
            }
        }

    }
}