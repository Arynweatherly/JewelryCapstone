using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ViewModels
{
    public class ProductCreateViewModel
    {
        public IFormFile File { get; set; }
        [Key]
        public int ProductId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateAdded { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please shorten the product title to 55 characters")]
        public string Title { get; set; }



        [Required]
        public string UserId { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Gemstones")]

        public List<int> GemstoneIds { get; set; }
        public List<ProductGemstone> ProductGemstones { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required(ErrorMessage = "Error: Must choose a product category")]
        [Display(Name = "Product Category")]
        public int ProductTypeId { get; set; }

        [Display(Name = "Product Type")]
        public ProductType ProductType { get; set; }


    }
}
