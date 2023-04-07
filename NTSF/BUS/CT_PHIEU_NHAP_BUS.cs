using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class CT_PHIEU_NHAP_BUS
    {
        NhaThuoc db = new NhaThuoc();
        private static CT_PHIEU_NHAP_BUS instance;
        public static CT_PHIEU_NHAP_BUS Instance
        {
            get { if (instance == null) instance = new CT_PHIEU_NHAP_BUS(); return instance; }
            private set { instance = value; }
        }
        public List<CT_PHIEU_NHAP> GetCT_PHIEU_NHAPs()
        {
            return CT_PHIEU_NHAP_DAO.Instance.GetCT_PHIEU_NHAPs();
        }
        public void AddUpdateCTPN(CT_PHIEU_NHAP ctpn)
        {
            CT_PHIEU_NHAP_DAO.Instance.AddUpdateCTPN(ctpn);
        }


    }
}
