using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLCF_DTO;
namespace QLCF_DAL
{
    public class ChucVuDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;

        public ChucVuDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idChucVu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from HoaDon where IDChucVu = '" + idChucVu + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(ChucVuDTO chucvu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into ChucVu values('" + chucvu.IDChucVu + "',N'" + chucvu.Ten + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(ChucVuDTO chucvu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from ChucVu where IDChucVu ='" + chucvu.IDChucVu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(ChucVuDTO chucvu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update HoaDon Set Ten = '" + chucvu.Ten + "' Where IDChucVu = '" + chucvu.IDChucVu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<ChucVuDTO> getALL()
        {
            List<ChucVuDTO> LstChucVu = new List<ChucVuDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from ChucVu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idchucvu = rd[0].ToString();
                string tenchucvu = rd[1].ToString();
                ChucVuDTO cv = new ChucVuDTO(idchucvu, tenchucvu);
                LstChucVu.Add(cv);
            }
            conn.Close();
            return LstChucVu;
        }

    }
}
