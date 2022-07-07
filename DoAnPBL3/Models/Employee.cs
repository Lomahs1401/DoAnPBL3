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

        public Employee(string id_employee, string nameEmployee, string email, DateTime dateOfBirth, DateTime startDate, 
            DateTime? endDate, string gender, string phone, string ID_Card, string address, string avatar, string accountUsername, bool workStatus)
        {
            ID_Employee = id_employee;
            FullNameEmployee = nameEmployee;
            Email = email;
            DateOfBirth = dateOfBirth;
            StartDate = startDate;
            EndDate = endDate;
            Gender = gender;
            Phone = phone;
            Id_Card = ID_Card;
            Address = address;
            Avatar = avatar;
            AccountUsername = accountUsername;
            WorkStatus = workStatus;
        }

        [Key]
        [Column("ID_NhanVien")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID của nhân viên không được để trống")]
        public string ID_Employee { get; set; }

        [Column("HoVaTen")]
        [StringLength(255)]
        [Required(ErrorMessage = "Họ và tên của nhân viên không được để trống")]
        public string FullNameEmployee { get; set; }

        [Column("Email")]
        [Required(ErrorMessage = "Email của nhân viên không được để trống")]
        public string Email { get; set; }

        [Column("NgaySinh")]
        [Required(ErrorMessage = "Ngày sinh của nhân viên không được để trống")]
        public DateTime DateOfBirth { get; set; }

        [Column("NgayVaoLam")]
        [Required(ErrorMessage = "Ngày bắt đầu làm việc của nhân viên không được để trống")]
        public DateTime StartDate { get; set; }

        [Column("NgayNghiLam")]
        public DateTime? EndDate { get; set; }

        [Column("GioiTinh")]
        [StringLength(20)]
        [Required(ErrorMessage = "Giới tính của nhân viên không được để trống")]
        public string Gender { get; set; }

        [Column("SDT")]
        [StringLength(20)]
        [Required(ErrorMessage = "Số điện thoại của nhân viên không được để trống")]
        public string Phone { get; set; }

        [Column("CMND")]
        [StringLength(50)]
        [Required(ErrorMessage = "CMND của nhân viên không được để trống")]
        public string Id_Card { get; set; }

        [Column("DiaChi")]
        [StringLength(255)]
        [Required(ErrorMessage = "Địa chỉ của nhân viên không được để trống")]
        public string Address { get; set; }

        [Column("Anh")]
        public string Avatar { get; set; }

        [Column("TaiKhoanDangNhap")]
        [StringLength(255)]
        public string AccountUsername { get; set; }

        [ForeignKey("AccountUsername")]
        public virtual Account Account { get; set; }

        [Column("TrangThai")]
        [Required(ErrorMessage = "Tình trạng làm việc của nhân viên không được để trống")]
        public bool WorkStatus { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}