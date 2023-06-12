using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
    }
}
