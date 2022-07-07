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
            Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<BookStoreContext>(new InitialData());
        }

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
        public virtual DbSet<Note> Notes { get; set; }

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
            base.OnModelCreating(modelBuilder);
        }
    }
}