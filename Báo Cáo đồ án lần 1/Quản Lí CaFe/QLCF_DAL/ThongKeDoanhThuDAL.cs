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
    public class ThongKeDoanhThuDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        public ThongKeDoanhThuDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idThongke, DateTime ngayLap, decimal doanhThu, string idHoaDon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from ThongKeDoanhThu where IDThongKe = '" + idThongke + "'  and IDHoaDon ='" + idHoaDon + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(ThongKeDoanhThuDTO thongkedoanhthu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into ThongKeDoanhThu values('" + thongkedoanhthu.IDThongke + "',N'" + thongkedoanhthu.IDHoaDon + "','" + thongkedoanhthu.NgayLap + "'','" + thongkedoanhthu.DoanhThu + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(ThongKeDoanhThuDTO thongkedoanhthu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from ThongKeDoanhThu where IDThongke='" + thongkedoanhthu.IDThongke + "' and IDHoaDon='" + thongkedoanhthu.IDHoaDon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(ThongKeDoanhThuDTO thongkedoanhthu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update ThongKeDoanhThu Set NgayLap = '" + thongkedoanhthu.NgayLap + "' Where IDThongke = '" + thongkedoanhthu.IDThongke + "' and IDHoaDon='" + thongkedoanhthu.IDHoaDon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<ThongKeDoanhThuDTO> getALL()
        {
            List<ThongKeDoanhThuDTO> LstTKDT = new List<ThongKeDoanhThuDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "Select * from ThongkeDoanhThu";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string idthongke = rd["IDThongke"].ToString();
                    DateTime ngaylap = Convert.ToDateTime(rd["NgayLap"]);
                    decimal doanhthu = Convert.ToDecimal(rd["DoanhThu"]);
                    string idhoadon = rd["IDHoaDon"].ToString();
                    ThongKeDoanhThuDTO tkDT = new ThongKeDoanhThuDTO(idthongke, ngaylap, doanhthu, idhoadon);
                    LstTKDT.Add(tkDT);
                }
            }
            conn.Close();
            return LstTKDT;
        }

    }
}
