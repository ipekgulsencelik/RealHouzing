using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class PostPropertyManager : IPostPropertyService
    {
        private readonly IPostPropertyDAL _postPropertyDAL;

        public PostPropertyManager(IPostPropertyDAL postPropertyDAL)
        {
            _postPropertyDAL = postPropertyDAL;
        }

        public void TDelete(PostProperty entity)
        {
            _postPropertyDAL.Delete(entity);
        }

        public PostProperty TGetByID(int id)
        {
            return _postPropertyDAL.GetByID(id);
        }

        public List<PostProperty> TGetList()
        {
            return _postPropertyDAL.GetList();
        }

        public void TInsert(PostProperty entity)
        {
            _postPropertyDAL.Insert(entity);
        }

        public void TUpdate(PostProperty entity)
        {
            _postPropertyDAL.Update(entity);
        }
    }
}
