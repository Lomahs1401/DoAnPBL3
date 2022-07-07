using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // Quản lý tài khoản
    class DAL_QLTK
    {
        private static DAL_QLTK _Instance;
        public static DAL_QLTK Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLTK();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLTK()
        {

        }

        public bool AddNewAccount(Account account)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                db.Accounts.Add(account);
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public bool SaveNewInfo(Account account)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Account acc = db.Accounts.Find(account.Username);
                acc.Password = account.Password;
                acc.Avatar = account.Avatar;
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public string GetImage(string accountUsername)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                var image = db.Accounts
                    .Where(account => account.Username == accountUsername)
                    .Select(account => new { account.Avatar })
                    .FirstOrDefault();
                return image.Avatar;
            }
        }
    }
}
