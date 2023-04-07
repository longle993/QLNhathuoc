using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class CT_HOA_DON_BUS
    {
        NhaThuoc db = new NhaThuoc();
        private static CT_HOA_DON_BUS instance;
        public static CT_HOA_DON_BUS Instance
        {
            get { if (instance == null) instance = new CT_HOA_DON_BUS(); return instance; }
            private set { instance = value; }
        }

        public List<CT_HOA_DON> GetCT_HOA_DONs(string mahoadon)
        {
            return CT_HOA_DON_DAO.Instance.GetCT_HOA_DONs(mahoadon);
        }
        public void RemoveCTHD(string mahoadon)
        {
            CT_HOA_DON_DAO.Instance.RemoveCTHD(mahoadon);
        }
    }
}
