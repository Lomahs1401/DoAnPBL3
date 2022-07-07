using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    // Quản lý khách hàng
    class BLL_QLKH
    {
        private static BLL_QLKH _Instance;
        public static BLL_QLKH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLKH();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLKH()
        {

        }

        public List<Customer> GetCustomers()
        {
            return DAL_QLKH.Instance.GetListCustomers();
        }

        public List<Customer> GetMaleCustomers()
        {
            return DAL_QLKH.Instance.GetListMaleCustomers();
        }

        public List<Customer> GetFemaleCustomers()
        {
            return DAL_QLKH.Instance.GetListFemaleCustomers();
        }

        public List<Customer> GetCustomersByName(string name)
        {
            return DAL_QLKH.Instance.GetCustomersByName(name);
        }

        public Customer GetCustomerByID(string ID_Customer)
        {
            return DAL_QLKH.Instance.GetCustomerByID(ID_Customer);
        }

        public Customer GetCustomerByPhone(string phone)
        {
            return DAL_QLKH.Instance.GetCustomerByPhone(phone);
        }


        public int GetNumberTotalCustomer()
        {
            return DAL_QLKH.Instance.GetNumberTotalCustomer();
        }

        public int GetNumberTotalMaleCustomer()
        {
            return DAL_QLKH.Instance.GetNumberTotalMaleCustomer();
        }

        public int GetNumberTotalFemaleCustomer()
        {
            return DAL_QLKH.Instance.GetNumberTotalFemaleCustomer();
        }

        public DateTime GetStartDate(string ID_Customer)
        {
            return DAL_QLKH.Instance.GetStartDate(ID_Customer);
        }
    }
}
