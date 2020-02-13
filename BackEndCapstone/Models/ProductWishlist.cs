using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class ProductWishlist
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int ProductId { get; set; }
    }
}
