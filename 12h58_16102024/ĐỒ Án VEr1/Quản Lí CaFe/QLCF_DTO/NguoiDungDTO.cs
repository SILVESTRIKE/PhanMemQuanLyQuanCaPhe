using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DTO
{
    public class NguoiDungDTO
    {
        public string IDDN { get; set; }          // Tên đăng nhập hoặc ID người dùng
        public string Pass { get; set; }          // Mật khẩu người dùng (mã hóa nếu cần)
        //public string Name { get; set; }
        public string IDChucVu { get; set; }      // Khóa ngoại từ bảng ChucVu

        public NguoiDungDTO() { }

        public NguoiDungDTO(string iddn, string pass, string idChucVu)
        {
            IDDN = iddn;
            Pass = pass;
            //Name = name;
            IDChucVu = idChucVu;
        }
    }
}
