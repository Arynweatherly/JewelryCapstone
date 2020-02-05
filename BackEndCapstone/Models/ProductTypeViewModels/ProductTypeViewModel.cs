using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ProductTypeViewModels
{
    public class ProductTypeViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Category")]
        public string Category { get; set; }

        public IEnumerable<Product> Products { get; set; } = new List<Product>();
       
    }
}
