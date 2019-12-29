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
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryService(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }
        public void Delete(Category entity)
        {
            _categoryDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Category Get(int entityID)
        {
            return _categoryDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public void Insert(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}
