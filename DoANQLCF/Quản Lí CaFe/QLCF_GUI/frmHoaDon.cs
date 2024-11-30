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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLCF_GUI
{
    public partial class frmHoaDon : Form
    {
        public string nv;
        private List<ChiTietHDDTO> ListCTHoaDon;
        ChiTietHDBLL chiTietBLL =new ChiTietHDBLL();
        HoaDonBLL HoaDonbll =new HoaDonBLL();
        //public frmHoaDon()
        //{
        //    InitializeComponent();
        //    ListCTHoaDon = new List<ChiTietHDDTO>();
        //}
        public frmHoaDon(List<ChiTietHDDTO> chiTietHoaDon, string username)
        {
            InitializeComponent();
            this.ListCTHoaDon = chiTietHoaDon;
            nv = username;
        }
        public frmHoaDon(List<ChiTietHDDTO> chiTietHoaDon)
        {
            InitializeComponent();
            this.ListCTHoaDon = chiTietHoaDon;

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            lblNgay.Text = "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy");

            if (dgVHoaDon.Columns.Count == 0)
            {
                dgVHoaDon.Columns.Add("IDMon", "Mã Món");
                dgVHoaDon.Columns.Add("IDHoaDon", "Mã hóa đơn");
                dgVHoaDon.Columns.Add("TenMon", "Tên Món");
                dgVHoaDon.Columns.Add("SoLuong", "Số Lượng");
                dgVHoaDon.Columns.Add("DonGia", "Đơn Giá");
                dgVHoaDon.Columns.Add("TongTien", "Thành Tiền");

            }
            if (ListCTHoaDon != null && ListCTHoaDon.Count > 0) 
            {
                foreach (var chiTiet in ListCTHoaDon)
                {
                    dgVHoaDon.Rows.Add(
                        chiTiet.IDMon,
                        chiTiet.IDHoaDon,
                        chiTietBLL.TenMon(chiTiet.IDMon),
                        chiTiet.SoLuong,
                        chiTiet.DonGia,
                        chiTiet.ThanhTien,
                        chiTiet.TrangThai
                    );
                }

                // Tính tổng tiền và hiển thị
                decimal tongTien = ListCTHoaDon.Sum(ct => ct.ThanhTien);
                lblTongTIen.Text = $"Tổng tiền: {tongTien:C}";
            }
            else
            {
                MessageBox.Show("Không có đơn hàng để thanh toán.");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Tạo hóa đơn mới
            string idHoaDon = HoaDonbll.IDHoaDon();
            HoaDonDTO hoaDon = new HoaDonDTO
            {
                IDHoaDon = idHoaDon,
                NgayLap = DateTime.Now,
                IDNhanVien = nv, 
                TongTien = ListCTHoaDon.Sum(ct => ct.ThanhTien)
            };

            // Cập nhật IDHoaDon trong ListCTHoaDon
            foreach (var chiTiet in ListCTHoaDon)
            {
                chiTiet.IDHoaDon = idHoaDon;
            }

            // Lưu hóa đơn và chi tiết hóa đơn xuống cơ sở dữ liệu
            HoaDonbll.SaveHoaDon(hoaDon, ListCTHoaDon);
            MessageBox.Show("Thanh toán thành công!");

            this.Close();

        }
    }
}

