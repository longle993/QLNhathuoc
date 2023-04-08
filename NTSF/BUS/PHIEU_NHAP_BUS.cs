using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DAO;
using NTSF.DTO;


namespace NTSF.BUS
{
    class PHIEU_NHAP_BUS
    {
        NhaThuoc db = new NhaThuoc();
        private static PHIEU_NHAP_BUS instance;
        public static PHIEU_NHAP_BUS Instance
        {
            get { if (instance == null) instance = new PHIEU_NHAP_BUS(); return instance; }
            private set { instance = value; }
        }
        public List<PHIEU_NHAP> GetPHIEU_NHAPs()
        {
            return PHIEU_NHAP_DAO.Instance.GetPHIEU_NHAPs();
        }
        public void AddUpdatePN(PHIEU_NHAP pn)
        {
            PHIEU_NHAP_DAO.Instance.AddUpdatePN(pn);
        }
        public List<PHIEU_NHAP> FindByMaPN(string mapn)
        {
            return PHIEU_NHAP_DAO.Instance.FindByMaPN(mapn);
        }
        public List<PHIEU_NHAP> FindByName(string tensp, string mapn, DateTime timeFrom, DateTime timeTo)
        {
            return PHIEU_NHAP_DAO.Instance.FindByName(tensp, mapn, timeFrom, timeTo);
        }

        public List<PHIEU_NHAP> GetBaoCao(DateTime timeFrom, DateTime timeTo)
        {
            return PHIEU_NHAP_DAO.Instance.GetBaoCao(timeFrom, timeTo);
        }
    }
}
