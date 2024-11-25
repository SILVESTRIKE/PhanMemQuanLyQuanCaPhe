using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;
namespace QLCF_BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL HDDal = new HoaDonDAL();
        public List<HoaDonDTO> GetAllLichTruc()
        {
            return HDDal.getALL();
        }
        public bool InsertHD(HoaDonDTO hoaDon)
        {
            return HDDal.insert(hoaDon);
        }
        public bool DeleteChiTietLichTruc(HoaDonDTO hoadon)
        {
            return HDDal.delete(hoadon);
        }
        public bool UpdateLichTruc(HoaDonDTO hoaDon)
        {
            return HDDal.edit(hoaDon);
        }
        public string IDHoaDon()
        {
            return HDDal.IDHoaDon();
        }
        
    }
}
