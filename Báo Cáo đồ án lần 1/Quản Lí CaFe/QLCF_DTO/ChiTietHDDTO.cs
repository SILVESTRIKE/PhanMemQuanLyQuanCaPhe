using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
    public class ChiTietHDDTO
    {
        public string IDHoaDon { get; set; }
        public string IDMon { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public ChiTietHDDTO() { }

        public ChiTietHDDTO(string idHoaDon, string idMon, int soLuong, decimal donGia)
        {
            IDHoaDon = idHoaDon;
            IDMon = idMon;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}
