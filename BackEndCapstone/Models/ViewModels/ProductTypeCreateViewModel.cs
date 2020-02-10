using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ViewModels
{
    public class ProductTypeCreateViewModel
    {
        public string Category { get; set; }

 
        public IFormFile File { get; set; }

        [Required]
        public string UserId { get; set; }
        public string ImagePath { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
    }
}
