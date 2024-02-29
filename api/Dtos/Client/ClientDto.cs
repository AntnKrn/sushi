using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Client
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Fullname { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public int Discount { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}