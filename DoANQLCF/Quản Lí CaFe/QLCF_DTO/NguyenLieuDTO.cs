using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
   public class NguyenLieuDTO
    {
        public string IDNguyenLieu { get; set; }
        public string TenNL { get; set; }
        public int SLTon { get; set; }
        public string DVTinh {  get; set; }
        public NguyenLieuDTO() { }

        public NguyenLieuDTO(string idNguyenLieu, string tenNL, int slTon, string dVTinh)
        {
            IDNguyenLieu = idNguyenLieu;
            TenNL = tenNL;
            SLTon = slTon;
            DVTinh = dVTinh;
        }
    }
}
