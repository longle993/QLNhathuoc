using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class PTTT_BUS
    {
        private static PTTT_BUS instance;
        public static PTTT_BUS Instance
        {
            get { if (instance == null) instance = new PTTT_BUS(); return instance; }
            private set { instance = value; }
        }

        public List<PTTT> GetPTTTs()
        {
            return PTTT_DAO.Instance.GetPTTTs();
        }
    }
}
