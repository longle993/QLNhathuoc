using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class CT_HOA_DON_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static CT_HOA_DON_DAO instance;
        public static CT_HOA_DON_DAO Instance
        {
            get { if (instance == null) instance = new CT_HOA_DON_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<CT_HOA_DON> GetCT_HOA_DONs(string mahoadon)
        {
            return db.CT_HOA_DON.Where(p=>p.MA_HD == mahoadon).ToList();
        }

        public List<CT_HOA_DON> GetAll()
        {
            return db.CT_HOA_DON.ToList();
        }
        public void RemoveCTHD(string mahoadon)
        {
            CT_HOA_DON cthd = db.CT_HOA_DON.AsNoTracking().SingleOrDefault(p => p.MA_HD == mahoadon);
            db.CT_HOA_DON.Remove(cthd);
            db.SaveChanges();
        }

        public void AddOrUpdateCHTD(CT_HOA_DON cthd)
        {
                CT_HOA_DON existingCTHD = db.CT_HOA_DON.AsNoTracking().SingleOrDefault(p => p.MA_HD == cthd.MA_HD && p.MA_SP == cthd.MA_SP && p.SO_LO == cthd.SO_LO);
                if(existingCTHD is null)
                {
                    db.CT_HOA_DON.Add(cthd);
                }
                else
                {
                    db.CT_HOA_DON.Remove(existingCTHD);
                    db.CT_HOA_DON.Add(cthd);
                }
                db.SaveChanges();
        }
    }
}
