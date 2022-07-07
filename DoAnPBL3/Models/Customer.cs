using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Khach_Hang")]
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public Customer(string id_customer, string nameCustomer, string gender, string phone, string address)
        {
            ID_Customer = id_customer;
            FullNameCustomer = nameCustomer;
            Gender = gender;
            Phone = phone;
            Address = address;
        }

        [Key]
        [Column("ID_KhachHang")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID khách hàng không được để trống")]
        public string ID_Customer { get; set; }

        [Column("HoVaTen")]
        [StringLength(255)]
        [Required(ErrorMessage = "Họ và tên khách hàng không được để trống")]
        public string FullNameCustomer { get; set; }

        [Column("GioiTinh")]
        [StringLength(20)]
        [Required(ErrorMessage = "Giới tính khách hàng không được để trống")]
        public string Gender { get; set; }

        [Column("SDT")]
        [StringLength(20)]
        [Required(ErrorMessage = "Số điện thoại khách hàng không được để trống")]
        public string Phone { get; set; }

        [Column("DiaChi")]
        [StringLength(255)]
        [Required(ErrorMessage = "Địa chỉ khách hàng không được để trống")]
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}