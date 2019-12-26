using Sahaf.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.Entities
{
   public class Category:BaseEntity
    {
        public string CategoryName { get; set; }//KategoriAdı
        public string Description { get; set; }//Açıklama

        //Foreign Key

        //Mapping
        public virtual List<Advert> Adverts { get; set; }
    }
}
