using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LeTranAnhDuc_2280600721_week03.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        [Required(ErrorMessage = "Bạn bắt buộc phải nhập thông tin này")]
        public string ShippingAddress { get; set; }
        [Required(ErrorMessage = "Nếu không có bạn hãy nhập No hoặc bất kì chữ cái")]
        public string Notes { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
