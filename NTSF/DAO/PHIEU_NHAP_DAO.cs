using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class PHIEU_NHAP_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static PHIEU_NHAP_DAO instance;
        public static PHIEU_NHAP_DAO Instance
        {
            get { if (instance == null) instance = new PHIEU_NHAP_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<PHIEU_NHAP> GetPHIEU_NHAPs()
        {
            return db.PHIEU_NHAP.ToList();
        }

        public void AddUpdatePN(PHIEU_NHAP pn)
        {
            try
            {
                // Kiểm tra xem nhân viên đã tồn tại trong cơ sở dữ liệu chưa
                PHIEU_NHAP existingPN = db.PHIEU_NHAP.AsNoTracking().SingleOrDefault(p => p.MA_PHIEU == pn.MA_PHIEU);

                if (existingPN is null)
                {
                    db.PHIEU_NHAP.Add(pn);
                }
                else
                {
                    db.PHIEU_NHAP.Remove(existingPN);
                    db.PHIEU_NHAP.Add(pn);

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

        public List<PHIEU_NHAP> FindByMaPN(string mapn)
        {
            return db.PHIEU_NHAP.Where(p => p.MA_PHIEU.StartsWith(mapn)).ToList();
        }
        public List<PHIEU_NHAP> FindByName(string tensp, string mapn, DateTime timeFrom, DateTime timeTo)
        {
            DANH_MUC_SP sP = db.DANH_MUC_SP.SingleOrDefault(p => p.TEN_SP.StartsWith(tensp));
            List<CT_PHIEU_NHAP> CTPN = db.CT_PHIEU_NHAP.Where(p => p.MA_SP == sP.MA_SP).ToList();

            List<PHIEU_NHAP> pN = new List<PHIEU_NHAP>();
            foreach (CT_PHIEU_NHAP ct in CTPN)
            {
                pN.Add(db.PHIEU_NHAP.Find(ct.MA_PHIEU));
            }
            if (mapn == "")
            {
                return pN;
            }
            else
            {
                return pN.Where(p => p.MA_PHIEU.StartsWith(mapn) && p.NGAY_NHAP >= timeFrom && p.NGAY_NHAP <= timeTo).ToList();
            }
        }
        public List<PHIEU_NHAP> GetBaoCao(DateTime timeFrom, DateTime timeTo)
        {
            return db.PHIEU_NHAP.Where(p => p.NGAY_NHAP >= timeFrom && p.NGAY_NHAP <= timeTo).ToList();
        }
    }
}
