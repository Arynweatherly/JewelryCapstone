using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class ProductGemstone
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int GemstoneId { get; set; }

        public Gemstone Gemstone { get; set; }
        public Product Product { get; set; }


    }
}
