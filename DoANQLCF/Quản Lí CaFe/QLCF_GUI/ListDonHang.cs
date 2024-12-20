﻿using QLCF_BLL;
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
    public partial class ListDonHang : Form
    {
        NhanVienDTO _nv = new NhanVienDTO();

        public ListDonHang()
        {
            InitializeComponent();
            LoadDataGridViewHoaDon();
            dgvChiTietHoaDon.DefaultCellStyle.Font = new Font("Arial", 14); // Font dữ liệu
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); // Font tiêu đề
            dgvChiTietHoaDon.RowTemplate.Height = 80; // Đặt chiều cao dòng (đơn vị: pixel)

            // Loại bỏ đường kẻ
            dgvChiTietHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvChiTietHoaDon.GridColor = Color.White;

            dgVListHoaDon.DefaultCellStyle.Font = new Font("Arial", 12); // Font dữ liệu
            dgVListHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Font tiêu đề
            dgVListHoaDon.RowTemplate.Height = 80; // Đặt chiều cao dòng (đơn vị: pixel)

            // Loại bỏ đường kẻ
            dgVListHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgVListHoaDon.GridColor = Color.White;

            dgvCT.DefaultCellStyle.Font = new Font("Arial", 12); // Font dữ liệu
            dgvCT.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Font tiêu đề
            dgvCT.RowTemplate.Height = 80; // Đặt chiều cao dòng (đơn vị: pixel)

            // Loại bỏ đường kẻ
            dgvCT.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCT.GridColor = Color.White;

        }


        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        private ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
        private CongThucBLL congThucBLL = new CongThucBLL(); 

        private void LoadDataGridViewHoaDon()
        {
            int date = DateTime.Now.Day;
            List<HoaDonDTO> hoaDons = hoaDonBLL.GetAll(date);
            dgVListHoaDon.DataSource = hoaDons;
        }

        private void LoadDataGridViewChiTietHoaDon(string idHoaDon)
        {
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            List<ChiTietHD_CTDTO> chiTietHDs = chiTietHDBLL.GetChiTietHDByHoaDonID(idHoaDon);

            dgvChiTietHoaDon.DataSource = chiTietHDs;

            dgvChiTietHoaDon.Columns["IDHoaDon"].HeaderText = "ID Hóa Đơn";
            dgvChiTietHoaDon.Columns["IDMon"].HeaderText = "ID Món";
            dgvChiTietHoaDon.Columns["TenMon"].HeaderText = "Tên Món";
            dgvChiTietHoaDon.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTietHoaDon.Columns["TinhTrang_PhucVu"].HeaderText = "Tình Trạng Phục Vụ";
        }


        private void dgVListHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgVListHoaDon.Rows[e.RowIndex];
                string idHoaDon = row.Cells["IDHoaDon"].Value.ToString();
                LoadDataGridViewChiTietHoaDon(idHoaDon);
            }
        }

        

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietHoaDon.Rows[e.RowIndex];
                string idMon = row.Cells["IDMon"].Value.ToString();

                List<CongThucDTO> congThucs = congThucBLL.GetCongThucByMon(idMon);
                dgvCT.DataSource = congThucs.Select(ct => new
                {
                    ct.TenMon,
                    ct.TenNguyenLieu,
                    ct.SoLuong,
                    ct.DVTinh
                }).ToList();

                dgvCT.Columns["TenMon"].HeaderText = "Tên Món";
                dgvCT.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
                dgvCT.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvCT.Columns["DVTinh"].HeaderText = "Đơn Vị Tính";
            }
        }

        private void btnLuuGiaTri_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                string idHoaDon = row.Cells["IDHoaDon"].Value.ToString();
                string idMon = row.Cells["IDMon"].Value.ToString();
                bool trangThaiPhucVu = Convert.ToBoolean(row.Cells["TinhTrang_PhucVu"].Value);

                // Gọi phương thức BLL để lưu trạng thái phục vụ
                bool result = chiTietHDBLL.UpdateTrangThaiPhucVu(idHoaDon, idMon, trangThaiPhucVu);

                if (!result)
                {
                    MessageBox.Show("Cập nhật trạng thái phục vụ thất bại cho hóa đơn " + idHoaDon + ", món " + idMon, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Cập nhật trạng thái phục vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
