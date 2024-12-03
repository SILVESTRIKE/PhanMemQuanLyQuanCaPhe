﻿using QLCF_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF_DAL
{
    public class LichTrucDAL
    {
        dbContext dbContext = new dbContext();

        public List<LichTrucDTO> GetAllLichTruc()
        {
            List<LichTrucDTO> list = new List<LichTrucDTO>();

            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();

                // Thêm ORDER BY để sắp xếp theo thứ tự mong muốn
                string query = @"
                SELECT 
                    lt.IDLichTruc, 
                    ct.TenCa AS CaLam, 
                    nv.IDNhanVien, 
                    nv.Ten AS TenNhanVien, 
                    lt.NgayTruc, 
                    ctlt.TrangThai 
                FROM ChiTietLichTruc ctlt
                JOIN LichTruc lt ON ctlt.IDLichTruc = lt.IDLichTruc
                JOIN NhanVien nv ON ctlt.IDNhanVien = nv.IDNhanVien
                JOIN CaTruc ct ON lt.IDCa = ct.IDCa
                ORDER BY lt.NgayTruc ASC, ct.TenCa ASC"; 
    
            using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ SQL và thêm vào danh sách
                            LichTrucDTO lichTruc = new LichTrucDTO
                            {
                                IdLichTruc = reader.GetString(0),
                                CaLam = reader.GetString(1),
                                MaNhanVien = reader.GetString(2),
                                TenNhanVien = reader.GetString(3),
                                NgayTruc = reader.GetDateTime(4),
                                TrangThai = reader.GetString(5)
                            };
                            list.Add(lichTruc);
                        }
                    }
                }
            }

            return list;
        }
        public bool CheckExistLichTruc(string idLichTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LichTruc WHERE IDLichTruc = @IDLichTruc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLichTruc", idLichTruc);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool InsertLichTruc(LichTrucDTO lichTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();

                // Kiểm tra sự tồn tại của IDLichTruc
                bool exists = CheckExistLichTruc(lichTruc.IdLichTruc);

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        if (!exists)
                        {
                            // Chèn vào bảng LichTruc nếu chưa tồn tại
                            string queryLichTruc = @"
                        INSERT INTO LichTruc (IDLichTruc, IDCa, NgayTruc)
                        VALUES (@IDLichTruc, @IDCa, @NgayTruc)";
                            using (SqlCommand cmdLichTruc = new SqlCommand(queryLichTruc, conn, transaction))
                            {
                                cmdLichTruc.Parameters.AddWithValue("@IDLichTruc", lichTruc.IdLichTruc);
                                cmdLichTruc.Parameters.AddWithValue("@IDCa", lichTruc.CaLam);
                                cmdLichTruc.Parameters.AddWithValue("@NgayTruc", lichTruc.NgayTruc);
                                cmdLichTruc.ExecuteNonQuery();
                            }
                        }

                        // Chèn vào bảng ChiTietLichTruc
                        string queryChiTiet = @"
                    INSERT INTO ChiTietLichTruc (IDLichTruc, IDNhanVien, TrangThai)
                    VALUES (@IDLichTruc, @IDNhanVien, @TrangThai)";
                        using (SqlCommand cmdChiTiet = new SqlCommand(queryChiTiet, conn, transaction))
                        {
                            cmdChiTiet.Parameters.AddWithValue("@IDLichTruc", lichTruc.IdLichTruc);
                            cmdChiTiet.Parameters.AddWithValue("@IDNhanVien", lichTruc.MaNhanVien);
                            cmdChiTiet.Parameters.AddWithValue("@TrangThai", lichTruc.TrangThai);
                            cmdChiTiet.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public bool DeleteChiTietLichTruc(string idLichTruc, string idNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                string query = @"
            DELETE FROM ChiTietLichTruc
            WHERE IDLichTruc = @IDLichTruc AND IDNhanVien = @IDNhanVien;
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLichTruc", idLichTruc);
                    cmd.Parameters.AddWithValue("@IDNhanVien", idNhanVien);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool UpdateLichTruc(LichTrucDTO lichTruc, string newIDLichTruc)
        {
            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Thêm LichTruc mới với ID mới
                    string insertNewLichTrucQuery = @"
                INSERT INTO LichTruc (IDLichTruc, NgayTruc, IDCa)
                VALUES (@NewIDLichTruc, @NgayTruc, @IDCa);
            ";

                    using (SqlCommand cmd = new SqlCommand(insertNewLichTrucQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@NewIDLichTruc", newIDLichTruc);
                        cmd.Parameters.AddWithValue("@NgayTruc", lichTruc.NgayTruc);
                        cmd.Parameters.AddWithValue("@IDCa", lichTruc.CaLam);

                        cmd.ExecuteNonQuery();
                    }

                    // Cập nhật ChiTietLichTruc để trỏ đến ID mới
                    string updateChiTietQuery = @"
                UPDATE ChiTietLichTruc
                SET IDLichTruc = @NewIDLichTruc
                WHERE IDLichTruc = @OldIDLichTruc AND IDNhanVien = @IDNhanVien;
            ";

                    using (SqlCommand cmd = new SqlCommand(updateChiTietQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@NewIDLichTruc", newIDLichTruc);
                        cmd.Parameters.AddWithValue("@OldIDLichTruc", lichTruc.IdLichTruc);
                        cmd.Parameters.AddWithValue("@IDNhanVien", lichTruc.MaNhanVien);

                        cmd.ExecuteNonQuery();
                    }

                    // Xóa LichTruc cũ nếu không còn liên kết
                    string deleteOldLichTrucQuery = @"
                DELETE FROM LichTruc
                WHERE IDLichTruc = @OldIDLichTruc
                AND NOT EXISTS (SELECT 1 FROM ChiTietLichTruc WHERE IDLichTruc = @OldIDLichTruc);
            ";

                    using (SqlCommand cmd = new SqlCommand(deleteOldLichTrucQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@OldIDLichTruc", lichTruc.IdLichTruc);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }



        public List<LichTrucDTO> GetLichtrucByNV(string idNhanVien)
        {
            List<LichTrucDTO> list = new List<LichTrucDTO>();

            using (SqlConnection conn = new SqlConnection(dbContext.Strcon))
            {
                conn.Open();

                // Thêm ORDER BY để sắp xếp theo thứ tự mong muốn
                string query = @"
                SELECT 
                    lt.IDLichTruc, 
                    ct.TenCa AS CaLam, 
                    nv.IDNhanVien, 
                    nv.Ten AS TenNhanVien, 
                    lt.NgayTruc, 
                    ctlt.TrangThai 
                FROM ChiTietLichTruc ctlt
                JOIN LichTruc lt ON ctlt.IDLichTruc = lt.IDLichTruc
                JOIN NhanVien nv ON ctlt.IDNhanVien = nv.IDNhanVien
                JOIN CaTruc ct ON lt.IDCa = ct.IDCa 
                WHERE nv.IDNhanVien = '" + idNhanVien + "' ORDER BY lt.NgayTruc ASC, ct.TenCa ASC";




                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ SQL và thêm vào danh sách
                            LichTrucDTO lichTruc = new LichTrucDTO
                            {
                                IdLichTruc = reader.GetString(0),
                                CaLam = reader.GetString(1),
                                MaNhanVien = reader.GetString(2),
                                TenNhanVien = reader.GetString(3),
                                NgayTruc = reader.GetDateTime(4),
                                TrangThai = reader.GetString(5)
                            };
                            list.Add(lichTruc);
                        }
                    }
                }
            }

            return list;
        }


    }
}
