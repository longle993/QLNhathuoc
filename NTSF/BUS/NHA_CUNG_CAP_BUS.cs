using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class NHA_CUNG_CAP_BUS
    {
        private static NHA_CUNG_CAP_BUS instance;
        public static NHA_CUNG_CAP_BUS Instance
        {
            get { if (instance == null) instance = new NHA_CUNG_CAP_BUS(); return instance; }
            private set { instance = value; }
        }

        public List<NHA_CUNG_CAP> GetNHA_CUNG_CAPs()
        {
            return NHA_CUNG_CAP_DAO.Instance.GetNHA_CUNG_CAPs();
        }

        public List<NHA_CUNG_CAP> FindByName(string tenncc)
        {
            return NHA_CUNG_CAP_DAO.Instance.FindByName(tenncc);
        }
    }
}
