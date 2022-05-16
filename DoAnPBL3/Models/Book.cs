using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Sach")]
    public class Book
    {

        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [Column("ID_Sach")]
        [StringLength(100)]
        [Required]
        public string ID_Book { get; set; }

        [Column("tenSach")]
        [StringLength(255)]
        [Required]
        public string NameBook { get; set; }

        [Column("ngayPhatHanh")]
        [Required]
        public DateTime PublishDate { get; set; }

        [Column("soLuong")]
        [Required]
        public int Quantity { get; set; }

        [Column("giaTien")]
        [Required]
        public int Price { get; set; }

        [Column("ISBN")]
        [StringLength(50)]
        [Required]
        public string ISBN { get; set; }

        [Column("ID_TacGia")]
        [StringLength(100)]
        [Required]
        public string ID_Author { get; set; }
        [ForeignKey("ID_Author")]
        public virtual Author Author { get; set; }

        [Column("ID_TheLoai")]
        [Required]
        public int ID_Genre { get; set; }
        [ForeignKey("ID_Genre")]
        public virtual Genre Genre { get; set; }

        [Column("ID_NgonNgu")]
        [Required]
        public int ID_Language { get; set; }
        [ForeignKey("ID_Genre")]
        public virtual Language Language { get; set; }

        [Column("ID_NhaXuatBan")]
        [StringLength(100)]
        [Required]
        public string ID_Publisher { get; set; }
        [ForeignKey("ID_Publisher")]
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}