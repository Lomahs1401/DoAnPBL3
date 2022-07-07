using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // QUản lý nhân viên
    class DAL_QLNV
    {
        private static DAL_QLNV _Instance;
        public static DAL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLNV();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLNV()
        {

        }

        public List<Employee> GetListEmployees()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Employee> employees = new List<Employee>();
                employees = db.Employees
                    .Where(employee => employee.WorkStatus == true)
                    .Select(employee => employee)
                    .ToList();
                if (employees.Count > 0)
                    return employees;
                else
                    return null;
            }
        }

        public List<Employee> GetListMaleEmployees()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Employee> employees = new List<Employee>();
                employees = db.Employees
                    .Where(employee => employee.WorkStatus == true)
                    .Where(employee => employee.Gender == "Nam")
                    .Select(employee => employee)
                    .ToList();
                if (employees.Count > 0)
                    return employees;
                else
                    return null;
            }
        }

        public List<Employee> GetListFemaleEmployees()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Employee> employees = new List<Employee>();
                employees = db.Employees
                    .Where(employee => employee.WorkStatus == true)
                    .Where(employee => employee.Gender == "Nữ")
                    .Select(employee => employee)
                    .ToList();
                if (employees.Count > 0)
                    return employees;
                else
                    return null;
            }
        }

        public List<Employee> GetListEmployeesQuitJob()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Employee> employeesQuitJob = new List<Employee>();
                employeesQuitJob = db.Employees
                    .Where(employee => employee.WorkStatus == false)
                    .Select(employee => employee)
                    .ToList();
                if (employeesQuitJob.Count > 0)
                    return employeesQuitJob;
                else
                    return null;
            }
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Employee> employees = new List<Employee>();
                employees = db.Employees
                    .Where(emp => emp.WorkStatus == true)
                    .Where(employee => employee.FullNameEmployee.Contains(name))
                    .ToList();
                if (employees.Count > 0)
                    return employees;
                else
                    return null;
            }
        }

        public Employee GetEmployeeByID(string ID_Employee)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Employee employee = db.Employees
                    .Where(emp => emp.ID_Employee == ID_Employee)
                    .FirstOrDefault();
                if (employee == null)
                    return null;
                else
                    return employee;
            }
        }

        public Employee GetEmployeeByPhone(string phone)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Employee employee = db.Employees
                    .Where(emp => emp.WorkStatus == true)
                    .Where(emp => emp.Phone == phone)
                    .ToList()
                    .FirstOrDefault();
                if (employee == null)
                    return null;
                else
                    return employee;
            }
        }

        public string GetAvatar(string accountUsername)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                var avatar = db.Accounts
                    .Where(account => account.Username == accountUsername)
                    .Select(account => new { account.Avatar })
                    .ToList()
                    .FirstOrDefault();
                if (avatar.Avatar == DBNull.Value.ToString())
                    return null;
                else
                    return avatar.Avatar;
            }
        }

        public string GetNameEmployeeByID(string ID_Employee)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(emp => emp.ID_Employee == ID_Employee)
                    .Select(emp => new { emp.FullNameEmployee })
                    .FirstOrDefault()
                    .FullNameEmployee;
            }
        }

        public string GetAccountUsernameByID(string ID_Employee)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                var username = db.Employees
                    .Where(emp => emp.ID_Employee == ID_Employee)
                    .Where(emp => emp.WorkStatus == true)
                    .Select(emp => new { emp.AccountUsername })
                    .FirstOrDefault();
                return username.AccountUsername;
            }
        }

        public string GetIDByAccountUsername(string accountUsername)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(employee => employee.AccountUsername == accountUsername)
                    .Where(emp => emp.WorkStatus == true)
                    .Select(employee => new { employee.ID_Employee })
                    .FirstOrDefault()
                    .ID_Employee;
            }
        }

        public int GetNumberTotalEmployee()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(employee => employee.WorkStatus == true)
                    .Count();
            }
        }

        public int GetNumberTotalMaleEmployee()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(employee => employee.WorkStatus == true)
                    .Where(employee => employee.Gender == "Nam")
                    .Count();
            }
        }

        public int GetNumberTotalFemaleEmployee()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(employee => employee.WorkStatus == true)
                    .Where(employee => employee.Gender == "Nữ")
                    .Count();
            }
        }

        public int GetNumberTotalEmployeeQuitJob()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(employee => employee.WorkStatus == false)
                    .Count();
            }
        }

        public int GetNumberTotalMaleEmployeeQuitJob()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(employee => employee.WorkStatus == false)
                    .Where(employee => employee.Gender == "Nam")
                    .Count();
            }
        }

        public int GetNumberTotalFemaleEmployeeQuitJob()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Employees
                    .Where(employee => employee.WorkStatus == false)
                    .Where(employee => employee.Gender == "Nữ")
                    .Count();
            }
        }

        public string GetLastID()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                var lastID = db.Employees
                    .Where(emp => emp.WorkStatus == true)
                    .Select(employee => new { employee.ID_Employee })
                    .OrderByDescending(employee => employee.ID_Employee)
                    .Take(1)
                    .ToList()
                    .FirstOrDefault();
                if (lastID == null)
                    return null;
                else
                    return lastID.ID_Employee;
            }
        }

        public bool AddEmployee(Employee employee)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                db.Employees.Add(employee);
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public bool UpdateEmployee(Employee newInfoEmployee)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Employee oldEmployee = db.Employees.Find(newInfoEmployee.ID_Employee);
                oldEmployee.FullNameEmployee = newInfoEmployee.FullNameEmployee;
                oldEmployee.Email = newInfoEmployee.Email;
                oldEmployee.DateOfBirth = newInfoEmployee.DateOfBirth;
                oldEmployee.StartDate = newInfoEmployee.StartDate;
                oldEmployee.EndDate = null;
                oldEmployee.Gender = newInfoEmployee.Gender;
                oldEmployee.Phone = newInfoEmployee.Phone;
                oldEmployee.Id_Card = newInfoEmployee.Id_Card;
                oldEmployee.Address = newInfoEmployee.Address;
                oldEmployee.Avatar = newInfoEmployee.Avatar;
                oldEmployee.AccountUsername = newInfoEmployee.AccountUsername; 
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public bool DeleteEmployee(string ID_Employee)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Employee employee = db.Employees.Find(ID_Employee);
                employee.EndDate = DateTime.Now;
                employee.WorkStatus = false;
                int result = db.SaveChanges();
                return result > 0;
            }
        }
    }
}
