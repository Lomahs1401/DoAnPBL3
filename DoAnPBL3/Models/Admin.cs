 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Quan_Tri")]
    public class Admin
    {
        public Admin()
        {

        }

        public Admin(string id_admin, string nameAdmin, string email, DateTime dateOfBirth, DateTime startDate,
            DateTime? endDate, string gender, string phone, string ID_Card, string address, string avatar, string accountUsername, bool workStatus)
        {
            ID_Admin = id_admin;
            FullNameAdmin = nameAdmin;
            Email = email;
            DateOfBirth = dateOfBirth;
            StartDate = startDate;
            EndDate = endDate;
            Gender = gender;
            Phone = phone;
            this.ID_Card = ID_Card;
            Address = address;
            Avatar = avatar;
            AccountUsername = accountUsername;
            WorkStatus = workStatus;
        }

        [Key]
        [Column("ID_QuanTri")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID của quản trị không được để trống")]
        public string ID_Admin { get; set; }

        [Column("HoVaTen")]
        [StringLength(255)]
        [Required(ErrorMessage = "Họ và tên của quản trị không được để trống")]
        public string FullNameAdmin { get; set; }

        [Column("Email")]
        [StringLength(255)]
        [Required(ErrorMessage = "Email của quản trị không được để trống")]
        public string Email { get; set; }

        [Column("NgaySinh")]
        [Required(ErrorMessage = "Ngày sinh của quản trị không được để trống")]
        public DateTime DateOfBirth { get; set; }

        [Column("NgayLamViec")]
        [Required(ErrorMessage = "Ngày bắt đầu làm việc của quản trị không được để trống")]
        public DateTime StartDate { get; set; }

        [Column("NgayNghiViec")]
        public DateTime? EndDate { get; set; }

        [Column("GioiTinh")]
        [StringLength(20)]
        [Required(ErrorMessage = "Giới tính của quản trị không được để trống")]
        public string Gender { get; set; }

        [Column("SDT")]
        [StringLength(20)]
        [Required(ErrorMessage = "Số điện thoại của quản trị không được để trống")]
        public string Phone { get; set; }

        [Column("CMND")]
        [StringLength(50)]
        [Required(ErrorMessage = "CMND của quản trị không được để trống")]
        public string ID_Card { get; set; }

        [Column("DiaChi")]
        [StringLength(255)]
        [Required(ErrorMessage = "Địa chỉ của quản trị không được để trống")]
        public string Address { get; set; }

        [Column("Anh")]
        public string Avatar { get; set; }

        [Column("TaiKhoanDangNhap")]
        [StringLength(255)]
        public string AccountUsername { get; set; }

        [ForeignKey("AccountUsername")]
        public virtual Account Account { get; set; }

        [Column("TrangThai")]
        [Required(ErrorMessage = "Tình trạng làm việc của quản trị không được để trống")]
        public bool WorkStatus { get; set; }
    }
}