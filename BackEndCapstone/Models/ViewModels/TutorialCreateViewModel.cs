using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ViewModels
{
    public class TutorialCreateViewModel
    {
        public IFormFile File { get; set; }
        [Key]
        public int TutorialId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateAdded { get; set; }

        [Required]
        public string Description { get; set; }

        public string Title { get; set; }

     

        [Required]
        public string UserId { get; set; }
        public string VideoPath { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
    }
}
