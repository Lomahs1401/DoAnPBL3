using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    // Quản lý hóa đơn
    class BLL_QLHD
    {
        private static BLL_QLHD _Instance;
        public static BLL_QLHD Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLHD();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLHD()
        {

        }

        public List<Order> GetOrdersByIDCustomer(string ID_Customer)
        {
            return DAL_QLHD.Instance.GetListOrderByIDCustomer(ID_Customer);
        }

        public List<Order> GetOrdersByEmployee(string nameEmployee, string ID_Customer)
        {
            return DAL_QLHD.Instance.GetListOrderByEmployee(nameEmployee, ID_Customer);
        }

        public Order GetOrderByID(string ID_Order)
        {
            return DAL_QLHD.Instance.GetOrderByID(ID_Order);
        }

        public int GetNumberTotalOrderByIDCustomer(string ID_Customer)
        {
            return DAL_QLHD.Instance.GetNumberTotalOrderByIDCustomer(ID_Customer);
        }
        
        public int GetNumberTotalPriceByIDCustomer(string ID_Customer)
        {
            return DAL_QLHD.Instance.GetNumberTotalPriceByIDCustomer(ID_Customer);
        }

        public List<OrderDetail> GetOrderDetailsByIDOrder(string ID_Order)
        {
            return DAL_QLHD.Instance.GetOrderDetailsByIDOrder(ID_Order);
        }

        public int GetTotalQuantity(string ID_Order)
        {
            return DAL_QLHD.Instance.GetTotalQuantity(ID_Order);
        }

        public int GetTotalAmount(string ID_Order)
        {
            return DAL_QLHD.Instance.GetTotalAmount(ID_Order);
        }
        
        public string GetLastID()
        {
            return DAL_QLHD.Instance.GetLastID();
        }

        public string CreateNewOrderID(string lastID_Order)
        {
            StringBuilder newOrderID;
            if (lastID_Order == null)
            {
                newOrderID = new StringBuilder("HD0000");
                return newOrderID.ToString();
            }
            else
            {
                string id = lastID_Order; // HD0001
                string code = id.Substring(2, id.Length - 2); // 0001
                int num = Convert.ToInt32(code); // 1
                num++; // 1 + 1 -> 2
                string numStr = num.ToString(); // "2"
                int lenNumStr = numStr.Length; // 1
                newOrderID = new StringBuilder(id.Remove(id.Length - lenNumStr, lenNumStr));// HD000
                newOrderID.Append(numStr); // HD000 + 2 => HD0002
                return newOrderID.ToString();
            }
        }

        public bool AddOrder(Order order)
        {
            if (DAL_QLHD.Instance.AddOrder(order))
                return true;
            else
                return false;
        }

        public bool AddOrderDetail(OrderDetail orderDetail)
        {
            if (DAL_QLHD.Instance.AddOrderDetail(orderDetail))
                return true;
            else
                return false;
        }

        public string[] ShowOrderInfo(string ID_Order)
        {
            return DAL_QLHD.Instance.ShowOrderInfo(ID_Order);
        }

        public string[][] ShowOrderTable(string ID_Order)
        {
            return DAL_QLHD.Instance.ShowOrderTable(ID_Order);
        }
    }
}
