using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productDAL.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDAL.GetList();
        }

        public void TInsert(Product entity)
        {
            _productDAL.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}