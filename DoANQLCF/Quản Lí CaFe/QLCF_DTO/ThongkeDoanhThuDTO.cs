using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
    public class ThongKeDoanhThuDTO
    {
        public string IDThongke { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal DoanhThu { get; set; }
        public string IDHoaDon { get; set; }

        public ThongKeDoanhThuDTO() { }

        public ThongKeDoanhThuDTO(string idThongke, DateTime ngayLap, decimal doanhThu, string idHoaDon)
        {
            IDThongke = idThongke;
            NgayLap = ngayLap;
            DoanhThu = doanhThu;
            IDHoaDon = idHoaDon;
        }
    }
}
