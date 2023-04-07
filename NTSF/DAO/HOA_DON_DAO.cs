using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class HOA_DON_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static HOA_DON_DAO instance;
        public static HOA_DON_DAO Instance
        {
            get { if (instance == null) instance = new HOA_DON_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<HOA_DON> GetHOA_DONs()
        {
            return db.HOA_DON.ToList();
        }

        public void RemoveHD(string mahd)
        {
            HOA_DON hd = db.HOA_DON.AsNoTracking().SingleOrDefault(p => p.MA_HD == mahd);
            db.HOA_DON.Remove(hd);
            db.SaveChanges();
        }
        
    }
}
