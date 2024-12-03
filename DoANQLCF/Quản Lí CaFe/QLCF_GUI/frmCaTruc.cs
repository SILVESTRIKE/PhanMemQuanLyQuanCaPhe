using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF_BLL;
using QLCF_DTO;

namespace QLCF_GUI
{
    public partial class frmCaTruc : Form
    {
        CaTrucBLL catruc = new CaTrucBLL();
        NhanVienBLL nhanvien = new NhanVienBLL();


        public frmCaTruc()
        {
            InitializeComponent();

            dgvLichTruc.ReadOnly = true;
            Loadcatruc();
            Loadnhanvien();
            Loadtrangthai();
            LoadDataGridView();
            txt_IDLictruc.Text = string.Empty;

            dgvLichTruc.DefaultCellStyle.Font = new Font("Arial", 16); // Font dữ liệu
            dgvLichTruc.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold); // Font tiêu đề
            dgvLichTruc.RowTemplate.Height = 80; // Đặt chiều cao dòng (đơn vị: pixel)

            // Loại bỏ đường kẻ
            dgvLichTruc.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLichTruc.GridColor = Color.White;

            
        }

        public void Loadcatruc()
        {
            cboTenCa.DataSource = catruc.getALL();
            cboTenCa.DisplayMember = "TenCa";
            cboTenCa.ValueMember = "IDCa";
        }
        public void Loadnhanvien()
        {
            cboIDNhanVien.DataSource = nhanvien.getALL();
            cboIDNhanVien.DisplayMember = "Ten";
            cboIDNhanVien.ValueMember = "IDNhanVien";
        }
        public void Loadtrangthai()
        {
            List<string> list = new List<string>();
            list.Add("Đi làm");
            list.Add("Nghỉ làm");
            cbo_TrangThai.DataSource = list;
        }
        

        private void LoadDataGridView()
        {
            LichTrucBLL bll = new LichTrucBLL();
            List<LichTrucDTO> list = bll.GetAllLichTruc();

            dgvLichTruc.DataSource = list;

            // Thiết lập tên cột hiển thị (nếu cần)
            dgvLichTruc.Columns["IdLichTruc"].HeaderText = "ID Lịch Trực";
            dgvLichTruc.Columns["CaLam"].HeaderText = "Ca Làm";
            dgvLichTruc.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvLichTruc.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvLichTruc.Columns["NgayTruc"].HeaderText = "Ngày Trực";
            dgvLichTruc.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvLichTruc.Columns["IdLichTruc"].Visible = false;  
            if (dgvLichTruc.SelectedRows == null)
            {
                txt_IDLictruc.Text = string.Empty;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LichTrucDTO lichTruc = new LichTrucDTO
            {
                IdLichTruc = txt_IDLictruc.Text,
                CaLam = cboTenCa.SelectedValue.ToString(),
                MaNhanVien = cboIDNhanVien.SelectedValue.ToString(),
                TenNhanVien = cboIDNhanVien.SelectedText.ToString(),
                NgayTruc = dTNgayTruc.Value,
                TrangThai = cbo_TrangThai.SelectedValue.ToString()
            };

            LichTrucBLL bll = new LichTrucBLL();
            bool isSaved = bll.InsertLichTruc(lichTruc);

            if (isSaved)
            {
                MessageBox.Show("Thêm thành công!");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        private void dTNgayTruc_ValueChanged(object sender, EventArgs e)
        {
            // Chỉ tạo ID mới khi thêm lịch trực mới, không áp dụng khi chỉnh sửa
            if (string.IsNullOrEmpty(txt_IDLictruc.Text))
            {
                string ma = "LT";
                string ddmmyy = dTNgayTruc.Value.ToString("ddMMyy");
                string ca = cboTenCa.SelectedValue.ToString();
                string nv = cboIDNhanVien.SelectedValue.ToString();
                txt_IDLictruc.Text = ma + ddmmyy + ca;
            }
        }

        private void cboTenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IDLictruc.Text))
            {
                string ma = "LT";
                string ddmmyy = dTNgayTruc.Value.ToString("ddMMyy");
                string ca = cboTenCa.SelectedValue.ToString();
                string nv = cboIDNhanVien.SelectedValue.ToString();
                txt_IDLictruc.Text = ma + ddmmyy + ca;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgvLichTruc.CurrentRow != null)
            {
                string oldIDLichTruc = dgvLichTruc.CurrentRow.Cells["IdLichTruc"].Value.ToString();

                string newIDLichTruc = "LT" + dTNgayTruc.Value.ToString("ddMMyy") + cboTenCa.SelectedValue.ToString() + cboIDNhanVien.SelectedValue.ToString();

                LichTrucDTO lichTruc = new LichTrucDTO
                {
                    IdLichTruc = oldIDLichTruc, // ID cũ
                    CaLam = cboTenCa.SelectedValue.ToString(),
                    MaNhanVien = cboIDNhanVien.SelectedValue.ToString(),
                    NgayTruc = dTNgayTruc.Value,
                    TrangThai = cbo_TrangThai.SelectedValue.ToString()
                };

                LichTrucBLL bll = new LichTrucBLL();
                bool isUpdated = bll.UpdateLichTruc(lichTruc, newIDLichTruc);

                if (isUpdated)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }



        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgvLichTruc.CurrentRow != null)
            {
                string idLichTruc = dgvLichTruc.CurrentRow.Cells["IdLichTruc"].Value.ToString();
                string idNhanVien = dgvLichTruc.CurrentRow.Cells["MaNhanVien"].Value.ToString();

                LichTrucBLL bll = new LichTrucBLL();
                bool isDeleted = bll.DeleteChiTietLichTruc(idLichTruc, idNhanVien);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void dgvLichTruc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào một hàng hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dgvLichTruc.Rows[e.RowIndex];

                // Điền các giá trị từ hàng vào các điều khiển trên form
                txt_IDLictruc.Text = row.Cells["IdLichTruc"].Value.ToString();
                cboTenCa.SelectedItem = row.Cells["CaLam"].Value.ToString();
                cboIDNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                dTNgayTruc.Value = DateTime.Parse(row.Cells["NgayTruc"].Value.ToString());
                cbo_TrangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
            }
            else if (e.RowIndex == -1)
            {
                dgvLichTruc.ClearSelection();
            }
        }

        private void btn_chialichtruc_Click(object sender, EventArgs e)
        {
            var nv = Session.CurrentUser;
            string idnv = nv.IDNhanVien;

            // Lấy danh sách lịch trực theo ID nhân viên
            LichTrucBLL bll = new LichTrucBLL();
            List<LichTrucDTO> list = bll.GetLichTrucByNhanVien(idnv);

            // Cập nhật DataGridView
            dgvLichTruc.DataSource = list;

            // Thiết lập tên cột hiển thị (nếu cần)
            dgvLichTruc.Columns["IdLichTruc"].HeaderText = "ID Lịch Trực";
            dgvLichTruc.Columns["CaLam"].HeaderText = "Ca Làm";
            dgvLichTruc.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvLichTruc.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvLichTruc.Columns["NgayTruc"].HeaderText = "Ngày Trực";
            dgvLichTruc.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvLichTruc.Columns["IdLichTruc"].Visible = false;
        }

    }
}
