using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Menu
{
    public class UpdateMenuRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Ingredients { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}