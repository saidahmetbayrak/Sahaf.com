using System;
using Sahaf.Core.DAL;
using Sahaf.DAL.Abstract;
using Sahaf.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sahaf.Model.Entities;

namespace Sahaf.DAL.Concrete
{
   public class MessageRepository:EFRepositoryBase<Message,SahafDbContext>,IMessageDAL
    {
    }
}
