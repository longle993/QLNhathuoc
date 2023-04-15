using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;
namespace NTSF.BUS
{
    class GIA_VON_BUS
    {
        private static GIA_VON_DAO instance;
        public static GIA_VON_DAO Instance
        {
            get { if (instance == null) instance = new GIA_VON_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<GIA_VON> GetGIA_VONs()
        {
            return GIA_VON_DAO.Instance.GetGIA_VONs();
        }
    }
}
