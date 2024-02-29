using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    [Table("Clients")]
    public class Client
    {
        public int Id { get; set; }
        public string? Fullname { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public User User { get; set; }
        public int Discount { get; set; } = 0;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}