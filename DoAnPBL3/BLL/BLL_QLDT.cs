using DoAnPBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    // Quản lý doanh thu
    class BLL_QLDT
    {
        private static BLL_QLDT _Instance;
        public static BLL_QLDT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLDT();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLDT()
        {

        }

        public int GetNumCustomers()
        {
            return DAL_QLDT.Instance.GetNumCustomers();
        }

        public int GetNumSellBooks()
        {
            return DAL_QLDT.Instance.GetNumSellBooks();
        }

        public int GetNumRemainingBooks()
        {
            return DAL_QLDT.Instance.GetNumRemainingBooks();
        }

        public int GetNumOrders(DateTime startDate, DateTime endDate)
        {
            return DAL_QLDT.Instance.GetNumOrders(startDate, endDate);
        }
    }
}
