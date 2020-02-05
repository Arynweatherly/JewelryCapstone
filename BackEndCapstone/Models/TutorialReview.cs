using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class TutorialReview
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TutorialId { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
