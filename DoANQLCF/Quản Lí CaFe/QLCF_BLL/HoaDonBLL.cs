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
            return HDDal.GetAll();
        }
        public bool InsertHD(HoaDonDTO hoaDon)
        {
            return HDDal.Insert(hoaDon);
        }
        public bool DeleteChiTietLichTruc(string idhoadon)
        {
            return HDDal.Delete(idhoadon);
        }
        public bool UpdateLichTruc(HoaDonDTO hoaDon)
        {
            return HDDal.Edit(hoaDon);
        }
        public string IDHoaDon()
        {
            return HDDal.GenerateIDHoaDon();
        }
        public bool SaveHoaDon(HoaDonDTO hoaDon, List<ChiTietHDDTO> chiTietList)
        {
            return HDDal.SaveHoaDon(hoaDon, chiTietList);
        }
        public List<HoaDonDTO> GetHoaDonByDate(DateTime date)
        {
            return HDDal.GetHoaDonByDate(date);
        }

        public List<HoaDonDTO> GetHoaDonByMonth(int month, int year)
        {
            return HDDal.GetHoaDonByMonth(month, year);
        }

        public decimal GetTotalRevenueByDate(DateTime date)
        {
            return HDDal.GetTotalRevenueByDate(date);
        }

        public decimal GetTotalRevenueByMonth(int month, int year)
        {
            return HDDal.GetTotalRevenueByMonth(month, year);
        }
        public int GetHoaDonCountByDate(DateTime date)
        {
            return HDDal.GetInvoiceCountByDate(date);
        }

        public int GetHoaDonCountByMonth(int month, int year)
        {
            return HDDal.GetInvoiceCountByMonth(month, year);
        }


    }
}
