using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ViewModels
{
    public class TutorialReviewViewModel
    {
        public Tutorial Tutorial { get; set; }
        public List<TutorialReview> TutorialReviews { get; set; }
        public string comment { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
