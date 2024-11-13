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

        public List<CongThucDTO> GetAllMon()
        {
            return ctDAL.getALL();
        }

        public bool AddMon(CongThucDTO ct)
        {
            return ctDAL.insert(ct);
        }

        public bool UpdateMon(CongThucDTO ct)
        {
            return ctDAL.edit(ct);
        }

        public bool DeleteMon(CongThucDTO ct)
        {
            return ctDAL.delete(ct);
        }
    }
}
