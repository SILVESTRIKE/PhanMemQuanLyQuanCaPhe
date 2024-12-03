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
    public class ThongKeDoanhThuDAL
    {
        dbContext dbContext = new dbContext();
        private SqlConnection conn;
        public ThongKeDoanhThuDAL()
        {
            conn = new SqlConnection(dbContext.Strcon);
        }
        public bool isExists(string idThongke, DateTime ngayLap, decimal doanhThu, string idHoaDon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = ("select count(*) from ThongKeDoanhThu where IDThongKe = '" + idThongke + "'  and IDHoaDon ='" + idHoaDon + "'");
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool insert(ThongKeDoanhThuDTO thongkedoanhthu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into ThongKeDoanhThu values('" + thongkedoanhthu.IDThongke + "',N'" + thongkedoanhthu.IDHoaDon + "','" + thongkedoanhthu.NgayLap + "'','" + thongkedoanhthu.DoanhThu + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool delete(ThongKeDoanhThuDTO thongkedoanhthu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete from ThongKeDoanhThu where IDThongke='" + thongkedoanhthu.IDThongke + "' and IDHoaDon='" + thongkedoanhthu.IDHoaDon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public bool edit(ThongKeDoanhThuDTO thongkedoanhthu)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update ThongKeDoanhThu Set NgayLap = '" + thongkedoanhthu.NgayLap + "' Where IDThongke = '" + thongkedoanhthu.IDThongke + "' and IDHoaDon='" + thongkedoanhthu.IDHoaDon + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }
        public List<ThongKeDoanhThuDTO> getALL()
        {
            List<ThongKeDoanhThuDTO> LstTKDT = new List<ThongKeDoanhThuDTO>();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "Select * from ThongkeDoanhThu";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string idthongke = rd["IDThongke"].ToString();
                    DateTime ngaylap = Convert.ToDateTime(rd["NgayLap"]);
                    decimal doanhthu = Convert.ToDecimal(rd["DoanhThu"]);
                    string idhoadon = rd["IDHoaDon"].ToString();
                    ThongKeDoanhThuDTO tkDT = new ThongKeDoanhThuDTO(idthongke, ngaylap, doanhthu, idhoadon);
                    LstTKDT.Add(tkDT);
                }
            }
            conn.Close();
            return LstTKDT;
        }
        private const string FullBackupPath = @"D:\CNNET\DoAnNet\PhanMemQuanLyQuanCaPhe\BackUp\Full_QLCF.bak";
        private const string DiffBackupPath = @"D:\CNNET\DoAnNet\PhanMemQuanLyQuanCaPhe\BackUp\Diff_QLCF.bak";
        private const string LogBackupPath = @"D:\CNNET\DoAnNet\PhanMemQuanLyQuanCaPhe\BackUp\Log_QLCF.trn";
        public void BackupDatabase()
        {
            bool hasFullBackup = System.IO.File.Exists(FullBackupPath);
            bool hasDiffBackup = System.IO.File.Exists(DiffBackupPath);
            bool hasLogBackup = System.IO.File.Exists(LogBackupPath);

            // Bắt đầu backup tuần tự nếu thiếu file backup
            if (!hasFullBackup)
            {
                FullBackup();
                hasFullBackup = true; // Đánh dấu đã thực hiện Full Backup
            }

            if (!hasDiffBackup && hasFullBackup) // Thực hiện Diff Backup nếu đã có Full Backup
            {
                DifferentialBackup();
                hasDiffBackup = true; // Đánh dấu đã thực hiện Differential Backup
            }

            if (!hasLogBackup && hasDiffBackup) // Thực hiện Log Backup nếu đã có Diff Backup
            {
                TransactionLogBackup();
            }
        }


        // Full Backup
        public bool FullBackup()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = $@"
                BACKUP DATABASE QLCF
                TO DISK = '{FullBackupPath}'
            ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

        // Differential Backup
        public bool DifferentialBackup()
        {
            
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = $@"
                BACKUP DATABASE QLCF
                TO DISK = '{DiffBackupPath}'
                WITH DIFFERENTIAL
            ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

        // Transaction Log Backup
        public bool TransactionLogBackup()
        {
           
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = $@"
                BACKUP LOG QLCF
                TO DISK = '{LogBackupPath}'
            ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;
            else return false;
        }

    }
}
