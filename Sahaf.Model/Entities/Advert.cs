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
   public class Advert:BaseEntity
    {
       
        public string BookName { get; set; }//KitapAdı
        public string Writer { get; set; }//Yazar
        public decimal Price { get; set; }//Fiyat
        public Condition Condition { get; set; }//Kondisyon Enum
        public Status Status { get; set; }//Durum Enum
        public string Language { get; set; }//Dil
        public short Stock { get; set; }//Stok
        public string PublisherName { get; set; }//YayinEvi
        public int PublishYear { get; set; }//YayinYılı
        public string Description { get; set; }//ACıklama
        public string AdvertİmgUrl { get; set; }//ResimYolu


        //Foreign Key
        public int UserID { get; set; }
        public int CategoryID { get; set; }

        //Mapping
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}
