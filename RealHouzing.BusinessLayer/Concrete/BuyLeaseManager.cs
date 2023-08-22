using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class BuyLeaseManager : IBuyLeaseService
    {
        private readonly IBuyLeaseDAL _buyLeaseDAL;

        public BuyLeaseManager(IBuyLeaseDAL buyLeaseDAL)
        {
            _buyLeaseDAL = buyLeaseDAL;
        }

        public void TDelete(BuyLease entity)
        {
            _buyLeaseDAL.Delete(entity);
        }

        public BuyLease TGetByID(int id)
        {
            return _buyLeaseDAL.GetByID(id);
        }

        public List<BuyLease> TGetList()
        {
           return _buyLeaseDAL.GetList();
        }

        public void TInsert(BuyLease entity)
        {
            _buyLeaseDAL.Insert(entity);
        }

        public void TUpdate(BuyLease entity)
        {
            _buyLeaseDAL?.Update(entity);
        }
    }
}
