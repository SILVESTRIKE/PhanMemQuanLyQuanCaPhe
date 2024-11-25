using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
   public class CongThucDTO
    {
        public string IDMon { get; set; }
        public string IDNguyenLieu { get; set; }
        public decimal SoLuong { get; set; }

        public CongThucDTO() { }

        public CongThucDTO(string idMon, string idNguyenLieu, decimal soLuong)
        {
            IDMon = idMon;
            IDNguyenLieu = idNguyenLieu;
            SoLuong = soLuong;
        }
    }
}
