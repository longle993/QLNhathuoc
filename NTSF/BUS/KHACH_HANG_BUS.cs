using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class KHACH_HANG_BUS
    {
        private static KHACH_HANG_DAO instance;
        public static KHACH_HANG_DAO Instance
        {
            get { if (instance == null) instance = new KHACH_HANG_DAO(); return instance; }
            private set { instance = value; }
        }
        public List<KHACH_HANG> GetKHACH_HANGs()
        {
            return KHACH_HANG_DAO.Instance.GetKHACH_HANGs();
        }

        public List<KHACH_HANG> FindByPhone(string SDT)
        {
            return KHACH_HANG_DAO.Instance.FindByPhone(SDT);
        }

        public List<KHACH_HANG> FindByName(string TENKH)
        {
            return KHACH_HANG_DAO.Instance.FindByName(TENKH);
        }
        public void AddUpdateKH(KHACH_HANG kh)
        {
            KHACH_HANG_DAO.Instance.AddUpdateKH(kh);
        }

        public void RemoveKH(KHACH_HANG KH)
        {
            KHACH_HANG_DAO.Instance.RemoveKH(KH);
        }

    }
}
