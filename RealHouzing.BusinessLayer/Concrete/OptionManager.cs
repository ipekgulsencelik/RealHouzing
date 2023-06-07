using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class OptionManager : IOptionService
    {
        private readonly IOptionDAL _optionDAL;

        public OptionManager(IOptionDAL optionDAL)
        {
            _optionDAL = optionDAL;
        }

        public void TDelete(Option entity)
        {
            _optionDAL.Delete(entity);
        }

        public Option TGetByID(int id)
        {
            return _optionDAL.GetByID(id);
        }

        public List<Option> TGetList()
        {
            return _optionDAL.GetList();
        }

        public void TInsert(Option entity)
        {
            _optionDAL.Insert(entity);
        }

        public void TUpdate(Option entity)
        {
            _optionDAL.Update(entity);
        }
    }
}
