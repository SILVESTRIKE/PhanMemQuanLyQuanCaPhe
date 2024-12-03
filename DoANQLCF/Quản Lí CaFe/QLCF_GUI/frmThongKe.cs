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
    public partial class frmThongKe : Form
    {
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();
        private ThongKeDoanhThuBLL tkBLL = new ThongKeDoanhThuBLL();
        NhanVienDTO _nv = new NhanVienDTO();

        public frmThongKe()
        {
            InitializeComponent();
            LoadComboBoxDMY();
            dgVThongKe.ReadOnly = true;
            dgVThongKe.DefaultCellStyle.Font = new Font("Arial", 12); // Font dữ liệu
            dgVThongKe.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Font tiêu đề
            dgVThongKe.RowTemplate.Height = 80; // Đặt chiều cao dòng (đơn vị: pixel)

            // Loại bỏ đường kẻ
            dgVThongKe.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgVThongKe.GridColor = Color.White;

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
            if (cboNgayThangNam.Text == "Ngày")
            {
                DateTime selectedDate = dTNgayKT.Value;

                // Thống kê theo ngày
                var dailyInvoices = hoaDonBLL.GetHoaDonByDate(selectedDate.Day);
                var dailyRevenue = hoaDonBLL.GetTotalRevenueByDate(selectedDate.Day);
                var dailyCount = hoaDonBLL.GetHoaDonCountByDate(selectedDate.Day);

                // Hiển thị dữ liệu lên DataGridView
                dgVThongKe.DataSource = dailyInvoices;

                // Hiển thị tổng tiền
                lblDoanhThu.Text = $"Tổng tiền trong ngày: {dailyRevenue:C}";
                lblSoLuong.Text = $"Số lượng hóa đơn trong ngày: {dailyCount:C}";
            }
            else if (cboNgayThangNam.Text == "Tháng")
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
                lblSoLuong.Text = $"Số lượng hóa đơn trong tháng: {monthCount:C}";
            }
            else
            {
                var allInvoices = hoaDonBLL.GetALL();
                dgVThongKe.DataSource = allInvoices;
            }
            
        }
        public void LoadComboBoxDMY()
        {
            List<string> list = new List<string>()
            {
                "Ngày", "Tháng", "Năm"
            };
            cboNgayThangNam.DataSource = list;
        }

        private void btnThongkeDoanhSoNhanVien_Click(object sender, EventArgs e)
        {
            BieumauThongke a = new BieumauThongke();
            a.Show();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Tự động sao lưu (Full, Diff, Log theo tuần tự)
                tkBLL.BackUp();
                MessageBox.Show("Sao lưu cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
