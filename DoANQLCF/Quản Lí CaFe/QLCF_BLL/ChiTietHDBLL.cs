using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;

namespace QLCF_BLL
{
    public class ChiTietHDBLL
    {
        ChiTietHDDAL cthdDAL = new ChiTietHDDAL();
        public bool insert(ChiTietHDDTO cthd)
        {
            bool KiemTra = cthdDAL.isExists(cthd.IDMon, cthd.IDHoaDon);
            if (KiemTra == true)
                return false;
            else
            {
                return cthdDAL.insert(cthd);
            }
        }
        public bool delete(ChiTietHDDTO cthd)
        {
            bool KiemTra = cthdDAL.isExists(cthd.IDMon, cthd.IDHoaDon);
            if (KiemTra == true)
                return cthdDAL.delete(cthd);

            else
            {
                return false;
            }
        }
        public bool edit(ChiTietHDDTO cthd)
        {
            bool KiemTra = cthdDAL.isExists(cthd.IDMon, cthd.IDHoaDon);
            if (KiemTra == true)
                return cthdDAL.edit(cthd);

            else
            {
                return false;
            }
        }
        public List<ChiTietHDDTO> getALL()
        {
            return cthdDAL.getALL();
        }
        public string TenMon(string idMon)
        {
            return cthdDAL.tenMon(idMon);
        }
        public List<ChiTietHD_CTDTO> GetChiTietHDByHoaDonID(string idHoaDon)
        {
            return cthdDAL.GetChiTietHDByHoaDonID(idHoaDon);
        }
        public bool UpdateTrangThaiPhucVu(string idHoaDon, string idMon, bool trangThaiPhucVu)
        {
            return cthdDAL.UpdateTrangThaiPhucVu(idHoaDon, idMon, trangThaiPhucVu);
        }

    }
}
