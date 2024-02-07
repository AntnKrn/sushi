using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    [Table("Menu")]
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ingredients { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        [Column(TypeName = "decimal(3,2)")]
        public decimal Price { get; set; }
    }
}