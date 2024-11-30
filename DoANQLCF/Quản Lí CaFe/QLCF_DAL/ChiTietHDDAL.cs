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
    public class ChiTietHDDAL
    {
        MonDAL monDAL= new MonDAL();
        dbContext dbContext = new dbContext();
        private SqlConnection conn;
        public ChiTietHDDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
        }
        public bool isExists(string idHoaDon, string idMon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from ChiTietHD where IDMOn = '" + idMon + "'  and IDHoaDon ='" + idHoaDon + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(ChiTietHDDTO chitiethd)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into ChiTietHD values('" + chitiethd.IDHoaDon + "',N'" + chitiethd.IDMon + "','" + chitiethd.SoLuong + "'','" + chitiethd.DonGia + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(ChiTietHDDTO chitiethd)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from ChiTietHD where IDHoaDon ='" + chitiethd.IDHoaDon + "' and IDMon='" + chitiethd.IDMon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(ChiTietHDDTO chitiethd)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update ChiTietHD Set SoLuog = '" + chitiethd.SoLuong + "' Where IDMon = '" + chitiethd.IDMon + "' and IDMon='" + chitiethd.IDMon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<ChiTietHDDTO> getALL()
        {
            List<ChiTietHDDTO> LstCTHD = new List<ChiTietHDDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "Select * from ChiTietHD";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string idhoadon = rd["IDHoaDon"].ToString();
                    string idmon = rd["IDMon"].ToString();
                    int soluong = Convert.ToInt32(rd["SoLuong"]);
                    decimal dongia = Convert.ToDecimal(rd["DonGia"]);
                    decimal thanhTien = Convert.ToDecimal(rd["TongTien"]);
                    bool trangThai = Convert.ToBoolean(rd["TinhTrang_PhucVu"]);
                    ChiTietHDDTO ctHD = new ChiTietHDDTO(idhoadon, idmon, soluong, dongia, thanhTien, trangThai);
                    LstCTHD.Add(ctHD);
                }
            }
            conn.Close();
            return LstCTHD;
        }
        public string tenMon(string idMon)
        {
            string ten = string.Empty;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select TenMon from Mon where IDMon = '" + idMon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ten = rd[0].ToString();
            }
            conn.Close();
            return ten;
        }
        public List<ChiTietHD_CTDTO> GetChiTietHDByHoaDonID(string idHoaDon)
        {
            List<ChiTietHD_CTDTO> LstCTHD = new List<ChiTietHD_CTDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = @"
                SELECT c.IDHoaDon, c.IDMon, m.TenMon, c.SoLuong, c.TinhTrang_PhucVu 
                FROM ChiTietHD c
                JOIN Mon m ON c.IDMon = m.IDMon
                WHERE c.IDHoaDon = @IDHoaDon";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@IDHoaDon", idHoaDon);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        string idhoadon = rd["IDHoaDon"].ToString();
                        string idmon = rd["IDMon"].ToString();
                        string tenmon = rd["TenMon"].ToString();
                        int soluong = Convert.ToInt32(rd["SoLuong"]);
                        bool trangThai = Convert.ToBoolean(rd["TinhTrang_PhucVu"]);

                        ChiTietHD_CTDTO ctHD = new ChiTietHD_CTDTO
                        {
                            IDHoaDon = idhoadon,
                            IDMon = idmon,
                            TenMon = tenmon,
                            SoLuong = soluong,
                            TinhTrang_PhucVu = trangThai
                        };
                        LstCTHD.Add(ctHD);
                    }
                }
            }
            conn.Close();
            return LstCTHD;
        }
        public bool UpdateTrangThaiPhucVu(string idHoaDon, string idMon, bool trangThaiPhucVu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "UPDATE ChiTietHD SET TinhTrang_PhucVu = @TinhTrang_PhucVu WHERE IDHoaDon = @IDHoaDon AND IDMon = @IDMon";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TinhTrang_PhucVu", trangThaiPhucVu);
                cmd.Parameters.AddWithValue("@IDHoaDon", idHoaDon);
                cmd.Parameters.AddWithValue("@IDMon", idMon);

                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
        }



    }
}
