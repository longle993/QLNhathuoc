using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class DON_VI_TINH_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static DON_VI_TINH_DAO instance;

        public static DON_VI_TINH_DAO Instance
        {
            get { if (instance == null) instance = new DON_VI_TINH_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<DON_VI_TINH> GetDON_VI_TINHs()
        {
            return db.DON_VI_TINH.GroupBy(p => p.DVT_KHAC).Select(g=>g.FirstOrDefault()).ToList();
        }

        public void AddOrUpdateDVT(DON_VI_TINH dvt)
        {
            try
            {
                DON_VI_TINH existingDVT = db.DON_VI_TINH.AsNoTracking().SingleOrDefault(p => p.DVT_KHAC == dvt.DVT_KHAC && p.SO_LO == dvt.SO_LO);
                if(existingDVT is null)
                {
                    db.DON_VI_TINH.Add(dvt);
                }
                else
                {
                    db.DON_VI_TINH.Remove(existingDVT);
                    db.DON_VI_TINH.Add(dvt);
                }
                db.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
