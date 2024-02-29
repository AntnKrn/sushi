using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Worker
{
    public class WorkerDto
    {
        
        public int Id { get; set; }
        public string Fullname { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsOnline { get; set; } = false;
    }
}