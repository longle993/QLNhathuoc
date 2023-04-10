using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;
using NTSF.DAO;

namespace NTSF.BUS
{
    class TAI_KHOAN_BUS
    {
        private static TAI_KHOAN_BUS instance;
        public static TAI_KHOAN_BUS Instance
        {
            get { if (instance == null) instance = new TAI_KHOAN_BUS(); return instance; }
            private set { instance = value; }
        }

        public TAI_KHOAN checkTaiKhoan(string email, string password)
        {
            return TAI_KHOAN_DAO.Instance.checkTaiKhoan(email, password);
        }
        public TAI_KHOAN checkEmail(string email)
        {
            return TAI_KHOAN_DAO.Instance.checkEmail(email);
        }
        public void AddOrUpdate(string email, string newpassword)
        {
            TAI_KHOAN_DAO.Instance.AddOrUpdate(email, newpassword);
        }
    }
}
