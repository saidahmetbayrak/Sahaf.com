﻿using Sahaf.Core.Entity;
using Sahaf.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Model.Entities
{
   public class User:BaseEntity
    {
        public User()
        {
            Antiqurian = false;
            RoleID = 1;
        }
        public string Username { get; set; }//KullanıcıAdı
        public string FirstName { get; set; }//Ad
        public string LastName { get; set; }//Soyad
        public string Phone { get; set; }//Telefon
        public string Address { get; set; }//Adres
        public string EMail { get; set; }//Mail
        public string Password { get; set; }//Sifre
        public DateTime BirthDate { get; set; }//Doğum Tarihi
        public bool Antiqurian { get; set; }//Sahaf Mı
        //public string ImageUrl { get; set; }


        //Foreign Key
        public int RoleID { get; set; }


        public virtual Role Role { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Advert> Adverts { get; set; }
        public virtual List<UserFavoriteDetail> FavoriteDetails { get; set; }
        public virtual List<CommentDetail> CommentDetails { get; set; }
        public virtual List<Message> Messages { get; set; }
    }
}
