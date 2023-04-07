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

        public void RemoveCTHD(string mahoadon)
        {
            CT_HOA_DON cthd = db.CT_HOA_DON.AsNoTracking().SingleOrDefault(p => p.MA_HD == mahoadon);
            db.CT_HOA_DON.Remove(cthd);
            db.SaveChanges();
        }

        
    }
}
