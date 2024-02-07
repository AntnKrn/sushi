using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    [Table("Order_items")]
    public class OrderItem
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public Order? Order {get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName=("decimal(3,2)"))]
        public decimal SubSum { get; set; }
    }
}