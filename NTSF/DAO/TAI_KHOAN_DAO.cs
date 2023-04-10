using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTSF.DTO;

namespace NTSF.DAO
{
    class TAI_KHOAN_DAO
    {
        NhaThuoc db = new NhaThuoc();
        private static TAI_KHOAN_DAO instance;
        public static TAI_KHOAN_DAO Instance
        {
            get { if (instance == null) instance = new TAI_KHOAN_DAO(); return instance; }
            private set { instance = value; }
        }

        public TAI_KHOAN checkTaiKhoan(string email,string password)
        {
            return db.TAI_KHOAN.Where(p => p.TEN_TK == email && p.PASSWORD == password).SingleOrDefault();
        }
        public TAI_KHOAN checkEmail(string email)
        {
            return db.TAI_KHOAN.Where(p => p.TEN_TK == email).SingleOrDefault();
        }

        public void AddOrUpdate(string email,string newpassword)
        {
            TAI_KHOAN existingTK = db.TAI_KHOAN.Find(email);
            TAI_KHOAN tAI_KHOAN = new TAI_KHOAN();
            tAI_KHOAN.TEN_TK = email;
            tAI_KHOAN.PASSWORD = newpassword;
            db.TAI_KHOAN.Remove(existingTK);
            db.TAI_KHOAN.Add(tAI_KHOAN);
            db.SaveChanges();
        }
    }
}
