using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Orders
{
    public class UpdateOrderRequestDto
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; } 
        public string Status { get; set; } = string.Empty;
    }
}