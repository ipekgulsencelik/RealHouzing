using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class VideoManager : IVideoService
    {
        private readonly IVideoDAL _videoDAL;

        public VideoManager(IVideoDAL videoDAL)
        {
            _videoDAL = videoDAL;
        }

        public void TDelete(Video entity)
        {
            _videoDAL.Delete(entity);
        }

        public Video TGetByID(int id)
        {
            return _videoDAL.GetByID(id);
        }

        public List<Video> TGetList()
        {
            return _videoDAL.GetList();
        }

        public void TInsert(Video entity)
        {
            _videoDAL.Insert(entity);
        }

        public void TUpdate(Video entity)
        {
            _videoDAL?.Update(entity);
        }
    }
}
