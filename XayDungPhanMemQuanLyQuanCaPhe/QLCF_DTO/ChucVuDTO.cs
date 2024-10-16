using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
    public class ChucVuDTO
    {
        public string IDChucVu { get; set; }  // Khóa chính vai trò
        public string Ten { get; set; }       // Tên vai trò (ví dụ: quản lý, nhân viên)

        public ChucVuDTO() { }

        public ChucVuDTO(string idChucVu, string ten)
        {
            IDChucVu = idChucVu;
            Ten = ten;
        }
    }
}
