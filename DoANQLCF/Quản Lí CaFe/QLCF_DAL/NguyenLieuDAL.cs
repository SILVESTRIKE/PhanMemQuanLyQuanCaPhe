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
        dbContext dbContext = new dbContext();
        private SqlConnection conn;
        public NguyenLieuDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
        }
        public bool isExists(string idNguyenLieu, string tenNL, decimal slTon, string dvTinh)
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
        public bool insert(NguyenLieuDTO nl)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into NguyenLieu values('" + nl.IDNguyenLieu + "',N'" + nl.TenNL + "','" + nl.SLTon + "','"+nl.DVTinh+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(NguyenLieuDTO nl)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from NguyenLieu where IDNguyenLieu ='" + nl.IDNguyenLieu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(NguyenLieuDTO nl)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            // Cập nhật cả SLTon và TenNL
            string sql = "update NguyenLieu Set SLTon = @SLTon, TenNL = @TenNL Where IDNguyenLieu = @IDNguyenLieu";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Sử dụng các tham số để tránh SQL Injection
            cmd.Parameters.AddWithValue("@SLTon", nl.SLTon);
            cmd.Parameters.AddWithValue("@TenNL", nl.TenNL);
            cmd.Parameters.AddWithValue("@IDNguyenLieu", nl.IDNguyenLieu);

            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
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
                string dvtinh = rd[3].ToString();

                NguyenLieuDTO nl = new NguyenLieuDTO(idnl, tennl, slton, dvtinh);
                LstNguyenLieu.Add(nl);
            }
            conn.Close();
            return LstNguyenLieu;
        }
        public List<string> LoadDVTComboBox()
        {
            List<string> dvtList = new List<string>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "SELECT DISTINCT DVTinh FROM NguyenLieu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                dvtList.Add(rd["DVTinh"].ToString());
            }
            conn.Close();
            return dvtList;
        }
        public void TruSoLuongNguyenLieu(string idNguyenLieu, decimal soLuongTru)
        {
            string query = "UPDATE NguyenLieu SET SLTon = SLTon - @SoLuongTru WHERE IDNguyenLieu = @IDNguyenLieu";

            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoLuongTru", soLuongTru);
                cmd.Parameters.AddWithValue("@IDNguyenLieu", idNguyenLieu);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
