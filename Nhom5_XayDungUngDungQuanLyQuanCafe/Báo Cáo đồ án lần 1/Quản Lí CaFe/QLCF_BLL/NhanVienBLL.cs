using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;
namespace QLCF_BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL NhanVienDAL = new NhanVienDAL();
        public bool insert(NhanVienDTO nhanvien)
        {
            bool KiemTra = NhanVienDAL.isExists(nhanvien.IDNhanVien);
            if (KiemTra == true)
                return false;
            else
            {
                return NhanVienDAL.insert(nhanvien);
            }
        }
        public bool delete(NhanVienDTO nhanvien)
        {
            bool KiemTra = NhanVienDAL.isExists(nhanvien.IDNhanVien);
            if (KiemTra == true)
                return NhanVienDAL.delete(nhanvien);

            else
            {
                return false;
            }
        }
        public bool edit(NhanVienDTO nhanvien)
        {
            bool KiemTra = NhanVienDAL.isExists(nhanvien.IDNhanVien);
            if (KiemTra == true)
                return NhanVienDAL.edit(nhanvien);

            else
            {
                return false;
            }
        }
        public List<NhanVienDTO> getALL()
        {
            return NhanVienDAL.getALL();
        }
    }
}
