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

        public List<HOA_DON> FindByName(string tensp, string mahd, DateTime timeFrom, DateTime timeTo)
        {
            DANH_MUC_SP sP = db.DANH_MUC_SP.SingleOrDefault(p => p.TEN_SP.StartsWith(tensp));
            List<CT_HOA_DON> cthd = db.CT_HOA_DON.Where(p => p.MA_SP == sP.MA_SP).ToList();

            List<HOA_DON> hoadon = new List<HOA_DON>();
            foreach(CT_HOA_DON ct in cthd)
            {
                hoadon.Add(db.HOA_DON.Find(ct.MA_HD));
            }
            if (mahd == "")
            {
                return hoadon;
            }
            else
            {
                return hoadon.Where(p => p.MA_HD.StartsWith(mahd) && p.NGAY_HD >= timeFrom && p.NGAY_HD <= timeTo).ToList();
            }
        }

        public HOA_DON GetHDforCTHD(string mahd)
        {
            return db.HOA_DON.SingleOrDefault(p => p.MA_HD == mahd);
        }

        public void AddOrUpdate(HOA_DON hd)
        {
            try
            {
                // Kiểm tra xem nhân viên đã tồn tại trong cơ sở dữ liệu chưa
                HOA_DON existingHD = db.HOA_DON.AsNoTracking().SingleOrDefault(p => p.MA_HD == hd.MA_HD);

                if (existingHD is null)
                {
                    db.HOA_DON.Add(hd);
                }
                else
                {
                    db.HOA_DON.Remove(existingHD);
                    db.HOA_DON.Add(hd);
                }

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<HOA_DON> FindByMaHD(string mahd)
        {
            return db.HOA_DON.Where(p => p.MA_HD.StartsWith(mahd)).ToList();
        }

        public List<HOA_DON> GetBaoCao(DateTime timeFrom, DateTime timeTo)
        {
            return db.HOA_DON.Where(p => p.NGAY_HD >= timeFrom && p.NGAY_HD <= timeTo).ToList();
        }

        public List<HOA_DON> GetTongQuan(DateTime date)
        {
            return db.HOA_DON.Where(p => p.NGAY_HD.Month <= date.Month && p.NGAY_HD.Month >= date.Month -1).ToList();
        }
    }
}
