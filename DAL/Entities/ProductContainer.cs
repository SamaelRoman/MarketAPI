﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductContainer
    {
        public Guid bindingID {get;set;}
        public IEnumerable<Product> Products { get; set; }
    }
}
