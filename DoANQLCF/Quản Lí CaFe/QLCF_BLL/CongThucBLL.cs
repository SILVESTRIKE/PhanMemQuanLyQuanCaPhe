using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;

namespace QLCF_BLL
{
    public class CongThucBLL
    {
        private CongThucDAL ctDAL = new CongThucDAL();

        public List<CongThucDTO> GetAllCongThuc()
        {
            return ctDAL.getALL();
        }

        public bool AddCongThuc(CongThucDTO ct)
        {
            return ctDAL.insert(ct);
        }

        public bool UpdateCongThuc(CongThucDTO ct)
        {
            return ctDAL.edit(ct);
        }

        public bool DeleteCongThuc(CongThucDTO ct)
        {
            return ctDAL.delete(ct);
        }
        public List<CongThucDTO> GetCongThucByMon(string idMon)
        {
            return ctDAL.GetCongThucByMon(idMon);
        }

    }
}
