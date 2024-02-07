using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        [Column(TypeName=("decimal(3,2)"))]
        public decimal TotalPrice { get; set; } 

        public string Status { get; set; } = string.Empty;

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}