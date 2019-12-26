using Sahaf.Core.DAL;
using Sahaf.DAL.Abstract;
using Sahaf.Model;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.DAL.Concrete
{
   public class AdvertRepository:EFRepositoryBase<Advert,SahafDbContext>,IAdvertDAL
    {
    }
}
