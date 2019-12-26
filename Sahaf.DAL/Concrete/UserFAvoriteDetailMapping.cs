using Sahaf.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sahaf.DAL.Concrete
{
   public class UserFavoriteDetailMapping: EntityTypeConfiguration<UserFavoriteDetail>
    {
        public UserFavoriteDetailMapping()
        {
            HasKey(a => new { a.AdvertID, a.UserID });
        }
    }
}
