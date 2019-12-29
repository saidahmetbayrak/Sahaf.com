﻿using Sahaf.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.Entities
{
   public class Message:BaseEntity
    {
        [ForeignKey("User")]
        public int SMessageID { get; set; }//Gönderen
        [ForeignKey("User")]
        public int RMessageID { get; set; }//Alıcı
        public string MessageText { get; set; }//Mesaj
        public DateTime Date { get; set; }//Tarih
        public string Subject { get; set; }//Konu


        ////Foreign Key
        //public int UserID { get; set; }//Alıcı
        //public int UserIDS { get; set; }//Gönderen

        //Mapping
        public virtual User User { get; set; }
    }
}
