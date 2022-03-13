﻿using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
