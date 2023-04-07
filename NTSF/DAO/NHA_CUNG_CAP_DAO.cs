using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class NHA_CUNG_CAP_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static NHA_CUNG_CAP_DAO instance;
        public static NHA_CUNG_CAP_DAO Instance
        {
            get { if (instance == null) instance = new NHA_CUNG_CAP_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<NHA_CUNG_CAP> GetNHA_CUNG_CAPs()
        {
            return db.NHA_CUNG_CAP.ToList();
        }

        public List<NHA_CUNG_CAP> FindByName(string tenncc)
        {
            return db.NHA_CUNG_CAP.Where(p => p.TEN_NCC.StartsWith(tenncc)).ToList();
        }

        public void AddUpdateNCC(NHA_CUNG_CAP ncc)
        {
            try
            {
                // Kiểm tra xem nhân viên đã tồn tại trong cơ sở dữ liệu chưa
                NHA_CUNG_CAP existingNCC = db.NHA_CUNG_CAP.Find(ncc);

                if (existingNCC is null)
                {
                    db.NHA_CUNG_CAP.Add(ncc);
                }
                else
                {
                    db.NHA_CUNG_CAP.Remove(existingNCC);
                    db.NHA_CUNG_CAP.Add(ncc);

                }

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveNCC(NHA_CUNG_CAP ncc)
        {
            db.NHA_CUNG_CAP.Remove(ncc);
            db.SaveChanges();
        }
    }
}
