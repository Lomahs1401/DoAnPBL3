using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using StringLengthAttribute = System.ComponentModel.DataAnnotations.StringLengthAttribute;

namespace DoAnPBL3.Models
{
    [Table("Nha_Xuat_Ban")]
    public class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public Publisher(int id_publisher, string namePublisher, string email, string phoneContact)
        {
            ID_Publisher = id_publisher;
            NamePublisher = namePublisher;
            Email = email;
            PhoneContact = phoneContact;
        }

        [Key]
        [Column("ID_NhaXuatBan")]
        [AutoIncrement]
        [Required(ErrorMessage = "ID của nhà xuất bản không được để trống")]
        public int ID_Publisher { get; set; }

        [Column("TenNhaXuatBan")]
        [StringLength(255)]
        [Required(ErrorMessage = "Tên nhà xuất bản không được để trống")]
        public string NamePublisher { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Email của nhà xuất bản không được để trống")]
        public string Email { get; set; }

        [Column("SDT")]
        [StringLength(255)]
        [Required(ErrorMessage = "Số điện thoại của nhà xuất bản không được để trống")]
        public string PhoneContact { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}