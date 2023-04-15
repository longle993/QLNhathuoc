using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class CT_PHIEU_XUAT_HUY_BUS
    {
        NhaThuoc db = new NhaThuoc();
        private static CT_PHIEU_XUAT_HUY_BUS instance;
        public static CT_PHIEU_XUAT_HUY_BUS Instance
        {
            get { if (instance == null) instance = new CT_PHIEU_XUAT_HUY_BUS(); return instance; }
            private set { instance = value; }
        }

        public void AddCTXH(CT_PHIEU_XUAT_HUY ctp)
        {
            CT_PHIEU_XUAT_HUY_DAO.Instance.AddCTXH(ctp);
        }
        public List<CT_PHIEU_XUAT_HUY> GetCT_PHIEU_XUAT_HUYs()
        {
            return CT_PHIEU_XUAT_HUY_DAO.Instance.GetCT_PHIEU_XUAT_HUYs();
        }

    }
}
