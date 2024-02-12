using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.OrderItem
{
    public class UpdateOrderItemRequestDto
    {
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public decimal SubSum { get; set; }
    }
}