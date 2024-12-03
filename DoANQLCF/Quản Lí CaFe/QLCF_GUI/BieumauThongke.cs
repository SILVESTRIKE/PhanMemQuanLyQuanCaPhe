using QLCF_BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCF_GUI
{
    public partial class BieumauThongke : Form
    {
        public BieumauThongke()
        {
            InitializeComponent();
        }

        // Phương thức lấy dữ liệu từ database
        HoaDonBLL hdbll = new HoaDonBLL();

        private void BieumauThongke_Load(object sender, EventArgs e)
        {
            try
            {
                // Truy vấn dữ liệu và lưu vào DataTable hoặc DataSet
                DataTable dt = hdbll.GetThongKeData(); // Phương thức lấy dữ liệu từ database
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                    return;
                }

                // Tạo đối tượng Crystal Report
                ThongKe report = new ThongKe();
                report.SetDataSource(dt); // Gán DataSource cho report

                // Hiển thị report trên CrystalReportViewer
                crystalReportViewer1.ReportSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }
    }
}
