using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.BLL.Abstract
{
   public interface IUserService:IBaseService<User>
    {
        User GetUserByLogin(string username, string password);
        ICollection<User> CheckUser(string username,string mail);
    }
}
