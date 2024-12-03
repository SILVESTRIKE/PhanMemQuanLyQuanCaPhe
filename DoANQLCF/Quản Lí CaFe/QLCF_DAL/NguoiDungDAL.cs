using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DTO;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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
            string sql = "insert into NguoiDung values('" + nguoidung.IDDN + "',N'" + nguoidung.Pass + "','" + nguoidung.IDChucVu + "')";
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


            string sql = "select count(*) from NhanVien where IDNhanVien = '" + nguoidung.IDDN + "' and Pass = '" + nguoidung.Pass + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            int kq = (int)cmd.ExecuteScalar();
            conn.Close();

            if (kq > 0)
                return true;
            else
                return false;
        }
        private const string FullBackupPath = @"D:\CNNET\DoAnNet\PhanMemQuanLyQuanCaPhe\BackUp\Full_QLCF.bak";
        private const string DiffBackupPath = @"D:\CNNET\DoAnNet\PhanMemQuanLyQuanCaPhe\BackUp\Diff_QLCF.bak";
        private const string LogBackupPath = @"D:\CNNET\DoAnNet\PhanMemQuanLyQuanCaPhe\BackUp\Log_QLCF.trn";
        public bool RestoreDatabase()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // 1. Khôi phục từ Full Backup
                if (System.IO.File.Exists(FullBackupPath))
                {
                    string fullRestoreQuery = $@"
                        RESTORE DATABASE QLCF
                        FROM DISK = '{FullBackupPath}'
                        WITH NORECOVERY
                    ";
                    ExecuteRestoreQuery(fullRestoreQuery);
                }
                else
                {
                    throw new Exception("Không tìm thấy Full Backup. Không thể khôi phục cơ sở dữ liệu.");
                }

                // 2. Khôi phục từ Differential Backup (nếu có)
                if (System.IO.File.Exists(DiffBackupPath))
                {
                    string diffRestoreQuery = $@"
                        RESTORE DATABASE QLCF
                        FROM DISK = '{DiffBackupPath}'
                        WITH NORECOVERY
                    ";
                    ExecuteRestoreQuery(diffRestoreQuery);
                }

                // 3. Khôi phục từ Log Backup (nếu có)
                if (System.IO.Directory.Exists(LogBackupPath))
                {
                    
                        string logRestoreQuery = $@"
                            RESTORE LOG QLCF
                            FROM DISK = '{LogBackupPath}'
                            WITH NORECOVERY
                        ";
                        ExecuteRestoreQuery(logRestoreQuery);
                    
                }

                // 4. Hoàn tất khôi phục với RECOVERY
                string recoveryQuery = $@"
                    RESTORE DATABASE QLCF
                    WITH RECOVERY
                ";
                ExecuteRestoreQuery(recoveryQuery);

                conn.Close();
                return true; // Thành công
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                throw new Exception($"Lỗi trong quá trình khôi phục cơ sở dữ liệu: {ex.Message}");
            }
        }

        // Hàm hỗ trợ để thực thi lệnh SQL
        private void ExecuteRestoreQuery(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

    }
}
