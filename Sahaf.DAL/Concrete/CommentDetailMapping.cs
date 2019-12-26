using Sahaf.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.DAL.Concrete
{
   public class CommentDetailMapping: EntityTypeConfiguration<CommentDetail>
    {
        public CommentDetailMapping()
        {
            HasKey(a => new { a.AdvertID, a.CommentID, a.UserID });
        }
    }
}
