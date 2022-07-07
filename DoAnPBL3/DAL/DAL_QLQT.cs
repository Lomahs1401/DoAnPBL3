using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    class DAL_QLQT
    {
        private static DAL_QLQT _Instance;
        public static DAL_QLQT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLQT();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLQT()
        {

        }

        public string GetIDByAccountUsername(string accountUsername)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Admins
                    .Where(admin => admin.AccountUsername == accountUsername)
                    .FirstOrDefault()
                    .AccountUsername;
            }
        }
    }
}
