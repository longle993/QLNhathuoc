using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DAO;
using NTSF.DTO;

namespace NTSF.BUS
{
    class DANH_MUC_SP_BUS
    {
        private static DANH_MUC_SP_BUS instance;
        public static DANH_MUC_SP_BUS Instance
        {
            get { if (instance == null) instance = new DANH_MUC_SP_BUS(); return instance; }
            private set { instance = value; }
        }

        public List<DANH_MUC_SP> GetDANH_MUC_SP_DAOs()
        {
            return DANH_MUC_SP_DAO.Instance.GetDANH_MUC_SP_DAOs();
        }

        public List<DANH_MUC_SP> FindByName(string TENSP, string loaisp)
        {
            return DANH_MUC_SP_DAO.Instance.FindByName(TENSP,loaisp);
        }
        public List<DANH_MUC_SP> FindByLoaiSP(string loaisp)
        {
            return DANH_MUC_SP_DAO.Instance.FindByLoaiSP(loaisp);
        }

        public void AddUpdateDMSP(DANH_MUC_SP dmsp)
        {
            DANH_MUC_SP_DAO.Instance.AddUpdateDMSP(dmsp);
        }

        public DANH_MUC_SP GetTenSP(string masp)
        {
            return DANH_MUC_SP_DAO.Instance.GetTenSP(masp);
        }
    }
}
