﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class ProductReview
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public Product Product { get; set; }
        [Required]
        public ApplicationUser User { get; set; }

    }
}
