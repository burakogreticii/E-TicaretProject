﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, EticaretContext>,ICustomerDal
    {
        public EfCustomerDal(EticaretContext context) : base(context)
        {
        }
    }
}
