using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models.ViewModels
{
    public class ProductGemstoneViewModel
    {
        public int ProductGemstoneId { get; set; }
        public int ProductId { get; set; }
        public int GemstoneId { get; set; }
        public IEnumerable<Gemstone> Gemstones { get; set; } = new List<Gemstone>();

    }
}
