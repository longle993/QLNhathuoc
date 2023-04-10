using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class HANG_HOA_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static HANG_HOA_DAO instance;
        public static HANG_HOA_DAO Instance
        {
            get { if (instance == null) instance = new HANG_HOA_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<HANG_HOA> GetHANG_HOAs()
        {
            return db.HANG_HOA.ToList();
        }

        public List<HANG_HOA> FindByName(string TENSP,string loaisp)
        {
            if(loaisp is null || loaisp == "")
            {
                return db.HANG_HOA.Where(p => p.TEN_SP.StartsWith(TENSP)).ToList();
            }
            else
                return db.HANG_HOA.Where(p => p.TEN_SP.StartsWith(TENSP)).ToList().Where(p=> p.LOAI_SP == loaisp).ToList();
        }
        public List<HANG_HOA> FindByLoaiSP(string loaisp)
        {
            return db.HANG_HOA.Where(p => p.LOAI_SP == loaisp).ToList();
        }

        public void AddUpdateDMSP(HANG_HOA dmsp)
        {
            try
            {
                if(db.HANG_HOA.Find(dmsp.MA_SP) is null)
                {
                    db.HANG_HOA.Add(dmsp);
                    db.SaveChanges();
                }
                else
                {
                    db.HANG_HOA.Attach(dmsp);
                    dmsp.TONG_TON += dmsp.TONG_TON;
                    db.SaveChanges();
                }
            }

            catch(Exception)
            {
               
            }
        }
        
        public HANG_HOA GetTenSP(string masp)
        {
            HANG_HOA sp = db.HANG_HOA.SingleOrDefault(p => p.MA_SP == masp);
            return sp;
        }

    }
}
