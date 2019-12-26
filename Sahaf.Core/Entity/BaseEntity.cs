using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Core.Entity
{
   public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
            IsActive = false;
        }
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
