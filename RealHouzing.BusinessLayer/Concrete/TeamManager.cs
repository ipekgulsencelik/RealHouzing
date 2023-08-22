using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDAL _teamDAL;

        public TeamManager(ITeamDAL teamDAL)
        {
            _teamDAL = teamDAL;
        }

        public void TDelete(Team entity)
        {
            _teamDAL.Delete(entity);
        }

        public Team TGetByID(int id)
        {
            return _teamDAL.GetByID(id);
        }

        public List<Team> TGetList()
        {
            return _teamDAL.GetList();
        }

        public void TInsert(Team entity)
        {
            _teamDAL.Insert(entity);
        }

        public void TUpdate(Team entity)
        {
            _teamDAL.Update(entity);
        }
    }
}
