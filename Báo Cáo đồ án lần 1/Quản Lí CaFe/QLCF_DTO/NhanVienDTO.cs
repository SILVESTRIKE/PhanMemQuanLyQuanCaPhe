using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
   public class NhanVienDTO
    {
        public string IDNhanVien { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string GTinh { get; set; }
        public DateTime NgSinh { get; set; }
        public string IDChucVu { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(string idNhanVien, string ten, string sdt, string gtinh, DateTime ngSinh, string idChucVu)
        {
            IDNhanVien = idNhanVien;
            Ten = ten;
            SDT = sdt;
            GTinh = gtinh;
            NgSinh = ngSinh;
            IDChucVu = idChucVu;
        }
    }
}
