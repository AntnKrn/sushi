using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.OrderItem;

namespace api.Dtos.Orders
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; } 
        public string Status { get; set; } = string.Empty;
        public List<OrderItemDto> OrderItems { get; set; }
    }
}