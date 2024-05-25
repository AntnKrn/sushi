using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Menu
{
    public class UpdateMenuRequestDto
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name must be less than 50 characters")]
        [MinLength(4, ErrorMessage = "Name must be more than 4 characters")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(50, ErrorMessage = "Ingredients must be less than 100 characters")]
        [MinLength(4, ErrorMessage = "Ingredients must be more than 3 characters")]
        public string Ingredients { get; set; } = string.Empty;
        [Required]
        [MaxLength(50, ErrorMessage = "Type must be less than 20 characters")]
        [MinLength(4, ErrorMessage = "Type must be more than 4 characters")]
        public string Type { get; set; } = string.Empty;
        public string ImgUrl { get; set;} = string.Empty;

        [Required]
        [Range(1, 100, ErrorMessage = "Price must be between 1 and 100")]
        public decimal Price { get; set; }
    }
}