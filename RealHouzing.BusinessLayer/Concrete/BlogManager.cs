using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public void TDelete(Blog entity)
        {
            _blogDAL.Delete(entity);
        }

        public Blog TGetByID(int id)
        {
            return _blogDAL.GetByID(id);
        }

        public List<Blog> TGetList()
        {
            return _blogDAL.GetList();
        }

        public void TInsert(Blog entity)
        {
            _blogDAL.Insert(entity);
        }

        public void TUpdate(Blog entity)
        {
            _blogDAL.Update(entity);
        }
    }
}
