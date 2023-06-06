using Microsoft.EntityFrameworkCore;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrete;
using RealHouzing.DataAccessLayer.Repository;
using RealHouzing.EntityLayer;

namespace RealHouzing.DataAccessLayer.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        public List<Product> GetProductsWithCategories()
        {
            var context = new Context();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
}
