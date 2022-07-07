using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Tai_Khoan")]
    public class Account
    {
        public Account()
        {

        }

        public Account(string Username, string Password, bool Role, string Avatar)
        {
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
            this.Avatar = Avatar;
        }

        [Key]
        [Column("TenDangNhap")]
        [StringLength(255)]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string Username { get; set; }

        [Column("MatKhau")]
        [StringLength(255)]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }

        [Column("AnhDaiDien")]
        public string Avatar { get; set; }

        [Column("Quyen")]
        [Required(ErrorMessage = "Quyền không được để trống")]
        public bool Role { get; set; }
    }
}