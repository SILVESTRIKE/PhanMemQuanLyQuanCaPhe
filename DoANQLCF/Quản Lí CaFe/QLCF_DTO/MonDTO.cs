using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
   public class MonDTO
    {
        public string IDMon { get; set; }
        public string TenMon { get; set; }
        public decimal gia { get; set; }
        public string loai {  get; set; }
        public MonDTO() {}

        public MonDTO(string idMon, string tenMon, decimal price, string Loai)
        {
            IDMon = idMon;
            TenMon = tenMon;
            gia = price;
            loai = Loai;
        }
    }
}
