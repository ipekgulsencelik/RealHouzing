﻿using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class ContactInformationManager : IContactInformationService
    {
        private readonly IContactInformationDAL _contactInformationDAL;

        public ContactInformationManager(IContactInformationDAL contactInformationDAL)
        {
            _contactInformationDAL = contactInformationDAL;
        }

        public void TDelete(ContactInformation entity)
        {
            _contactInformationDAL.Delete(entity);
        }

        public ContactInformation TGetByID(int id)
        {
            return _contactInformationDAL.GetByID(id);
        }

        public List<ContactInformation> TGetList()
        {
            return _contactInformationDAL.GetList();
        }

        public void TInsert(ContactInformation entity)
        {
            _contactInformationDAL.Insert(entity);
        }

        public void TUpdate(ContactInformation entity)
        {
            _contactInformationDAL.Update(entity);
        }
    }
}