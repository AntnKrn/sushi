using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Orders
{
    public class UpdateOrderRequestDto
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; } 
        [Required]
        [MaxLength(20, ErrorMessage = "Status must be less than 20 characters")]
        [MinLength(5, ErrorMessage = "Status must be more than 5 characters")]
        public string Status { get; set; } = string.Empty;
    }
}