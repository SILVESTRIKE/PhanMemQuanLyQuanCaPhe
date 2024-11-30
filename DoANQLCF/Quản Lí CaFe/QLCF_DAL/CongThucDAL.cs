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
        dbContext dbContext = new dbContext();
        private SqlConnection conn;
        public CongThucDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
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
            string sql = "update CongThuc Set SoLuong = '" + congthuc.SoLuong + "' Where IDMon = '" + congthuc.IDMon + "' and IDNguyenLieu='"+congthuc.IDNguyenLieu+"'";
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

            string sql = @"
        SELECT c.IDMon, m.TenMon, c.IDNguyenLieu, nl.TenNL, c.SoLuong, nl.DVTinh 
        FROM CongThuc c
        JOIN NguyenLieu nl ON c.IDNguyenLieu = nl.IDNguyenLieu
        JOIN Mon m ON c.IDMon = m.IDMon";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        CongThucDTO congThuc = new CongThucDTO
                        {
                            IDMon = rd["IDMon"].ToString(),
                            TenMon = rd["TenMon"].ToString(),
                            IDNguyenLieu = rd["IDNguyenLieu"].ToString(),
                            TenNguyenLieu = rd["TenNL"].ToString(),
                            SoLuong = Convert.ToDecimal(rd["SoLuong"]),
                            DVTinh = rd["DVTinh"].ToString()
                        };
                        LstCongThuc.Add(congThuc);
                    }
                }
            }
            conn.Close();
            return LstCongThuc;
        }

        public List<CongThucDTO> GetCongThucByMon(string idMon)
        {
            List<CongThucDTO> congThucs = new List<CongThucDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = @"
                SELECT c.IDMon, m.TenMon, c.IDNguyenLieu, nl.TenNL, c.SoLuong, nl.DVTinh 
                FROM CongThuc c
                JOIN NguyenLieu nl ON c.IDNguyenLieu = nl.IDNguyenLieu
                JOIN Mon m ON c.IDMon = m.IDMon
                WHERE c.IDMon = @IDMon";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@IDMon", idMon);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        CongThucDTO congThuc = new CongThucDTO
                        {
                            IDMon = rd["IDMon"].ToString(),
                            TenMon = rd["TenMon"].ToString(),
                            IDNguyenLieu = rd["IDNguyenLieu"].ToString(),
                            TenNguyenLieu = rd["TenNL"].ToString(),
                            SoLuong = Convert.ToDecimal(rd["SoLuong"]),
                            DVTinh = rd["DVTinh"].ToString()
                        };
                        congThucs.Add(congThuc);
                    }
                }
            }
            conn.Close();
            return congThucs;
        }

    }
}
