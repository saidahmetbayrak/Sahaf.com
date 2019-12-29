using Sahaf.Core.Entity;
using Sahaf.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.Entities
{
   public class Comment:BaseEntity
    {
        public string CommentText { get; set; }//Yorum
        public DateTime CommentDate { get; set; }//yorum tarihi


        //Foreign Key


        public virtual List<CommentDetail> CommentDetails { get; set; }

    }
}
