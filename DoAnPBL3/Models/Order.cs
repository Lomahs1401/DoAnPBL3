using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Hoa_Don")]
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Order(string id_order, DateTime orderDate, int totalPrice, string id_customer, string id_employee)
        {
            ID_Order = id_order;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            ID_Customer = id_customer;
            ID_Employee = id_employee;
        }

        [Key]
        [Column("ID_HoaDon")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID hóa đơn không được để trống")]
        public string ID_Order { get; set; }

        [Column("NgayTaoHoaDon")]
        [Required(ErrorMessage = "Ngày tạo hóa đơn không được để trống")]
        public DateTime OrderDate { get; set; }

        [Column("TongTien")]
        [Required(ErrorMessage = "Tổng tiền của hóa đơn không được để trống")]
        public int TotalPrice { get; set; }

        [Column("ID_KhachHang")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID khách hàng không được để trống")]
        public string ID_Customer { get; set; }

        [Column("ID_NhanVien")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID nhân viên không được để trống")]
        public string ID_Employee { get; set; }

        [ForeignKey("ID_Customer")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("ID_Employee")]
        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}