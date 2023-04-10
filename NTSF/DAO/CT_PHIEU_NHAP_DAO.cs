using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class CT_PHIEU_NHAP_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static CT_PHIEU_NHAP_DAO instance;
        public static CT_PHIEU_NHAP_DAO Instance
        {
            get { if (instance == null) instance = new CT_PHIEU_NHAP_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<CT_PHIEU_NHAP> GetCT_PHIEU_NHAPs()
        {
            return db.CT_PHIEU_NHAP.ToList();
        }

        public void AddUpdateCTPN(CT_PHIEU_NHAP ctpn)
        {
            try
            {
                // Kiểm tra xem nhân viên đã tồn tại trong cơ sở dữ liệu chưa
                CT_PHIEU_NHAP existingCTPN = db.CT_PHIEU_NHAP.AsNoTracking().SingleOrDefault(p => p.MA_PHIEU == ctpn.MA_PHIEU);

                if (existingCTPN is null)
                {
                    db.CT_PHIEU_NHAP.Add(ctpn);
                }
                else
                {
                    db.CT_PHIEU_NHAP.Remove(existingCTPN);
                    db.CT_PHIEU_NHAP.Add(ctpn);

                }

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                // Ví dụ: ghi log hoặc thông báo cho người dùng
                Console.WriteLine(ex.Message);
            }
        }

        public List<CT_PHIEU_NHAP> GetHSDUnder3()
        {
            return db.CT_PHIEU_NHAP.Where(p => p.HSD <= DateTime.Now).ToList();
        }
    }
}
