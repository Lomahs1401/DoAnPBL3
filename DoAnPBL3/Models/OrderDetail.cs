using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Chi_Tiet_Hoa_Don")]
    public class OrderDetail
    {
        [Key]
        [Column("ID_HoaDon", Order = 0)]
        [StringLength(100)]
        [Required]
        public string ID_Order { get; set; }

        [Key]
        [Column("ID_Sach", Order = 1)]
        [StringLength(100)]
        [Required]
        public string ID_Book { get; set; }

        [Column("Ten_Sach")]
        [StringLength(100)]
        [Required]
        public string NameBook { get; set; }

        [Column("donGia")]
        [Required]
        public int UnitPrice { get; set; }

        [Column("soLuong")]
        [Required]
        public int Quantity { get; set; }

        [Column("thanhTien")]
        [Required]
        public int TotalAmount { get; set; }

        [ForeignKey("ID_Book")]
        public virtual Book Book { get; set; }
        [ForeignKey("ID_Order")]
        public virtual Order Order { get; set; }
    }
}