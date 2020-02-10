using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class ProductType
    {
        [Key]

        public int ProductTypeId { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Product> Products { get; set; }
  
    }
}
