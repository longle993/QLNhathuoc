using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class NHAN_VIEN_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static NHAN_VIEN_DAO instance;
        public static NHAN_VIEN_DAO Instance
        {
            get { if (instance == null) instance = new NHAN_VIEN_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<NHAN_VIEN> GetNHAN_VIENs()
        {
            return db.NHAN_VIEN.ToList();
        }

        public List<NHAN_VIEN> FindByName(string TENNV)
        {
             return db.NHAN_VIEN.Where(p => p.TEN_NV.StartsWith(TENNV)).ToList();
        }

        public void AddUpdateNV(NHAN_VIEN nv)
        {
            try
            {
                // Kiểm tra xem nhân viên đã tồn tại trong cơ sở dữ liệu chưa
                NHAN_VIEN existingNV = db.NHAN_VIEN.AsNoTracking().SingleOrDefault(p => p.SDT == nv.SDT);

                if (existingNV is null)
                {
                    db.NHAN_VIEN.Add(nv);
                }
                else
                {
                    db.NHAN_VIEN.Remove(existingNV);
                    db.NHAN_VIEN.Add(nv);

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

        public void RemoveNV(NHAN_VIEN nv)
        {
            db.NHAN_VIEN.Remove(nv);
            db.SaveChanges();
        }
    }
}
