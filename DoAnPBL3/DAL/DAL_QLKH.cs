using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // Quản lý khách hàng
    class DAL_QLKH
    {
        private static DAL_QLKH _Instance;
        public static DAL_QLKH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLKH();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLKH()
        {

        }

        public List<Customer> GetListCustomers()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Customer> customers = new List<Customer>();
                customers = db.Customers
                    .Select(employee => employee)
                    .ToList();
                if (customers.Count > 0)
                    return customers;
                else
                    return null;
            }
        }

        public List<Customer> GetListMaleCustomers()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Customer> maleCustomers = new List<Customer>();
                maleCustomers = db.Customers
                    .Where(customer => customer.Gender == "Nam")
                    .Select(employee => employee)
                    .ToList();
                if (maleCustomers.Count > 0)
                    return maleCustomers;
                else
                    return null;
            }
        }

        public List<Customer> GetListFemaleCustomers()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Customer> femaleCustomers = new List<Customer>();
                femaleCustomers = db.Customers
                    .Where(customer => customer.Gender == "Nữ")
                    .Select(employee => employee)
                    .ToList();
                if (femaleCustomers.Count > 0)
                    return femaleCustomers;
                else
                    return null;
            }
        }

        public List<Customer> GetCustomersByName(string name)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Customer> customer = new List<Customer>();
                customer = db.Customers
                    .Where(cus => cus.FullNameCustomer.Contains(name))
                    .ToList();
                if (customer.Count > 0)
                    return customer;
                else
                    return null;
            }
        }

        public Customer GetCustomerByID(string ID_Customer)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Customer customer = db.Customers
                    .Where(cus => cus.ID_Customer == ID_Customer)
                    .ToList()
                    .FirstOrDefault();
                if (customer == null)
                    return null;
                else
                    return customer;
            }
        }

        public Customer GetCustomerByPhone(string phone)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Customer customer = db.Customers
                    .Where(cus => cus.Phone == phone)
                    .ToList()
                    .FirstOrDefault();
                if (customer == null)
                    return null;
                else
                    return customer;
            }
        }

        public int GetNumberTotalCustomer()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Customers.Count();
            }
        }

        public int GetNumberTotalMaleCustomer()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Customers
                    .Where(customer => customer.Gender == "Nam")
                    .Count();
            }
        }

        public int GetNumberTotalFemaleCustomer()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Customers
                    .Where(customer => customer.Gender == "Nữ")
                    .Count();
            }
        }

        public DateTime GetStartDate(string ID_Customer)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Orders
                    .Where(order => order.ID_Customer == ID_Customer)
                    .OrderBy(order => order.OrderDate)
                    .Select(order => order.OrderDate)
                    .FirstOrDefault();
            }
        }
    }
}
