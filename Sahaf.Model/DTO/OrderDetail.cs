using Sahaf.Core.Entity;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.DTO
{
   public class OrderDetail:BaseEntity
    {
        public decimal Price { get; set; }//Fiyat
        public int Stock { get; set; }//Stok


        //Foreign Key
        public int? AdvertID { get; set; }
        public int? OrderID { get; set; }

        //
        public virtual Advert Advert { get; set; }
        public virtual Order Order { get; set; }
    }
}
