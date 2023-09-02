using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Repository;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.DataAccessLayer.EntityFramework
{
    public class EFServiceItemDAL : GenericRepository<ServiceItem>, IServiceItemDAL
    {
    }
}
