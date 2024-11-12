using QLCF_DAL;
using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_BLL
{
    public class ChucVuBLL
    {
        ChucVuDAL chucvuDAL = new ChucVuDAL();
        public bool insert(ChucVuDTO chucvu)
        {
            bool KiemTra = chucvuDAL.isExists(chucvu.IDChucVu);
            if (KiemTra == true)
                return false;
            else
            {
                return chucvuDAL.insert(chucvu);
            }
        }
        public bool delete(ChucVuDTO chucvu)
        {
            bool KiemTra = chucvuDAL.isExists(chucvu.IDChucVu);
            if (KiemTra == true)
                return chucvuDAL.delete(chucvu);

            else
            {
                return false;
            }
        }
        public bool edit(ChucVuDTO chucvu)
        {
            bool KiemTra = chucvuDAL.isExists(chucvu.IDChucVu);
            if (KiemTra == true)
                return chucvuDAL.edit(chucvu);

            else
            {
                return false;
            }
        }
        public List<ChucVuDTO> getALL()
        {
            return chucvuDAL.getALL();
        }
    }
}
