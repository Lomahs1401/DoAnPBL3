using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3
{
    public class CreateAdminAndEmployee : CreateDatabaseIfNotExists<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            context.Accounts.AddRange(new Account[]
            {
                new Account {Username = "lehoanglong", Password = "lehoanglong", Email = "lelong.ll32@gmail.com", Role = EnumRole.Admin.ToString()},
                new Account {Username = "nguyenkhacthai", Password = "nguyenkhacthai", Email = "zed999cz@gmail.com", Role = EnumRole.Admin.ToString()},
                new Account {Username = "daothuytrang", Password = "daothuytrang", Email = "thuytrangdao240402@gmail.com", Role = EnumRole.Admin.ToString()},
                new Account {Username = "nguyentrongnghia", Password = "nguyentrongnghia", Email = "trongnghia161001@gmail.com", Role = EnumRole.Admin.ToString()},
                new Account {Username = "lyvantanh", Password = "lyvantanh", Email = "lyvantanh1001@gmail.com", Role = EnumRole.Employee.ToString()},
                new Account {Username = "ngoducquockhanh", Password = "ngoducquockhanh", Email = "ngoducquockhanh@gmail.com", Role = EnumRole.Employee.ToString()},
                new Account {Username = "travanthien", Password = "travanthien", Email = "travanthien@gmail.com", Role = EnumRole.Employee.ToString()},
                new Account {Username = "letronghoangminh", Password = "letronghoangminh", Email = "letronghoangminh@gmail.com", Role = EnumRole.Employee.ToString()},
                new Account {Username = "admin", Password = "admin", Email = "admin@gmail.com", Role = EnumRole.Admin.ToString()},
                new Account {Username = "employee", Password = "employee", Email = "employee@gmail.com", Role = EnumRole.Employee.ToString()},
                new Account {Username = "customer", Password = "customer", Email = "customer@gmail.com", Role = EnumRole.Employee.ToString()},
            });
            context.Admins.AddRange(new Admin[]
            {
                new Admin {ID_Admin = "AD0001", NameAdmin = "Lê Hoàng Long", Email = "lelong.ll32@gmail.com",
                    DateOfBirth = new DateTime(2002, 01, 14), Gender = "Nam", Phone = "0905395436",
                    ID_Card = "201844993", Address = "Đà Nẵng", Avatar = null, UserName = "lehoanglong"},
                new Admin {ID_Admin = "AD0002", NameAdmin = "Nguyễn Khắc Thái", Email = "zed999cz@gmail.com",
                    DateOfBirth = new DateTime(2001, 06, 26), Gender = "Nam", Phone = "0852738596",
                    ID_Card = "201827591", Address = "Đà Nẵng", Avatar = null, UserName = "nguyenkhacthai"},
                new Admin {ID_Admin = "AD0003", NameAdmin = "Đào Thủy Trang", Email = "thuytrangdao240402@gmail.com",
                    DateOfBirth = new DateTime(2002, 04, 24), Gender = "Nữ", Phone = "0343969468",
                    ID_Card = "201873912", Address = "Ninh Bình", Avatar = null, UserName = "daothuytrang"},
                new Admin {ID_Admin = "AD0004", NameAdmin = "Nguyễn Trọng Nghĩa", Email = "trongnghia161001@gmail.com",
                    DateOfBirth = new DateTime(2001, 10, 16), Gender = "Nam", Phone = "0328441828",
                    ID_Card = "201803812", Address = "Quảng Nam", Avatar = null, UserName = "nguyentrongnghia"},
                new Admin {ID_Admin = "AD0005", NameAdmin = "Admin", Email = "admin@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), Gender = "Nam", Phone = "9999999999",
                    ID_Card = "111111111", Address = "Đà Nẵng", Avatar = null, UserName = "admin"},
            });
            context.Employees.AddRange(new Employee[]
            {
                new Employee {ID_Employee = "E0001", NameEmployee = "Lý Văn Tánh", Email = "lyvantanh1001@gmail.com",
                    DateOfBirth = new DateTime(2002, 01, 10), Gender = "Nam", Phone = "0937284910",
                    Id_Card = "201844125", Address = "Quảng Trị", Avatar = null, UserName = "lyvantanh"},
                new Employee {ID_Employee = "E0002", NameEmployee = "Ngô Đức Quốc Khánh", Email = "quockhanhlanglim@gmail.com",
                    DateOfBirth = new DateTime(2001, 09, 02), Gender = "Nam", Phone = "0399120983",
                    Id_Card = "201885719", Address = "Nghệ An", Avatar = null, UserName = "ngoducquockhanh"},
                new Employee {ID_Employee = "E0003", NameEmployee = "Trà Văn Thiên", Email = "travanthien@gmail.com",
                    DateOfBirth = new DateTime(2002, 10, 05), Gender = "Nam", Phone = "0905742828",
                    Id_Card = "201872819", Address = "Quảng Nam", Avatar = null, UserName = "travanthien"},
                new Employee {ID_Employee = "E0004", NameEmployee = "Lê Trọng Hoàng Minh", Email = "letronghoangminh@gmail.com",
                    DateOfBirth = new DateTime(2002, 08, 02), Gender = "Nam", Phone = "0943707317",
                    Id_Card = "201899102", Address = "Huế", Avatar = null, UserName = "letronghoangminh"},
                new Employee {ID_Employee = "E0005", NameEmployee = "Employee", Email = "employee@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), Gender = "Nam", Phone = "9999999999",
                    Id_Card = "111111111", Address = "Đà Nẵng", Avatar = null, UserName = "employee"},
            });
        }
    }
}
