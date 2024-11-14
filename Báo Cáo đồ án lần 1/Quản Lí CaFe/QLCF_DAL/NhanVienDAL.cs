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
    public class NhanVienDAL
    {
        dbContext dbContext = new dbContext();
        private SqlConnection conn;

        public NhanVienDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
        }

        public bool isExists(string idNhanVien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "select count(*) from NhanVien where IDNhanVien = '" + idNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            return kq > 0;
        }

        public bool insert(NhanVienDTO nhanvien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into NhanVien values('"
                + nhanvien.IDNhanVien + "', N'" + nhanvien.Ten + "', '"
                + nhanvien.SDT + "', N'" + nhanvien.GTinh + "', '"
                + nhanvien.NgSinh.ToString("yyyy-MM-dd") + "', "
                + (nhanvien.TrangThai ? 1 : 0) + ", '"
                + nhanvien.IDQuanLy + "', '" + nhanvien.Pass + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }

        public bool delete(NhanVienDTO nhanvien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from NhanVien where IDNhanVien = '" + nhanvien.IDNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }

        public bool edit(NhanVienDTO nhanvien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update NhanVien set Ten = N'" + nhanvien.Ten
                + "', SDT = '" + nhanvien.SDT + "', GTinh = N'" + nhanvien.GTinh
                + "', NgSinh = '" + nhanvien.NgSinh.ToString("yyyy-MM-dd")
                + "', TrangThai = " + (nhanvien.TrangThai ? 1 : 0)
                + ", IDQuanLy = '" + nhanvien.IDQuanLy
                + "', Pass = '" + nhanvien.Pass
                + "' where IDNhanVien = '" + nhanvien.IDNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq > 0;
        }

        public List<NhanVienDTO> getALL()
        {
            List<NhanVienDTO> LstNhanVien = new List<NhanVienDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    IDNhanVien = rd["IDNhanVien"].ToString(),
                    Ten = rd["Ten"].ToString(),
                    SDT = rd["SDT"].ToString(),
                    GTinh = rd["GTinh"].ToString(),
                    NgSinh = (DateTime)rd["NgSinh"],
                    TrangThai = (bool)rd["TrangThai"],
                    IDQuanLy = rd["IDQuanLy"].ToString(),
                    Pass = rd["Pass"].ToString()
                };
                LstNhanVien.Add(nv);
            }
            conn.Close();
            return LstNhanVien;
        }
    }
}