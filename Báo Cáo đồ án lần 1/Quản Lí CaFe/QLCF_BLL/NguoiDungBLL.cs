using QLCF_DAL;
using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_BLL
{
    public class NguoiDungBLL
    {
        NguoiDungDAL ngdungDAL = new NguoiDungDAL();
        public bool insert(NguoiDungDTO user)
        {
            bool KiemTra = ngdungDAL.isExists(user.IDDN);
            if (KiemTra == true)
                return false;
            else
            {
                return ngdungDAL.insert(user);
            }
        }
        public bool delete(NguoiDungDTO user)
        {
            bool KiemTra = ngdungDAL.isExists(user.IDDN);
            if (KiemTra == true)
                return ngdungDAL.delete(user);

            else
            {
                return false;
            }
        }
        public bool edit(NguoiDungDTO user)
        {
            bool KiemTra = ngdungDAL.isExists(user.IDDN);
            if (KiemTra == true)
                return ngdungDAL.edit(user);

            else
            {
                return false;
            }
        }
        public List<NguoiDungDTO> getALL()
        {
            return ngdungDAL.getALL();
        }

        public bool CheckLogin(NguoiDungDTO user)
        {
            bool KiemTra = ngdungDAL.isExists(user.IDDN);
            if (KiemTra == true)
                return ngdungDAL.CheckLogin(user);

            else
            {
                return false;
            }
        }
    }
}
