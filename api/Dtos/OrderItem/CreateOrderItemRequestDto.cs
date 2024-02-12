using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.OrderItem
{
    public class CreateOrderItemRequestDto
    { 
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public decimal SubSum { get; set; }
    }
}