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

        public Account(string Username, string Password, string Email, string Role)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Role = Role;
        }

        [Key]
        [Column("TenDangNhap")]
        [StringLength(255)]
        [Required]
        public string Username { get; set; }

        [Column("matKhau")]
        [StringLength(255)]
        [Required]
        public string Password { get; set; }

        [Column("email")]
        [StringLength(255)]
        [Required]
        public string Email { get; set; }

        [Column("quyen")]
        [StringLength(255)]
        [Required]
        public string Role { get; set; }
    }
}