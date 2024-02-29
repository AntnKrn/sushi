using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Fullname { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public User User { get; set; }
        public string Type { get; set; } = string.Empty;
        public bool IsOnline { get; set; } = false;
    }
}