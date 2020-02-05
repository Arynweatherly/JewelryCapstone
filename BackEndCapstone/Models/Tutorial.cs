using System;
using System.Collections.Generic;
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


    }
}
