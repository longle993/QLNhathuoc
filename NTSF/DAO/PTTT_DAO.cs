using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class PTTT_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static PTTT_DAO instance;
        public static PTTT_DAO Instance
        {
            get { if (instance == null) instance = new PTTT_DAO(); return instance; }
            private set { instance = value; }
        }

        public List<PTTT> GetPTTTs()
        {
            return db.PTTTs.ToList();
        }
    }
}
