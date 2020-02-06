using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ViewModels
{
    public class GemstoneCreateViewModel
    {
        public IFormFile File { get; set; }
        [Key]
        public int GemstoneId { get; set; }

       
     

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public string Title { get; set; }



        [Required]
        public string UserId { get; set; }
        public string ImagePath { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
    }
}
