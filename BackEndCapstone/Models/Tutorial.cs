using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class Tutorial
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string VideoPath { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductId { get; set; }
        [NotMapped]

        public IFormFile File { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
        public List<TutorialReview> TutorialReviews { get; set; }

    }
}
