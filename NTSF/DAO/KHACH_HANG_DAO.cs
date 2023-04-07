using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class KHACH_HANG_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static KHACH_HANG_DAO instance;
        public static KHACH_HANG_DAO Instance
        {
            get { if (instance == null) instance = new KHACH_HANG_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<KHACH_HANG> GetKHACH_HANGs()
        {
            return db.KHACH_HANG.ToList();
        }

        public List<KHACH_HANG> FindByPhone(string SDT)
        {
            return db.KHACH_HANG.Where(p => p.SDT.StartsWith(SDT)).ToList();
        }

        public List<KHACH_HANG> FindByName(string TENKH)
        {
            return db.KHACH_HANG.Where(p => p.TEN_KH.StartsWith(TENKH)).ToList();
        }

        public void AddUpdateKH(KHACH_HANG kh)
        {
            try
            {
                // Kiểm tra xem nhân viên đã tồn tại trong cơ sở dữ liệu chưa
                KHACH_HANG existingKH = db.KHACH_HANG.AsNoTracking().SingleOrDefault(p => p.SDT == kh.SDT);
                if (existingKH is null)
                {
                    db.KHACH_HANG.Add(kh);
                }
                else
                {
                    db.KHACH_HANG.Remove(existingKH);
                    db.KHACH_HANG.Add(kh);
                }
                db.SaveChanges();
            }

            catch (Exception)
            {

            }
        }

        public void RemoveKH(KHACH_HANG KH)
        {
            db.KHACH_HANG.Remove(KH);
            db.SaveChanges();
        }
    }
}
