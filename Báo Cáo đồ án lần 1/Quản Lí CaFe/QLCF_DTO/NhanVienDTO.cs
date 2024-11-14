using System;

namespace QLCF_DTO
{
    public class NhanVienDTO
    {
        public string IDNhanVien { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string GTinh { get; set; }
        public DateTime NgSinh { get; set; }
        public bool TrangThai { get; set; }
        public string IDQuanLy { get; set; } 
        public string Pass { get; set; } 

        public NhanVienDTO() { }

        public NhanVienDTO(string idNhanVien, string ten, string sdt, string gtinh, DateTime ngSinh, bool trangThai, string idQuanLy, string pass)
        {
            IDNhanVien = idNhanVien;
            Ten = ten;
            SDT = sdt;
            GTinh = gtinh;
            NgSinh = ngSinh;
            TrangThai = trangThai;
            IDQuanLy = idQuanLy;
            Pass = pass;
        }
    }
}
