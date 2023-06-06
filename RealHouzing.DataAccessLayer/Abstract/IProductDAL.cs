using RealHouzing.EntityLayer;

namespace RealHouzing.DataAccessLayer.Abstract
{
    public interface IProductDAL : IGenericDAL<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}
