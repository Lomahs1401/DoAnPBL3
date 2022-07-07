using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Ghi_Chu")]
    public class Note
    {
        public Note()
        {

        }

        public Note(int id, string title, string content, DateTime date, string accountUsername)
        {
            ID = id;
            Title = title;
            Content = content;
            Date = date;
            AccountUsername = accountUsername;
        }

        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("TieuDe")]
        [MaxLength]
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string Title { get; set; }

        [Column("NoiDung")]
        [MaxLength]
        [Required(ErrorMessage = "Nội dung không được để trống")]
        public string Content { get; set; }

        [Column("NgayTao")]
        [Required(ErrorMessage = "Ngày tạo ghi chú không được để trống")]
        public DateTime Date { get; set; }

        [Column("TenDangNhap")]
        [StringLength(255)]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string AccountUsername { get; set; }

        [ForeignKey("AccountUsername")]
        public virtual Account Account { get; set; }
    }
}
