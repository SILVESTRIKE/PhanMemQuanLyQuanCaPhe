using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
    public class ChiTietCaTrucDTO
    {
        public string IDCa { get; set; }
        public string IDNhanVien { get; set; }

        public ChiTietCaTrucDTO() { }

        public ChiTietCaTrucDTO(string idCa, string idNhanVien)
        {
            IDCa = idCa;
            IDNhanVien = idNhanVien;
        }
    }
}
