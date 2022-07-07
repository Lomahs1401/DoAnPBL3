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
        public OrderDetail()
        {

        }

        public OrderDetail(string id_order, string id_book, string nameBook, 
            int unitPrice, int quantity, int totalAmount)
        {
            ID_Order = id_order;
            ID_Book = id_book;
            NameBook = nameBook;
            UnitPrice = unitPrice;
            Quantity = quantity;
            TotalAmount = totalAmount;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID", Order = 0)]
        public int Id { get; set; }

        [Column("ID_HoaDon", Order = 1)]
        [StringLength(100)]
        public string ID_Order { get; set; }

        [Column("ID_Sach", Order = 2)]
        [StringLength(100)]
        public string ID_Book { get; set; }

        [Column("TenSach")]
        [StringLength(100)]
        [Required(ErrorMessage = "Tên sách không được để trống")]
        public string NameBook { get; set; }

        [Column("DonGia")]
        [Required(ErrorMessage = "Đơn giá của sách không được để trống")]
        public int UnitPrice { get; set; }

        [Column("SoLuong")]
        [Required(ErrorMessage = "Số lượng sách không được để trống")]
        public int Quantity { get; set; }

        [Column("ThanhTien")]
        [Required(ErrorMessage = "Thành tiền của mặt hàng sách không được để trống")]
        public int TotalAmount { get; set; }

        [ForeignKey("ID_Book")]
        public virtual Book Book { get; set; }
        [ForeignKey("ID_Order")]
        public virtual Order Order { get; set; }
    }
}