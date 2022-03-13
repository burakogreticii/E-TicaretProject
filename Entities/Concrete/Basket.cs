﻿using System;
using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Basket : BaseEntity
    {
        public Guid UserId { get; set; }

        public User User { get; set; }
        public ICollection<BasketDetail> BasketDetails { get; set; }
    }
}
