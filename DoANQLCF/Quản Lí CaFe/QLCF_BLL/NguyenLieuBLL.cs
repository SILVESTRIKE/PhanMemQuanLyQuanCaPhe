using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;
namespace QLCF_BLL
{
    public class NguyenLieuBLL
    {
        private NguyenLieuDAL nglieuDAL = new NguyenLieuDAL();

        public List<NguyenLieuDTO> GetAllNgLieu()
        {
            return nglieuDAL.getALL();
        }

        public bool AddNguyenLieu(NguyenLieuDTO nl)
        {
            return nglieuDAL.insert(nl);
        }

        public bool UpdateNguyenLieu(NguyenLieuDTO nl)
        {
            return nglieuDAL.edit(nl);
        }

        public bool DeleteNguyenLieu(NguyenLieuDTO nl)
        {
            return nglieuDAL.delete(nl);
        }
        public void TruSoLuongNguyenLieu(string idNguyenLieu, decimal soLuongTru)
        {
            nglieuDAL.TruSoLuongNguyenLieu(idNguyenLieu, soLuongTru);
        }
    }
}
