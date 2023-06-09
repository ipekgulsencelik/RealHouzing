﻿using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.DataAccessLayer.Abstract
{
    public interface IProductDAL : IGenericDAL<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}
