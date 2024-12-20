﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF_DAL;
using QLCF_DTO;

namespace QLCF_BLL
{
    public class LichTrucBLL
    {
        private LichTrucDAL dal = new LichTrucDAL();
        public List<LichTrucDTO> GetAllLichTruc()
        {
            return dal.GetAllLichTruc();
        }
        public bool InsertLichTruc(LichTrucDTO lichTruc)
        {
            return dal.InsertLichTruc(lichTruc);
        }
        public bool DeleteChiTietLichTruc(string idLichTruc, string idNhanVien)
        {
            return dal.DeleteChiTietLichTruc(idLichTruc, idNhanVien);
        }
        public bool UpdateLichTruc(string idLichTruc, string newStatus, string manv)
        {
            LichTrucDAL dal = new LichTrucDAL();
            return dal.UpdateLichTruc(idLichTruc, newStatus, manv);
        }
        public List<LichTrucDTO> GetLichTrucByNhanVien(string idNhanVien)
        {
            return dal.GetLichtrucByNV(idNhanVien);
        }


    }
}
