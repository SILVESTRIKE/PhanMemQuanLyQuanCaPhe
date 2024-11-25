﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLCF_DAL
{
    public class HoaDonDAL
    {
        dbContext dbContext = new dbContext();
        private SqlConnection conn;
        public HoaDonDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
        }
        public bool isExists(string idHoaDon, DateTime ngayLap, string idNhanVien, decimal thanhTien)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from HoaDon where IDHoaDon = '" + idHoaDon + "' and IDNhanVien='"+idNhanVien+"'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(HoaDonDTO hoadon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into HoaDon values('" + hoadon.IDHoaDon + "',N'" + hoadon.IDNhanVien + "','" + hoadon.NgayLap+ "','"+hoadon.NgayLap+"','"+hoadon.TongTien+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(HoaDonDTO hoadon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from HoaDon where IDHoaDon ='" + hoadon.IDHoaDon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(HoaDonDTO hoadon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update HoaDon Set ThanhTienn = '" + hoadon.TongTien + "' Where IDHoaDon = '" + hoadon.IDHoaDon + "' and IDNhanVien='" + hoadon.IDNhanVien + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<HoaDonDTO> getALL()
        {
            List<HoaDonDTO> LstHoaDon = new List<HoaDonDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "Select * from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string idhoadon = rd[0].ToString();
                string idnhanvien = rd[1].ToString();
                DateTime ngaylap = (DateTime)rd[2];
                decimal tongtien = (decimal)rd[3];
                HoaDonDTO hd = new HoaDonDTO(idhoadon, idnhanvien, ngaylap, tongtien);
                LstHoaDon.Add(hd);
            }
            conn.Close();
            return LstHoaDon;
        }
        public string IDHoaDon()
        {
            string ngayhientai = DateTime.Now.ToString("ddMMyyyy");
            return "HD" + ngayhientai.ToString() + (getALL().Count() + 1).ToString("D3");
        }
        public bool SaveHoaDon(HoaDonDTO hoaDon, List<ChiTietHDDTO> chiTietList)
        {
            using (SqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    // Lưu thông tin hóa đơn
                    string sql = "INSERT INTO HoaDon VALUES ('"+ hoaDon.IDHoaDon + "', '"+ hoaDon.NgayLap + "','"+ hoaDon.IDNhanVien + "', '"+ hoaDon.TongTien + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kq = (int)cmd.ExecuteNonQuery();
                    conn.Close();
                    if (kq > 0)
                    {
                        foreach (var chiTiet in chiTietList)
                        {
                            string sqlChiTiet = "INSERT INTO ChiTietHD VALUES ('"+chiTiet.IDHoaDon+"','"+chiTiet.IDMon+", '"+chiTiet.SoLuong+"','"+ chiTiet.DonGia + "','"+ chiTiet.ThanhTien + "', '"+ chiTiet.TrangThai + "')";
                            SqlCommand cmdChiTiet = new SqlCommand(sqlChiTiet, conn);
                            int kqCT = (int)cmd.ExecuteNonQuery();
                            conn.Close();
                            if (kqCT > 0)
                            {
                                transaction.Commit();
                                return true;
                            }
                        }
                        return true;
                    }
                            
                    else return false;

                    // Lưu chi tiết hóa đơn
                    
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

    }
}
