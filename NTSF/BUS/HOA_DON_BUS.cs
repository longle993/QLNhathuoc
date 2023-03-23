using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class HOA_DON_BUS
    {
     
        private static HOA_DON_BUS instance;
        public static HOA_DON_BUS Instance
        {
            get { if (instance == null) instance = new HOA_DON_BUS(); return instance; }
            private set { instance = value; }
        }
        public List<HOA_DON> GetHOA_DONs()
        {
            return HOA_DON_DAO.Instance.GetHOA_DONs();
        }
    }
}
