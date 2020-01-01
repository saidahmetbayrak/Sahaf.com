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
    public class UserService : IUserService
    {
        IUserDAL _userDAL;
        public UserService(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public ICollection<User> CheckUser(string username, string mail)
        {
            return _userDAL.GetAll(a => a.Username == username && a.EMail==mail || a.Username==username || a.EMail==mail);
        }

        public void Delete(User entity)
        {
            _userDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public User Get(int entityID)
        {
            return _userDAL.Get(a => a.ID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return _userDAL.GetAll();
        }

        public User GetUserByLogin(string username, string password)
        {
            return _userDAL.Get(a => a.Username == username && a.Password == password);
        }

        public void Insert(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            _userDAL.Update(entity);
        }
    }
}
