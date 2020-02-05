using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserId { get; set; }
        public int ProductTypeId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required(ErrorMessage = "Error: Must choose a product category")]
        [Display(Name = "Product Category")]

        public ProductType ProductType { get; set; }

    }
}
