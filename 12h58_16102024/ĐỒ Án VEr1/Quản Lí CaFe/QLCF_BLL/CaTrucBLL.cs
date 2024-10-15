using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;

namespace QLCF_BLL
{
    public class CaTrucBLL
    {
        CaTrucDAL catrucDAL = new CaTrucDAL();
        public bool insert(CaTrucDTO catruc)
        {
            bool KiemTra = catrucDAL.isExists(catruc.IDCa);
            if (KiemTra == true)
                return false;
            else
            {
                return catrucDAL.insert(catruc);
            }
        }
        public bool delete(CaTrucDTO catruc)
        {
            bool KiemTra = catrucDAL.isExists(catruc.IDCa);
            if (KiemTra == true)
                return catrucDAL.delete(catruc);

            else
            {
                return false;
            }
        }
        public bool edit(CaTrucDTO catruc)
        {
            bool KiemTra = catrucDAL.isExists(catruc.IDCa);
            if (KiemTra == true)
                return catrucDAL.edit(catruc);

            else
            {
                return false;
            }
        }
        public List<CaTrucDTO> getALL()
        {
            return catrucDAL.getALL();
        }
    }
}
