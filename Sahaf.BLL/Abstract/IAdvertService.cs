using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.BLL.Abstract
{
   public interface IAdvertService:IBaseService<Advert>
    {
        ICollection<Advert> GetAdvertsByCategory(int catID);
        ICollection<Advert> GetLastAddedAllAdverts();
        //Advert SelectByID(int id);
    }
}
