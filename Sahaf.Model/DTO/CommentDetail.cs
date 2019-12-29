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
        public int? AdvertID { get; set; }
        public int? UserID { get; set; }
        public int? CommentID { get; set; }

        //
        public virtual Advert Advert { get; set; }
        public virtual User User { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
