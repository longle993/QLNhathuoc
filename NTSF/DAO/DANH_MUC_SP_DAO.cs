using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class DANH_MUC_SP_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static DANH_MUC_SP_DAO instance;
        public static DANH_MUC_SP_DAO Instance
        {
            get { if (instance == null) instance = new DANH_MUC_SP_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<DANH_MUC_SP> GetDANH_MUC_SP_DAOs()
        {
            return db.DANH_MUC_SP.ToList();
        }

        public List<DANH_MUC_SP> FindByName(string TENSP,string loaisp)
        {
            if(loaisp is null || loaisp == "")
            {
                return db.DANH_MUC_SP.Where(p => p.TEN_SP.StartsWith(TENSP)).ToList();
            }
            else
                return db.DANH_MUC_SP.Where(p => p.TEN_SP.StartsWith(TENSP)).ToList().Where(p=> p.NHOM_SP == loaisp).ToList();
        }
        public List<DANH_MUC_SP> FindByLoaiSP(string loaisp)
        {
            return db.DANH_MUC_SP.Where(p => p.NHOM_SP == loaisp).ToList();
        }

    }
}
