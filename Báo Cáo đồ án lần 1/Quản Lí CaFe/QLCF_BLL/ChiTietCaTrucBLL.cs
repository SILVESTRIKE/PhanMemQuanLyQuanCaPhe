using QLCF_DAL;
using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_BLL
{
    public class ChiTietCaTrucBLL
    {
        ChiTietCaTrucDAL chitiecatructDAL = new ChiTietCaTrucDAL();
        public bool insert(ChiTietCaTrucDTO ctcatruc)
        {
            bool KiemTra = chitiecatructDAL.isExists(ctcatruc.IDCa, ctcatruc.IDNhanVien);
            if (KiemTra == true)
                return false;
            else
            {
                return chitiecatructDAL.insert(ctcatruc);
            }
        }
        public bool delete(ChiTietCaTrucDTO ctcatruc)
        {
            bool KiemTra = chitiecatructDAL.isExists(ctcatruc.IDCa, ctcatruc.IDNhanVien);
            if (KiemTra == true)
                return chitiecatructDAL.delete(ctcatruc);

            else
            {
                return false;
            }
        }
        
        public List<ChiTietCaTrucDTO> getALL()
        {
            return chitiecatructDAL.getALL();
        }
    }
}
