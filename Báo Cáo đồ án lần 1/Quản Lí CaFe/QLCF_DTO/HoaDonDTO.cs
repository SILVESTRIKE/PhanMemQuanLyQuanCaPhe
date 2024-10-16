using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
    public class HoaDonDTO
    {
        public string IDHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string IDNhanVien { get; set; }
        public decimal ThanhTien { get; set; }

        public HoaDonDTO() {}

        public HoaDonDTO(string idHoaDon, string idNhanVien, DateTime ngayLap,decimal thanhTien)
        {
            IDHoaDon = idHoaDon;
            NgayLap = ngayLap;
            IDNhanVien = idNhanVien;
            ThanhTien = thanhTien;
        }
    }
}
