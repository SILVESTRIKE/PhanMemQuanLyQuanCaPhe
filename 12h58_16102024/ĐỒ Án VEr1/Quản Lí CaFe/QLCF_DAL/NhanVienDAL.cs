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
        public static string strCon = @"Data Source=LIEM_PHONG\THCSDL;Initial Catalog=QL_QuanCafeV2;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        public NhanVienDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public bool isExists(string idNhanVien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from NguyenLieu where IDNhanVien = '" + idNhanVien + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(NhanVienDTO nhanvien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into NhanVien values('" + nhanvien.IDNhanVien + "',N'" + nhanvien.Ten + "','" + nhanvien.GTinh + "','" + nhanvien.NgSinh + "','" + nhanvien.NgSinh + "','" + nhanvien.SDT + "','" + nhanvien.IDChucVu + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(NhanVienDTO nhanvien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from NhanVien where IDNhanVien ='" + nhanvien.IDNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(NhanVienDTO nhanvien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update NguyenLieu Set Ten = '" + nhanvien.Ten + "' Where IDNhanVien = '" + nhanvien.IDNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
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
                string idnhanvien = rd[0].ToString();
                string tennv = rd[1].ToString();
                string sdt = rd[2].ToString();
                string gioitinh = rd[3].ToString();
                DateTime ngsinh = (DateTime)rd[4];
                string idchucvu = rd[5].ToString();
                NhanVienDTO nv = new NhanVienDTO(idnhanvien, tennv, sdt,gioitinh,ngsinh, idchucvu);
                LstNhanVien.Add(nv);
            }
            conn.Close();
            return LstNhanVien;
        }
    }
}
