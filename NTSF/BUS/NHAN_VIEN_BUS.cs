using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class NHAN_VIEN_BUS
    {
        private static NHAN_VIEN_BUS instance;
        public static NHAN_VIEN_BUS Instance
        {
            get { if (instance == null) instance = new NHAN_VIEN_BUS(); return instance; }
            private set { instance = value; }
        }

        public List<NHAN_VIEN> GetNHAN_VIENs()
        {
            return NHAN_VIEN_DAO.Instance.GetNHAN_VIENs();
        }
        public List<NHAN_VIEN> FindByName(string TENNV)
        {
            return NHAN_VIEN_DAO.Instance.FindByName(TENNV);
        }
        public void AddUpdateNV(NHAN_VIEN nv)
        {
            NHAN_VIEN_DAO.Instance.AddUpdateNV(nv);
        }
        public void RemoveNV(NHAN_VIEN nv)
        {
            NHAN_VIEN_DAO.Instance.RemoveNV(nv);
        }
        public List<NHAN_VIEN> FindBySDT(string sdt)
        {
            return NHAN_VIEN_DAO.Instance.FindBySDT(sdt);
        }

    }
}
