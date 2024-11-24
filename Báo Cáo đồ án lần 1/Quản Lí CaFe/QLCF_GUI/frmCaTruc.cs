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
            Loadcatruc();
            Loadnhanvien();
            Loadtrangthai();    
            LoadDataGridView(); 
            txt_IDLictruc.Text = string.Empty;
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
        private void dTNgayTruc_ValueChanged(object sender, EventArgs e)
        {
            string ma = "LT";
            string ddmmyy = dTNgayTruc.Value.ToString("ddMMyy");
            string ca = cboTenCa.SelectedValue.ToString();
            txt_IDLictruc.Text = ma + ddmmyy + ca;
        }

        private void cboTenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = "LT";
            string ddmmyy = dTNgayTruc.Value.ToString("ddMMyy");
            string ca = cboTenCa.SelectedValue.ToString();
            txt_IDLictruc.Text = ma + ddmmyy + ca;
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgvLichTruc.CurrentRow != null)
            {
                LichTrucDTO lichTruc = new LichTrucDTO
                {
                    IdLichTruc = dgvLichTruc.CurrentRow.Cells["IdLichTruc"].Value.ToString(),
                    CaLam = cboTenCa.SelectedValue.ToString(),
                    MaNhanVien = cboIDNhanVien.SelectedValue.ToString(),
                    TenNhanVien = cboIDNhanVien.SelectedText.ToString(),
                    NgayTruc = dTNgayTruc.Value,
                    TrangThai = cbo_TrangThai.SelectedValue.ToString()
                };

                LichTrucBLL bll = new LichTrucBLL();
                bool isUpdated = bll.UpdateLichTruc(lichTruc);

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
        }
    }
}
