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
   public class MonDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        public MonDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idMon, string tenMon, decimal price)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from Mon where IDMon = '" + idMon + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(MonDTO mon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into Mon values('" + mon.IDMon + "',N'" + mon.TenMon + "','" + mon.gia + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(MonDTO mon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from Mon where IDMon ='" + mon.IDMon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(MonDTO mon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update Mon Set GIA = '" + mon.gia+ "' Where IDMon = '" + mon.IDMon+ "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

        public List<MonDTO> getALL()
        {
            List<MonDTO> LstMon = new List<MonDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from Mon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idmon = rd[0].ToString();
                string tenmon = rd[1].ToString();
                decimal gia = (decimal)rd[2];
                MonDTO mon = new MonDTO(idmon, tenmon, gia);
                LstMon.Add(mon);
            }
            conn.Close();
            return LstMon;
        }
    }
}
