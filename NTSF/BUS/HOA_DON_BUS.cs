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
        public void RemoveHD(string mahd)
        {
            HOA_DON_DAO.Instance.RemoveHD(mahd);
        }

        public List<HOA_DON> FindByName(string tensp, string mahd, DateTime timeFrom, DateTime timeTo)
        {
            return HOA_DON_DAO.Instance.FindByName(tensp, mahd,timeFrom,timeTo);
        }
        public HOA_DON GetHDforCTHD(string mahd)
        {
            return HOA_DON_DAO.Instance.GetHDforCTHD(mahd);
        }
        public void AddOrUpdate(HOA_DON hd)
        {
            HOA_DON_DAO.Instance.AddOrUpdate(hd);
        }

        public List<HOA_DON> FindByMaHD(string mahd)
        {
            return HOA_DON_DAO.Instance.FindByMaHD(mahd);
        }
        public List<HOA_DON> GetBaoCao(DateTime timeFrom, DateTime timeTo)
        {
            return HOA_DON_DAO.Instance.GetBaoCao(timeFrom, timeTo);
        }
    }
}
