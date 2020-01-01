using Sahaf.BLL.Abstract;
using Sahaf.DAL.Abstract;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.BLL.Concrete
{
    public class AdvertService : IAdvertService
    {
        IAdvertDAL _advertDAL;
        public AdvertService(IAdvertDAL advertDAL)
        {
            _advertDAL = advertDAL;
        }

        public void Delete(Advert entity)
        {
            _advertDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Advert Get(int entityID)
        {
            return _advertDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Advert> GetAdvertsByCategory(int catID)
        {
            return _advertDAL.GetAll(a => a.CategoryID == catID);
        }
        public ICollection<Advert> GetLastAddedAllAdverts()
        {
            return _advertDAL.GetAll().OrderByDescending(a => a.CreateDate).ToList();
        }

        public ICollection<Advert> GetAll()
        {
            return _advertDAL.GetAll();
        }


        public void Insert(Advert entity)
        {
            _advertDAL.Add(entity);
        }

        public void Update(Advert entity)
        {
            _advertDAL.Update(entity);
        }

        public ICollection<Advert> GetAdvertsByUser(int userID)
        {
            return _advertDAL.GetAll(a => a.UserID == userID);
        }
    }
}
