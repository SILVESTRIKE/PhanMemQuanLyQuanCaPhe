using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLCF_DTO;
namespace QLCF_DAL
{
    public class CaTrucDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;

        public CaTrucDAL()
        {
            conn = new SqlConnection(strCon);
        }

        public bool isExists(string idCa)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from CaTruc where IDCa = '" + idCa + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

        public bool insert(CaTrucDTO caTruc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "insert into CaTruc values('" + caTruc.IDCa + "',N'" + caTruc.TenCa + "',N'" + caTruc.NgayTruc + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

        public bool delete(CaTrucDTO caTruc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "delete from CaTruc where IDCa ='" + caTruc.IDCa + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

        public bool edit(CaTrucDTO caTruc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "update CaTruc set TenCaTruc where IDCa ='" + caTruc.IDCa + "'";
           SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

       public List<CaTrucDTO> getALL()
        {
            List<CaTrucDTO> LstCaTruc = new List<CaTrucDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "Select * from CaTruc";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string idcatruc = rd[0].ToString();
                    string tencatruc = rd[1].ToString();
                    DateTime ngaytruc = (DateTime)rd[3];
                    CaTrucDTO caTruc = new CaTrucDTO(idcatruc, tencatruc,ngaytruc);
                    LstCaTruc.Add(caTruc);
                }
            }
            conn.Close();
            return LstCaTruc;
        }
        
    }
}
