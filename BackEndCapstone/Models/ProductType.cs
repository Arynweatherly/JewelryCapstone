﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCapstone.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}