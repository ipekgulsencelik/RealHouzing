using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class BlogManager : IBlogDAL
    {
        private readonly IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public void Delete(Blog entity)
        {
            _blogDAL.Delete(entity);
        }

        public Blog GetByID(int id)
        {
            return _blogDAL.GetByID(id);
        }

        public List<Blog> GetList()
        {
            return _blogDAL.GetList();
        }

        public void Insert(Blog entity)
        {
            _blogDAL.Insert(entity);
        }

        public void Update(Blog entity)
        {
            _blogDAL.Update(entity);
        }
    }
}
