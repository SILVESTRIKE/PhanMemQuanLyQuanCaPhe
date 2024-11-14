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
        public string[] GetChucVuOptions()
        {
            return new string[] { "Quản lý", "Nhân viên" };
        }

        public string GetIDQuanLy(string chucVu, string idNhanVien)
        {
            if (chucVu == "Quản lý")
            {
                return idNhanVien; 
            }
            else
            {
                return string.Empty; 
            }
        }

   
        public bool insert(NhanVienDTO nhanvien)
        {
            if (nhanvien.GTinh == "Quản lý" && string.IsNullOrEmpty(nhanvien.IDQuanLy))
            {
                return false; 
            }
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
        public List<string> GetTrangThaiOptions()
        {
            return new List<string>
            {
                "Hoạt động", // Active
                "Nghỉ"       // Inactive
            };
        }
        public List<NhanVienDTO> getALL()
        {
            return NhanVienDAL.getALL();
        }
    }
}
