using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Nhan_Vien")]
    public class Employee
    {

        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public Employee(string id, string name, string email, DateTime dateOfBirth, string gender, string phone, string ID_Card, string address, byte[] avatar, string username)
        {
            ID_Employee = id;
            NameEmployee = name;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Phone = phone;
            Id_Card = ID_Card;
            Address = address;
            Avatar = avatar;
            UserName = username;
        }

        [Key]
        [Column("ID_NhanVien")]
        [StringLength(100)]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string ID_Employee { get; set; }

        [Column("hoVaTen")]
        [StringLength(255)]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string NameEmployee { get; set; }

        [Column("email")]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string Email { get; set; }

        [Column("ngaySinh")]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public DateTime DateOfBirth { get; set; }

        [Column("gioiTinh")]
        [StringLength(20)]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string Gender { get; set; }

        [Column("SDT")]
        [StringLength(20)]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string Phone { get; set; }

        [Column("CMND")]
        [StringLength(50)]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string Id_Card { get; set; }

        [Column("diaChi")]
        [StringLength(255)]
        [Required(ErrorMessage = "Trường này không được để trống")]
        public string Address { get; set; }

        [Column("anh")]
        public byte[] Avatar { get; set; }

        [Column("taiKhoanDangNhap")]
        [StringLength(255)]
        public string UserName { get; set; }

        [ForeignKey("UserName")]
        public virtual Account Account { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}