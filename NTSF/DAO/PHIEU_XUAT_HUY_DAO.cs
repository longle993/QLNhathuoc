using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class PHIEU_XUAT_HUY_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static PHIEU_XUAT_HUY_DAO instance;
        public static PHIEU_XUAT_HUY_DAO Instance
        {
            get { if (instance == null) instance = new PHIEU_XUAT_HUY_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<PHIEU_XUAT_HUY> GetPHIEU_XUAT_HUYs()
        {
            return db.PHIEU_XUAT_HUY.ToList();
        }
    }
}
