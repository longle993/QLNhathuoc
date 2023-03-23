using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class CT_HOA_DON_DAO
    {
        private static CT_HOA_DON_DAO instance;
        public static CT_HOA_DON_DAO Instance
        {
            get { if (instance == null) instance = new CT_HOA_DON_DAO(); return instance; }
            private set { instance = value; }
        }

    }
}
