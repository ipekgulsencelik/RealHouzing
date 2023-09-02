using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class ServiceItemManager : IServiceItemService
    {
        private readonly IServiceItemDAL _serviceItemDAL;

        public ServiceItemManager(IServiceItemDAL serviceItemDAL)
        {
            _serviceItemDAL = serviceItemDAL;
        }

        public void TDelete(ServiceItem entity)
        {
            _serviceItemDAL.Delete(entity);
        }

        public ServiceItem TGetByID(int id)
        {
            return _serviceItemDAL.GetByID(id);
        }

        public List<ServiceItem> TGetList()
        {
            return _serviceItemDAL.GetList();
        }

        public void TInsert(ServiceItem entity)
        {
            _serviceItemDAL.Insert(entity);
        }

        public void TUpdate(ServiceItem entity)
        {
            _serviceItemDAL.Update(entity);
        }
    }
}