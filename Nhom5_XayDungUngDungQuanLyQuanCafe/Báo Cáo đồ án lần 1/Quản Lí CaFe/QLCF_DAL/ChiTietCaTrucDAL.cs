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
    public class ChiTietCaTrucDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        public ChiTietCaTrucDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idCa, string idNhanVien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from ChiTietCaTruc where IDCa = '" + idCa + "'  and IDNhanVien ='" + idNhanVien + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(ChiTietCaTrucDTO chitietcatruc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into ChiTietCaTruc values('" + chitietcatruc.IDCa + "',N'" + chitietcatruc.IDNhanVien + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(ChiTietCaTrucDTO chitietcatruc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from ChiTietCaTruc where IDCa ='" + chitietcatruc.IDCa + "' and IDNhanVien='" + chitietcatruc.IDNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

        public List<ChiTietCaTrucDTO> getALL()
        {
            List<ChiTietCaTrucDTO> LstCTCT = new List<ChiTietCaTrucDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "Select * from ChiTietCaTruc";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string idcatruc = rd["IDCaTruc"].ToString();
                    string idnhanvien = rd["IDNhanVien"].ToString();
                    ChiTietCaTrucDTO ctCT = new ChiTietCaTrucDTO(idcatruc, idnhanvien);
                    LstCTCT.Add(ctCT);
                }
            }
            conn.Close();
            return LstCTCT;
        }
    }
}
