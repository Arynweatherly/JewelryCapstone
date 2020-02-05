using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int UserId { get; set; }
        public int ProductTypeId { get; set; }
    }
}
