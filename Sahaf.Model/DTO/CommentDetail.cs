using Sahaf.Core.Entity;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.DTO
{
    public class CommentDetail:BaseEntity
    {
        //Foreign Key
        public int AdvertID { get; set; }
        public int UserID { get; set; }
        public int CommentID { get; set; }

        //Mapping
        public virtual List<Advert> Adverts { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
