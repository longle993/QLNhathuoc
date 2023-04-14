using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DAO;
using NTSF.DTO;

namespace NTSF.BUS
{
    class HANG_HOA_BUS
    {
        private static HANG_HOA_BUS instance;
        public static HANG_HOA_BUS Instance
        {
            get { if (instance == null) instance = new HANG_HOA_BUS(); return instance; }
            private set { instance = value; }
        }

        public List<HANG_HOA> GetHANG_HOAs()
        {
            return HANG_HOA_DAO.Instance.GetHANG_HOAs();
        }

        public List<HANG_HOA> FindByName(string TENSP, string loaisp)
        {
            return HANG_HOA_DAO.Instance.FindByName(TENSP,loaisp);
        }
        public List<HANG_HOA> FindByLoaiSP(string loaisp)
        {
            return HANG_HOA_DAO.Instance.FindByLoaiSP(loaisp);
        }

        public List<HANG_HOA> FindByQCDG(string qcdg)
        {
            return HANG_HOA_DAO.Instance.FindByQCDG(qcdg);
        }
        public void AddUpdateDMSP(HANG_HOA dmsp)
        {
            HANG_HOA_DAO.Instance.AddUpdateDMSP(dmsp);
        }

        public HANG_HOA GetTenSP(string masp)
        {
            return HANG_HOA_DAO.Instance.GetTenSP(masp);
        }
        public List<HANG_HOA> GetDVTCB()
        {
            return HANG_HOA_DAO.Instance.GetDVTCB();
        }
    }
}
