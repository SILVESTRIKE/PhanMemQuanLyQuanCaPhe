using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
    public class CaTrucDTO
    {
        public string IDCa { get; set; }
        public string TenCa { get; set; }

        public CaTrucDTO() { }

        public CaTrucDTO(string idCa, string tenCa)
        {
            IDCa = idCa;
            TenCa = tenCa;

        }
    }
}
