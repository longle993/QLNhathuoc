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
    }
}
