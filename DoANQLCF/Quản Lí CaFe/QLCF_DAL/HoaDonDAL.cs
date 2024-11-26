using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLCF_DTO;

namespace QLCF_DAL
{
    public class HoaDonDAL
    {
        private dbContext dbContext = new dbContext();
        private SqlConnection conn;

        public HoaDonDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
        }

        public bool IsExists(string idHoaDon, string idNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM HoaDon WHERE IDHoaDon = @idHoaDon AND IDNhanVien = @idNhanVien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                    cmd.Parameters.AddWithValue("@idNhanVien", idNhanVien);
                    int kq = (int)cmd.ExecuteScalar();
                    return kq > 0;
                }
            }
        }

        public bool Insert(HoaDonDTO hoadon)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "INSERT INTO HoaDon (IDHoaDon, IDNhanVien, NgayLap, TongTien) VALUES (@IDHoaDon, @IDNhanVien, @NgayLap, @TongTien)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IDHoaDon", hoadon.IDHoaDon);
                    cmd.Parameters.AddWithValue("@IDNhanVien", hoadon.IDNhanVien);
                    cmd.Parameters.AddWithValue("@NgayLap", hoadon.NgayLap);
                    cmd.Parameters.AddWithValue("@TongTien", hoadon.TongTien);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
            }
        }

        public bool Delete(string idHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "DELETE FROM HoaDon WHERE IDHoaDon = @IDHoaDon";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IDHoaDon", idHoaDon);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
            }
        }

        public bool Edit(HoaDonDTO hoadon)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "UPDATE HoaDon SET TongTien = @TongTien WHERE IDHoaDon = @IDHoaDon AND IDNhanVien = @IDNhanVien";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IDHoaDon", hoadon.IDHoaDon);
                    cmd.Parameters.AddWithValue("@IDNhanVien", hoadon.IDNhanVien);
                    cmd.Parameters.AddWithValue("@TongTien", hoadon.TongTien);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
            }
        }

        public List<HoaDonDTO> GetAll()
        {
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT * FROM HoaDon";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string idHoaDon = rd["IDHoaDon"].ToString();
                            string idNhanVien = rd["IDNhanVien"].ToString();
                            DateTime ngayLap = (DateTime)rd["NgayLap"];
                            decimal tongTien = (decimal)rd["TongTien"];
                            HoaDonDTO hd = new HoaDonDTO(idHoaDon, idNhanVien, ngayLap, tongTien);
                            lstHoaDon.Add(hd);
                        }
                    }
                }
            }
            return lstHoaDon;
        }

        public string GenerateIDHoaDon()
        {
            string ngayHienTai = DateTime.Now.ToString("ddMMyyyy");
            return "HD" + ngayHienTai + (GetAll().Count + 1).ToString("D3");
        }

        public bool SaveHoaDon(HoaDonDTO hoaDon, List<ChiTietHDDTO> chiTietList)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Lưu thông tin hóa đơn
                        string sqlHoaDon = "INSERT INTO HoaDon (IDHoaDon, NgayLap, IDNhanVien, TongTien) VALUES (@IDHoaDon, @NgayLap, @IDNhanVien, @TongTien)";
                        using (SqlCommand cmdHoaDon = new SqlCommand(sqlHoaDon, conn, transaction))
                        {
                            cmdHoaDon.Parameters.AddWithValue("@IDHoaDon", hoaDon.IDHoaDon);
                            cmdHoaDon.Parameters.AddWithValue("@NgayLap", hoaDon.NgayLap);
                            cmdHoaDon.Parameters.AddWithValue("@IDNhanVien", hoaDon.IDNhanVien);
                            cmdHoaDon.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                            cmdHoaDon.ExecuteNonQuery();
                        }

                        // Lưu chi tiết hóa đơn
                        foreach (var chiTiet in chiTietList)
                        {
                            string sqlChiTiet = "INSERT INTO ChiTietHD (IDHoaDon, IDMon, SoLuong, DonGia, ThanhTien, TinhTrang_PhucVu) VALUES (@IDHoaDon, @IDMon, @SoLuong, @DonGia, @ThanhTien, @TinhTrang)";
                            using (SqlCommand cmdChiTiet = new SqlCommand(sqlChiTiet, conn, transaction))
                            {
                                cmdChiTiet.Parameters.AddWithValue("@IDHoaDon", chiTiet.IDHoaDon);
                                cmdChiTiet.Parameters.AddWithValue("@IDMon", chiTiet.IDMon);
                                cmdChiTiet.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                                cmdChiTiet.Parameters.AddWithValue("@DonGia", chiTiet.DonGia);
                                cmdChiTiet.Parameters.AddWithValue("@ThanhTien", chiTiet.ThanhTien);
                                cmdChiTiet.Parameters.AddWithValue("@TinhTrang", chiTiet.TrangThai);
                                cmdChiTiet.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<HoaDonDTO> GetHoaDonByDate(DateTime date)
        {
            List<HoaDonDTO> hoaDons = new List<HoaDonDTO>();
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT * FROM HoaDon WHERE CAST(NgayLap AS DATE) = @Date";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            HoaDonDTO hoaDon = new HoaDonDTO
                            {
                                IDHoaDon = rd["IDHoaDon"].ToString(),
                                NgayLap = (DateTime)rd["NgayLap"],
                                IDNhanVien = rd["IDNhanVien"].ToString(),
                                TongTien = (decimal)rd["TongTien"]
                            };
                            hoaDons.Add(hoaDon);
                        }
                    }
                }
            }
            return hoaDons;
        }

        public List<HoaDonDTO> GetHoaDonByMonth(int month, int year)
        {
            List<HoaDonDTO> hoaDons = new List<HoaDonDTO>();
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT * FROM HoaDon WHERE MONTH(NgayLap) = @Month AND YEAR(NgayLap) = @Year";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            HoaDonDTO hoaDon = new HoaDonDTO
                            {
                                IDHoaDon = rd["IDHoaDon"].ToString(),
                                NgayLap = (DateTime)rd["NgayLap"],
                                IDNhanVien = rd["IDNhanVien"].ToString(),
                                TongTien = (decimal)rd["TongTien"]
                            };
                            hoaDons.Add(hoaDon);
                        }
                    }
                }
            }
            return hoaDons;
        }

        public decimal GetTotalRevenueByDate(DateTime date)
        {
            decimal totalRevenue = 0;
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT SUM(TongTien) AS TotalRevenue FROM HoaDon WHERE CAST(NgayLap AS DATE) = @Date";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date);
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDecimal(result);
                    }
                }
            }
            return totalRevenue;
        }

        public decimal GetTotalRevenueByMonth(int month, int year)
        {
            decimal totalRevenue = 0;
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT SUM(TongTien) AS TotalRevenue FROM HoaDon WHERE MONTH(NgayLap) = @Month AND YEAR(NgayLap) = @Year";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDecimal(result);
                    }
                }
            }
            return totalRevenue;
        }
        public int GetInvoiceCountByDate(DateTime date)
        {
            int invoiceCount = 0;
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS DATE) = @Date";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date);
                    invoiceCount = (int)cmd.ExecuteScalar();
                }
            }
            return invoiceCount;
        }

        public int GetInvoiceCountByMonth(int month, int year)
        {
            int invoiceCount = 0;
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM HoaDon WHERE MONTH(NgayLap) = @Month AND YEAR(NgayLap) = @Year";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    invoiceCount = (int)cmd.ExecuteScalar();
                }
            }
            return invoiceCount;
        }

    }
}
