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
    public class NguyenLieuDAL
    {
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        public NguyenLieuDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idNguyenLieu, string tenNL, int slTon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from NguyenLieu where IDNguyenLieu = '" +idNguyenLieu  + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(NguyenLieuDTO nguyenlieu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into NguyenLieu values('" + nguyenlieu.IDNguyenLieu + "',N'" + nguyenlieu.TenNL + "','" + nguyenlieu.SLTon + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(NguyenLieuDTO nguyenlieu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from NguyenLieu where IDNguyenLieu ='" + nguyenlieu.IDNguyenLieu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(NguyenLieuDTO nguyenlieu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update NguyenLieu Set SLTon = '" + nguyenlieu.SLTon+ "' Where IDNGuyenLieu = '" + nguyenlieu.IDNguyenLieu+ "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<NguyenLieuDTO> getALL()
        {
            List<NguyenLieuDTO> LstNguyenLieu = new List<NguyenLieuDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from NguyenLieu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idnl = rd[0].ToString();
                string tennl = rd[1].ToString();
                int slton = (int)rd[2];
                NguyenLieuDTO nl = new NguyenLieuDTO(idnl, tennl, slton);
                LstNguyenLieu.Add(nl);
            }
            conn.Close();
            return LstNguyenLieu;
        }
    }
}
