using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;
namespace QLCF_BLL
{
    public class ThongKeDoanhThuBLL
    {
        ThongKeDoanhThuDAL TKDAL = new ThongKeDoanhThuDAL();
        public bool fullBaK()
        {
            return TKDAL.FullBackup();
        }
        public bool diffBaK()
        {
            return TKDAL.DifferentialBackup();
        }
        public bool logBak()
        {
            return TKDAL.TransactionLogBackup();
        }
        public void BackUp()
        {
            TKDAL.BackupDatabase();
        }
    }
}
