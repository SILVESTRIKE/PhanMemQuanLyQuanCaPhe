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
    public partial class frmHoaDon : Form
    {
        private List<ChiTietHDDTO> ListCTHoaDon;

        public frmHoaDon()
        {
            InitializeComponent();
            ListCTHoaDon = new List<ChiTietHDDTO>(); // Tạo danh sách chi tiết hóa đơn trống
                                                      // Cập nhật UI để người dùng có thể thêm chi tiết hóa đơn
        }
        public frmHoaDon(List<ChiTietHDDTO> chiTietHoaDon)
        {
            InitializeComponent();
            ListCTHoaDon = chiTietHoaDon;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            lblNgay.Text = "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy");

            if (dgVHoaDon.Columns.Count == 0)
            {
                dgVHoaDon.Columns.Add("IDMon", "Mã Món");
                dgVHoaDon.Columns.Add("TenMon", "Tên Món");
                dgVHoaDon.Columns.Add("SoLuong", "Số Lượng");
                dgVHoaDon.Columns.Add("DonGia", "Đơn Giá");
                dgVHoaDon.Columns.Add("ThanhTien", "Thành Tiền");
            }
            if (ListCTHoaDon.Count > 0) 
            {
                foreach (var chiTiet in ListCTHoaDon)
                {
                    dgVHoaDon.Rows.Add(
                        chiTiet.IDMon,
                        chiTiet.SoLuong,
                        chiTiet.DonGia,
                        chiTiet.SoLuong * chiTiet.DonGia
                    );
                }

                // Tính tổng tiền và hiển thị
                decimal tongTien = ListCTHoaDon.Sum(ct => ct.SoLuong * ct.DonGia);
                lblTongTIen.Text = $"Tổng tiền: {tongTien:C}";
            }
            else
            {
                MessageBox.Show("Không có đơn hàng để thanh toán.");
            }
        }
    }
}

