

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

        public Book(string id_book, string nameBook, DateTime publishDate, string nameAuthor, 
            int quantity, int price, int ID_Language, int ID_Publisher, int ID_Genre, string bookImage, bool saleStatus)
        {
            ID_Book = id_book;
            NameBook = nameBook;
            PublishDate = publishDate;
            NameAuthor = nameAuthor;
            Quantity = quantity;
            Price = price;
            this.ID_Language = ID_Language;
            this.ID_Publisher = ID_Publisher;
            this.ID_Genre = ID_Genre;
            Image = bookImage;
            SaleStatus = saleStatus;
        }

        [Key]
        [Column("ID_Sach")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID của sách không được để trống")]
        public string ID_Book { get; set; }

        [Column("TenSach")]
        [StringLength(255)]
        [Required(ErrorMessage = "Tên sách không được để trống")]
        public string NameBook { get; set; }

        [Column("NgayPhatHanh")]
        [Required(ErrorMessage = "Ngày phát hành của sách không được để trống")]
        public DateTime PublishDate { get; set; }

        [Column("TacGia")]
        [Required(ErrorMessage = "Tác giả của sách không được để trống")]
        public string NameAuthor { get; set; }

        [Column("SoLuong")]
        [Required(ErrorMessage = "Số lượng sách không được để trống")]
        public int Quantity { get; set; }

        [Column("GiaTien")]
        [Required(ErrorMessage = "Giá tiền của sách không được để trống")]
        public int Price { get; set; }

        [Column("ID_NgonNgu")]
        [Required(ErrorMessage = "ID ngôn ngữ của sách không được để trống")]
        public int ID_Language { get; set; }

        [Column("ID_NhaXuatBan")]
        [Required(ErrorMessage = "ID nhà xuất bản của sách không được để trống")]
        public int ID_Publisher { get; set; }

        [Column("ID_TheLoai")]
        [Required]
        public int ID_Genre { get; set; }

        [ForeignKey("ID_Language")]
        public virtual Language Language { get; set; }

        [ForeignKey("ID_Publisher")]
        public virtual Publisher Publisher { get; set; }

        [ForeignKey("ID_Genre")]
        public virtual Genre Genre { get; set; }

        [Column("Anh")]
        public string Image { get; set; }

        [Column("TrangThai")]
        [Required(ErrorMessage = "Tình trạng của sách không được để trống")]
        public bool SaleStatus { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}