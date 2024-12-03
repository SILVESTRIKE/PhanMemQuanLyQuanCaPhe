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
    public partial class BieuMauThanhToan : Form
    {
        HoaDonDTO hd = new HoaDonDTO();
        public BieuMauThanhToan()
        {
            InitializeComponent();
        }
        public BieuMauThanhToan(HoaDonDTO hddto)
        {
            InitializeComponent();
            hd = hddto;
        }
        
        private void BieuMauThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                HoaDon1 hoaDon = new HoaDon1();
                hoaDon.SetDatabaseLogon("sa", "123");

                // Kiểm tra giá trị của tham số trước khi thiết lập
                if (hd != null && !string.IsNullOrEmpty(hd.IDHoaDon))
                {
                    hoaDon.SetParameterValue("IDHoaDon", hd.IDHoaDon);
                }
                else
                {
                    MessageBox.Show("IDHoaDon không hợp lệ.");
                    return;
                }

                crystalReportViewer1.ReportSource = hoaDon;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và ghi log nếu cần
                MessageBox.Show($"Lỗi: {ex.Message}\nStackTrace: {ex.StackTrace}");

            }
        }

    }
}
