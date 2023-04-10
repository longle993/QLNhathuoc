using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DAO;
using NTSF.DTO;

namespace NTSF.BUS
{
    class PHIEU_XUAT_HUY_BUS
    {
        private static PHIEU_XUAT_HUY_DAO instance;
        public static PHIEU_XUAT_HUY_DAO Instance
        {
            get { if (instance == null) instance = new PHIEU_XUAT_HUY_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<PHIEU_XUAT_HUY> GetPHIEU_XUAT_HUYs()
        {
            return PHIEU_XUAT_HUY_DAO.Instance.GetPHIEU_XUAT_HUYs();
        }
    }
}
