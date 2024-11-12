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
    public class CongThucDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        public CongThucDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idMon, string idNguyenLieu, decimal soLuong)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from CongThuc where IDMOn = '" + idMon +  "'  and IDNguyenLieu ='"+idNguyenLieu +"'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(CongThucDTO congthuc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into CongThuc values('" + congthuc.IDMon + "',N'" + congthuc.IDNguyenLieu + "','" + congthuc.SoLuong + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(CongThucDTO congthuc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from CongThuc where IDMon ='" + congthuc.IDMon + "' and IDNguyenLieu='"+congthuc.IDNguyenLieu+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(CongThucDTO congthuc)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update CongThuc Set SoLuog = '" + congthuc.SoLuong + "' Where IDMon = '" + congthuc.IDMon + "' and IDNguyenLieu='"+congthuc.IDNguyenLieu+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<CongThucDTO> getALL()
        {
            List<CongThucDTO> LstCongThuc = new List<CongThucDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from CongThuc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idmon = rd[0].ToString();
                string idnguyenlieu = rd[1].ToString();
                int soluong = (int)rd[2];
                CongThucDTO ct = new CongThucDTO(idmon, idnguyenlieu, soluong);
                LstCongThuc.Add(ct);
            }
            conn.Close();
            return LstCongThuc;
        }

    }
}
