﻿using NTSF.DTO;
using System.Linq;

namespace NTSF.DAO
{
    class CT_PHIEU_XUAT_HUY_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static CT_PHIEU_XUAT_HUY_DAO instance;
        public static CT_PHIEU_XUAT_HUY_DAO Instance
        {
            get { if (instance == null) instance = new CT_PHIEU_XUAT_HUY_DAO(); return instance; }
            private set { instance = value; }
        }

        public void AddCTXH(CT_PHIEU_XUAT_HUY ctp)
        {
            NhaThuoc db = new NhaThuoc();
            ctp.HANG_HOA = db.HANG_HOA.Find(ctp.MA_SP, ctp.SO_LO);
            ctp.PHIEU_XUAT_HUY = db.PHIEU_XUAT_HUY.Find(ctp.MA_PHIEU);
            db.CT_PHIEU_XUAT_HUY.Add(ctp);
            db.SaveChanges();
        }
    }
}
