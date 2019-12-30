using Ninject.Modules;
using Sahaf.DAL.Abstract;
using Sahaf.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.BLL.Ninject
{
    public class CustomDALNinjectModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAdvertDAL>().To<AdvertRepository>();
            Bind<ICategoryDAL>().To<CategoryRepository>();
            Bind<ICommentDAL>().To<CommentRepository>();
            Bind<IMessageDAL>().To<MessageRepository>();
            Bind<IOrderDAL>().To<OrderRepository>();
            Bind<IRoleDAL>().To<RoleRepository>();
            Bind<IUserDAL>().To<UserRepository>();
        }
    }
}
