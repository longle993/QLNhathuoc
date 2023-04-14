using NTSF.DTO;
using System.Collections.Generic;
using System.Linq;

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

        public List<HANG_HOA> FindByName(string TENSP, string loaisp)
        {
            if (loaisp is null || loaisp == "")
            {
                return db.HANG_HOA.Where(p => p.TEN_SP.StartsWith(TENSP)).ToList();
            }
            else
                return db.HANG_HOA.Where(p => p.TEN_SP.StartsWith(TENSP)).ToList().Where(p => p.LOAI_SP == loaisp).ToList();
        }
        public List<HANG_HOA> FindByLoaiSP(string loaisp)
        {
            return db.HANG_HOA.Where(p => p.LOAI_SP == loaisp).ToList();
        }

        public List<HANG_HOA> FindByQCDG(string qcdg)
        {
            return db.HANG_HOA.Where(p => p.QUY_CACH_DONG_GOI.StartsWith(qcdg)).ToList();
        }

        public void AddUpdateDMSP(HANG_HOA dmsp)
        {
            List<HANG_HOA> dsHH = db.HANG_HOA.Where(p => p.TEN_SP == dmsp.TEN_SP).ToList();
            HANG_HOA existingHH = dsHH.FirstOrDefault(p => p.SO_LO.Trim(' ') == dmsp.SO_LO);
            if (dsHH is null)
            {
                db.HANG_HOA.Add(dmsp);
            }
            else
            {
                if (existingHH is null)
                {

                    dmsp.MA_SP = dsHH.FirstOrDefault().MA_SP;
                    db.HANG_HOA.Add(dmsp);
                }
                else
                {
                    existingHH.TONG_TON += dmsp.TONG_TON;
                }
            }

            db.SaveChanges();
        }

        public HANG_HOA GetTenSP(string masp)
        {
            HANG_HOA sp = db.HANG_HOA.SingleOrDefault(p => p.MA_SP == masp);
            return sp;
        }

        public List<HANG_HOA> GetDVTCB()
        {
            return db.HANG_HOA.GroupBy(p => p.DVT_CO_BAN).Select(g => g.FirstOrDefault()).ToList();
        }

    }
}
