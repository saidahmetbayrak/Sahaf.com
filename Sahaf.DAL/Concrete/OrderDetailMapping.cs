using System;

using Sahaf.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Sahaf.Model.DTO;

namespace Sahaf.DAL.Concrete
{
   public class OrderDetailMapping: EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            HasKey(a => new { a.OrderID, a.AdvertID });
        }
    }
}
