using Sahaf.Core.Entity;
using Sahaf.Model.DTO;
using Sahaf.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.Entities
{
   public class Order:BaseEntity
    {
        public DateTime OrderDate { get; set; }//SiparişTarihi
        public Payment Payment { get; set; }//ÖdemeŞekli
        public string ShipperID { get; set; }//RandomClass Create


        //Foreign Key
        public int UserID { get; set; }

       
        public virtual User User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
