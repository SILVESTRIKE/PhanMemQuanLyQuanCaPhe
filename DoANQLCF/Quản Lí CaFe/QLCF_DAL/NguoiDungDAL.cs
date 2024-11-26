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
    public class NguoiDungDAL
    {
        dbContext dbContext = new dbContext();
        private SqlConnection conn;
        public NguoiDungDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
        }
        public bool isExists(string iddn)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from NhanVien where IDNhanVien = '" + iddn + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(NguoiDungDTO nguoidung)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into NguoiDung values('" + nguoidung.IDDN + "',N'" + nguoidung.Pass+ "','" + nguoidung.IDChucVu + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(NguoiDungDTO nguoidung)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from NguoiDung where IDDN ='" + nguoidung.IDDN + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(NguoiDungDTO nguoidung)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update NguyenLieu Set Pass = '" + nguoidung.Pass + "' Where IDNhanVien = '" + nguoidung.IDDN + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<NguoiDungDTO> getALL()
        {
            List<NguoiDungDTO> LstNguoiDung = new List<NguoiDungDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from NguoiDung";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idnguoidung = rd[0].ToString();
                string pass = rd[1].ToString();
                string idchucvu = rd[2].ToString();
                NguoiDungDTO nd = new NguoiDungDTO(idnguoidung, pass, idchucvu);
                LstNguoiDung.Add(nd);
            }
            conn.Close();
            return LstNguoiDung;
        }
        public bool CheckLogin(NguoiDungDTO nguoidung)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            
            string sql = "select count(*) from NhanVien where IDNhanVien = '"+ nguoidung.IDDN +"' and Pass = '"+ nguoidung.Pass +"'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            int kq = (int)cmd.ExecuteScalar();
            conn.Close();

            if (kq > 0)
                return true;
            else
                return false;
        }
    }
}
