using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLCF_DAL
{
    public class HoaDonDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        public HoaDonDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idHoaDon, DateTime ngayLap, string idNhanVien, decimal thanhTien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from HoaDon where IDHoaDon = '" + idHoaDon + "' and IDNhanVien='"+idNhanVien+"'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(HoaDonDTO hoadon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into HoaDon values('" + hoadon.IDHoaDon + "',N'" + hoadon.IDNhanVien + "','" + hoadon.NgayLap+ "','"+hoadon.NgayLap+"','"+hoadon.ThanhTien+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(HoaDonDTO hoadon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from HoaDon where IDHoaDon ='" + hoadon.IDHoaDon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(HoaDonDTO hoadon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update HoaDon Set ThanhTienn = '" + hoadon.ThanhTien + "' Where IDHoaDon = '" + hoadon.IDHoaDon + "' and IDNhanVien='" + hoadon.IDNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<HoaDonDTO> getALL()
        {
            List<HoaDonDTO> LstHoaDon = new List<HoaDonDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idhoadon = rd[0].ToString();
                string idnhanvien = rd[1].ToString();
                DateTime ngaylap = (DateTime)rd[2];
                decimal tongtien = (decimal)rd[3];
                HoaDonDTO hd = new HoaDonDTO(idhoadon, idnhanvien, ngaylap, tongtien);
                LstHoaDon.Add(hd);
            }
            conn.Close();
            return LstHoaDon;
        }
    }
}
