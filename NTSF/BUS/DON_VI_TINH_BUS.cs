using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DAO;
using NTSF.DTO;

namespace NTSF.BUS
{
    class DON_VI_TINH_BUS
    {
        private static DON_VI_TINH_DAO instance;

        public static DON_VI_TINH_DAO Instance
        {
            get { if (instance == null) instance = new DON_VI_TINH_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<DON_VI_TINH> GetDON_VI_TINHs()
        {
            return DON_VI_TINH_DAO.Instance.GetDON_VI_TINHs();
        }
        public void AddOrUpdateDVT(DON_VI_TINH dvt)
        {
            DON_VI_TINH_DAO.Instance.AddOrUpdateDVT(dvt);
        }
    }
}
