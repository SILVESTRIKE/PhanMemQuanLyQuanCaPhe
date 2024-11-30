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
        dbContext dbContext = new dbContext();
        private SqlConnection conn;
        public MonDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
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

            string sql = "INSERT INTO Mon (IDMon, TenMon, Gia, Loai) VALUES (@IDMon, @TenMon, @Gia, @Loai)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@IDMon", mon.IDMon);
                cmd.Parameters.AddWithValue("@TenMon", mon.TenMon);
                cmd.Parameters.AddWithValue("@Gia", mon.gia);
                cmd.Parameters.AddWithValue("@Loai", mon.loai);

                int kq = cmd.ExecuteNonQuery();
                conn.Close();
                return kq > 0;
            }
        }

        public bool delete(MonDTO mon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "DELETE FROM Mon WHERE IDMon = @IDMon";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@IDMon", mon.IDMon);

                int kq = cmd.ExecuteNonQuery();
                conn.Close();
                return kq > 0;
            }
        }

        public bool edit(MonDTO mon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "UPDATE Mon SET TenMon = @TenMon, Gia = @Gia, Loai = @Loai WHERE IDMon = @IDMon";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@IDMon", mon.IDMon);
                cmd.Parameters.AddWithValue("@TenMon", mon.TenMon);
                cmd.Parameters.AddWithValue("@Gia", mon.gia);
                cmd.Parameters.AddWithValue("@Loai", mon.loai);

                int kq = cmd.ExecuteNonQuery();
                conn.Close();
                return kq > 0;
            }
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
                string loai = rd[3].ToString();
                MonDTO mon = new MonDTO(idmon, tenmon, gia,loai);
                LstMon.Add(mon);
            }
            conn.Close();
            return LstMon;
        }
        public List<MonDTO> GetMonByLoai(string Loai)
        {
            List<MonDTO> LstMon = new List<MonDTO> ();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from Mon where Loai = '"+Loai+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idmon = rd[0].ToString();
                string tenmon = rd[1].ToString();
                decimal gia = (decimal)rd[2];
                string loai = rd[3].ToString();
                MonDTO mon = new MonDTO(idmon, tenmon, gia, loai);
                LstMon.Add(mon);
            }
            conn.Close ();
            return LstMon;
        }
    }
}
