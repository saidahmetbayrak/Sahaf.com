using Sahaf.Core.Entity;
using Sahaf.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.Entities
{
   public class Role:BaseEntity
    {
        public Roles Roles { get; set; }//Rol

        //Mapping
        public virtual List<User> Users { get; set; }
    }

}
