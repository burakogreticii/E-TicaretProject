﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, EticaretContext>, ICategoryDal
    {
        public EfCategoryDal(EticaretContext context) : base(context)
        {
        }
    }
}
