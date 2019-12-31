using Sahaf.Model;
using Sahaf.Model.DTO;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.DAL.Concrete
{
    public class SahafDbContext : DbContext
    {
        public SahafDbContext() : base(@"server=.;Database=sahafDB;Integrated Security=true;")
        {
            //Database.SetInitializer<SahafDbContext>(new MyStrategy());
        }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CommentDetail> CommentDetails { get; set; }
        public DbSet<UserFavoriteDetail> UserFavoriteDetails { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Message>()
            .HasRequired<User>(s => s.User)
            .WithMany(g => g.Messages)
            .HasForeignKey<int>(s => s.RMessageID);

            modelBuilder.Entity<Message>()
            .HasRequired<User>(s => s.User)
            .WithMany(g => g.Messages)
            .HasForeignKey<int>(s => s.SMessageID);

            modelBuilder.Properties().Where(a => a.PropertyType == typeof(DateTime)).Configure(a => a.HasColumnType("datetime2"));
        }
    }
}
