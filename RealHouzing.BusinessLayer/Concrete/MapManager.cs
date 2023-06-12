﻿using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class MapManager : IMapService
    {
        private readonly IMapDAL _mapDAL;

        public MapManager(IMapDAL mapDAL)
        {
            _mapDAL = mapDAL;
        }

        public void TDelete(Map entity)
        {
            _mapDAL.Delete(entity);
        }

        public Map TGetByID(int id)
        {
            return _mapDAL.GetByID(id);
        }

        public List<Map> TGetList()
        {
            return _mapDAL.GetList();
        }

        public void TInsert(Map entity)
        {
            _mapDAL.Insert(entity);
        }

        public void TUpdate(Map entity)
        {
            _mapDAL.Update(entity);
        }
    }
}