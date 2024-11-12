using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;
namespace QLCF_BLL
{
    public class MonBLL
    {
        private MonDAL monDAL = new MonDAL();

        public List<MonDTO> GetAllMon()
        {
            return monDAL.getALL();
        }

        public bool AddMon(MonDTO mon)
        {
            return monDAL.insert(mon);
        }

        public bool UpdateMon(MonDTO mon)
        {
            return monDAL.edit(mon);
        }

        public bool DeleteMon(MonDTO mon)
        {
            return monDAL.delete(mon);
        }
    }
}
