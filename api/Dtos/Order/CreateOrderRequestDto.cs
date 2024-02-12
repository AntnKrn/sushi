using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.OrderItem;

namespace api.Dtos.Orders
{
    public class CreateOrderRequestDto
    {
        public int ClientId { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; } 
        [Required]
        [MaxLength(20, ErrorMessage = "Status must be less than 20 characters")]
        [MinLength(5, ErrorMessage = "Status must be more than 5 characters")]
        public string Status { get; set; } = string.Empty;

        public List<CreateOrderItemRequestDto> OrderItems { get; set; }
    }
}