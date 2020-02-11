using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ViewModels
{
    public class ProductReviewViewModel
    {
        public Tutorial Tutorial { get; set; }
        public List<ProductReview> ProductReviews { get; set; }
        public string Comment { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
    }
}
