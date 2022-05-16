using DoAnPBL3.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace DoAnPBL3
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("name=BookStoreContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<BookStoreContext>(new CreateAdminAndEmployee());
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(employee => new { employee.Phone, employee.Id_Card })
                .IsUnique(true);
            modelBuilder.Entity<Admin>()
                .HasIndex(admin => new { admin.Phone, admin.ID_Card })
                .IsUnique(true);
            modelBuilder.Entity<Customer>()
                .HasIndex(customer => customer.Phone)
                .IsUnique();
            modelBuilder.Entity<Employee>()
                .MapToStoredProcedures(s =>
                    s.Insert(i => i.HasName("Employee_Insert", "dbo")
                                   .Parameter(e => e.ID_Employee, "ID_NhanVien")
                                   .Parameter(e => e.NameEmployee, "hoVaTen")
                                   .Parameter(e => e.Email, "email")
                                   .Parameter(e => e.DateOfBirth, "ngaySinh")
                                   .Parameter(e => e.Gender, "gioiTinh")
                                   .Parameter(e => e.Phone, "SDT")
                                   .Parameter(e => e.Id_Card, "CMND")
                                   .Parameter(e => e.Address, "diaChi")
                                   .Parameter(e => e.Avatar, "anh")
                                   .Parameter(e => e.UserName, "taiKhoanDangNhap"))
                     .Update(u => u.HasName("Employee_Update", "dbo")
                                   .Parameter(e => e.ID_Employee, "ID_NhanVien")
                                   .Parameter(e => e.NameEmployee, "hoVaTen")
                                   .Parameter(e => e.Email, "email")
                                   .Parameter(e => e.DateOfBirth, "ngaySinh")
                                   .Parameter(e => e.Gender, "gioiTinh")
                                   .Parameter(e => e.Phone, "SDT")
                                   .Parameter(e => e.Id_Card, "CMND")
                                   .Parameter(e => e.Address, "diaChi")
                                   .Parameter(e => e.Avatar, "anh")
                                   .Parameter(e => e.UserName, "taiKhoanDangNhap"))
                     .Delete(d => d.HasName("Employee_Delete", "dbo")
                                   .Parameter(e => e.ID_Employee, "ID_NhanVien"))
               );
        }
    }
}