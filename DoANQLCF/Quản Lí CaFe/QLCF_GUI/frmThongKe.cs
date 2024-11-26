using QLCF_BLL;
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
    public partial class frmThongKe : Form
    {
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKeNgay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dTNgayKT.Value;

            // Thống kê theo ngày
            var dailyInvoices = hoaDonBLL.GetHoaDonByDate(selectedDate);
            var dailyRevenue = hoaDonBLL.GetTotalRevenueByDate(selectedDate);
            var dailyCount = hoaDonBLL.GetHoaDonCountByDate(selectedDate);

            // Hiển thị dữ liệu lên DataGridView
            dgVThongKe.DataSource = dailyInvoices;

            // Hiển thị tổng tiền
            lblDoanhThu.Text = $"Tổng tiền trong ngày: {dailyRevenue:C}";
            lblSoLuong.Text = $"Số lượng hóa đơn trong ngày: {dailyCount:C}";


        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dTNgayKT.Value;

            // Thống kê theo tháng
            var monthlyInvoices = hoaDonBLL.GetHoaDonByMonth(selectedDate.Month, selectedDate.Year);
            var monthlyRevenue = hoaDonBLL.GetTotalRevenueByMonth(selectedDate.Month, selectedDate.Year);
            var monthCount = hoaDonBLL.GetHoaDonCountByMonth(selectedDate.Month, selectedDate.Year);

            // Hiển thị dữ liệu lên DataGridView
            dgVThongKe.DataSource = monthlyInvoices;

            // Hiển thị tổng tiền
            lblDoanhThu.Text = $"Tổng tiền trong tháng: {monthlyRevenue:C}";
            lblSoLuong.Text = $"Số lượng hóa đơn trong ngày: {monthCount:C}";


        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // Cài đặt DataGridView ban đầu
            dgVThongKe.AutoGenerateColumns = false;
            dgVThongKe.Columns.Add("IDHoaDon", "Mã Hóa Đơn");
            dgVThongKe.Columns.Add("NgayLap", "Ngày Lập");
            dgVThongKe.Columns.Add("IDNhanVien", "Mã Nhân Viên");
            dgVThongKe.Columns.Add("TongTien", "Tổng Tiền");

            dgVThongKe.Columns["IDHoaDon"].DataPropertyName = "IDHoaDon";
            dgVThongKe.Columns["NgayLap"].DataPropertyName = "NgayLap";
            dgVThongKe.Columns["IDNhanVien"].DataPropertyName = "IDNhanVien";
            dgVThongKe.Columns["TongTien"].DataPropertyName = "TongTien";

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var allInvoices = hoaDonBLL.GetAllLichTruc();
            dgVThongKe.DataSource = allInvoices;
        }
    }
}
