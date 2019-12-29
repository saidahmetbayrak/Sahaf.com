namespace Sahaf.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adverts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        Writer = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Condition = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Language = c.String(),
                        Stock = c.Short(nullable: false),
                        PublisherName = c.String(),
                        PublishYear = c.Int(nullable: false),
                        Description = c.String(),
                        AdvertİmgUrl = c.String(),
                        UserID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CommentDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdvertID = c.Int(),
                        UserID = c.Int(),
                        CommentID = c.Int(),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Adverts", t => t.AdvertID)
                .ForeignKey("dbo.Comments", t => t.CommentID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.AdvertID)
                .Index(t => t.UserID)
                .Index(t => t.CommentID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        CommentDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        EMail = c.String(),
                        Password = c.String(),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Antiqurian = c.Boolean(nullable: false),
                        RoleID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.UserFavoriteDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdvertID = c.Int(),
                        UserID = c.Int(),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SMessageID = c.Int(nullable: false),
                        RMessageID = c.Int(nullable: false),
                        MessageText = c.String(),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Subject = c.String(),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                        UserR_ID = c.Int(),
                        UserS_ID = c.Int(),
                        User_ID = c.Int(),
                        User_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserR_ID)
                .ForeignKey("dbo.Users", t => t.UserS_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .ForeignKey("dbo.Users", t => t.User_ID1)
                .Index(t => t.UserR_ID)
                .Index(t => t.UserS_ID)
                .Index(t => t.User_ID)
                .Index(t => t.User_ID1);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Payment = c.Int(nullable: false),
                        ShipperID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        AdvertID = c.Int(),
                        OrderID = c.Int(),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Adverts", t => t.AdvertID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .Index(t => t.AdvertID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Roles = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserFavoriteDetailAdverts",
                c => new
                    {
                        UserFavoriteDetail_ID = c.Int(nullable: false),
                        Advert_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserFavoriteDetail_ID, t.Advert_ID })
                .ForeignKey("dbo.UserFavoriteDetails", t => t.UserFavoriteDetail_ID, cascadeDelete: true)
                .ForeignKey("dbo.Adverts", t => t.Advert_ID, cascadeDelete: true)
                .Index(t => t.UserFavoriteDetail_ID)
                .Index(t => t.Advert_ID);
            
            CreateTable(
                "dbo.UserFavoriteDetailUsers",
                c => new
                    {
                        UserFavoriteDetail_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserFavoriteDetail_ID, t.User_ID })
                .ForeignKey("dbo.UserFavoriteDetails", t => t.UserFavoriteDetail_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.UserFavoriteDetail_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "AdvertID", "dbo.Adverts");
            DropForeignKey("dbo.Messages", "User_ID1", "dbo.Users");
            DropForeignKey("dbo.Messages", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Messages", "UserS_ID", "dbo.Users");
            DropForeignKey("dbo.Messages", "UserR_ID", "dbo.Users");
            DropForeignKey("dbo.UserFavoriteDetailUsers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.UserFavoriteDetailUsers", "UserFavoriteDetail_ID", "dbo.UserFavoriteDetails");
            DropForeignKey("dbo.UserFavoriteDetailAdverts", "Advert_ID", "dbo.Adverts");
            DropForeignKey("dbo.UserFavoriteDetailAdverts", "UserFavoriteDetail_ID", "dbo.UserFavoriteDetails");
            DropForeignKey("dbo.CommentDetails", "UserID", "dbo.Users");
            DropForeignKey("dbo.Adverts", "UserID", "dbo.Users");
            DropForeignKey("dbo.CommentDetails", "CommentID", "dbo.Comments");
            DropForeignKey("dbo.CommentDetails", "AdvertID", "dbo.Adverts");
            DropForeignKey("dbo.Adverts", "CategoryID", "dbo.Categories");
            DropIndex("dbo.UserFavoriteDetailUsers", new[] { "User_ID" });
            DropIndex("dbo.UserFavoriteDetailUsers", new[] { "UserFavoriteDetail_ID" });
            DropIndex("dbo.UserFavoriteDetailAdverts", new[] { "Advert_ID" });
            DropIndex("dbo.UserFavoriteDetailAdverts", new[] { "UserFavoriteDetail_ID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "AdvertID" });
            DropIndex("dbo.Orders", new[] { "UserID" });
            DropIndex("dbo.Messages", new[] { "User_ID1" });
            DropIndex("dbo.Messages", new[] { "User_ID" });
            DropIndex("dbo.Messages", new[] { "UserS_ID" });
            DropIndex("dbo.Messages", new[] { "UserR_ID" });
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.CommentDetails", new[] { "CommentID" });
            DropIndex("dbo.CommentDetails", new[] { "UserID" });
            DropIndex("dbo.CommentDetails", new[] { "AdvertID" });
            DropIndex("dbo.Adverts", new[] { "CategoryID" });
            DropIndex("dbo.Adverts", new[] { "UserID" });
            DropTable("dbo.UserFavoriteDetailUsers");
            DropTable("dbo.UserFavoriteDetailAdverts");
            DropTable("dbo.Roles");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Messages");
            DropTable("dbo.UserFavoriteDetails");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.CommentDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.Adverts");
        }
    }
}
