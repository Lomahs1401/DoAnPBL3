using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // Quản lý doanh thu
    class DAL_QLDT
    {
        private static DAL_QLDT _Instance;
        public static DAL_QLDT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLDT();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLDT()
        {

        }

        public int GetNumCustomers()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Customers.Count();
            }
        }
        
        public int GetNumSellBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.OrderDetails
                    .Select(book => book.Quantity)
                    .Sum();
            }
        }

        public int GetNumRemainingBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Select(book => book.Quantity)
                    .Sum();
            }
        }

        public int GetNumOrders(DateTime startDate, DateTime endDate)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Orders
                    .Where(order => order.OrderDate >= startDate)
                    .Where(order => order.OrderDate <= endDate)
                    .Count();
            }
        }
    }
}
