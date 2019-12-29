namespace Sahaf.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ffff : DbMigration
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
                        Order_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .Index(t => t.UserID)
                .Index(t => t.CategoryID)
                .Index(t => t.Order_ID);
            
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
                        AdvertID = c.Int(nullable: false),
                        CommentID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.AdvertID, t.CommentID, t.UserID })
                .ForeignKey("dbo.Adverts", t => t.ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        CommentDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                        CommentDetails_AdvertID = c.Int(),
                        CommentDetails_CommentID = c.Int(),
                        CommentDetails_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CommentDetails", t => new { t.CommentDetails_AdvertID, t.CommentDetails_CommentID, t.CommentDetails_UserID })
                .Index(t => new { t.CommentDetails_AdvertID, t.CommentDetails_CommentID, t.CommentDetails_UserID });
            
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
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SMessageID = c.Int(nullable: false),
                        RMessageID = c.Int(nullable: false),
                        MessageText = c.String(),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Subject = c.String(),
                        UserID = c.Int(nullable: false),
                        UserIDS = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActive = c.Boolean(nullable: false),
                        UserS_ID = c.Int(),
                        User_ID = c.Int(),
                        User_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserS_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .ForeignKey("dbo.Users", t => t.User_ID1)
                .Index(t => t.UserID)
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
                        OrderDetail_OrderID = c.Int(),
                        OrderDetail_AdvertID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.OrderDetails", t => new { t.OrderDetail_OrderID, t.OrderDetail_AdvertID })
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => new { t.OrderDetail_OrderID, t.OrderDetail_AdvertID });
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        AdvertID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.AdvertID })
                .ForeignKey("dbo.Adverts", t => t.AdvertID, cascadeDelete: true)
                .Index(t => t.AdvertID);
            
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
                "dbo.UserFavoriteDetails",
                c => new
                    {
                        AdvertID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AdvertID, t.UserID })
                .ForeignKey("dbo.Adverts", t => t.AdvertID, cascadeDelete: true)
                .Index(t => t.AdvertID);
            
            CreateTable(
                "dbo.UserFavoriteDetailUsers",
                c => new
                    {
                        UserFavoriteDetail_AdvertID = c.Int(nullable: false),
                        UserFavoriteDetail_UserID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserFavoriteDetail_AdvertID, t.UserFavoriteDetail_UserID, t.User_ID })
                .ForeignKey("dbo.UserFavoriteDetails", t => new { t.UserFavoriteDetail_AdvertID, t.UserFavoriteDetail_UserID }, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => new { t.UserFavoriteDetail_AdvertID, t.UserFavoriteDetail_UserID })
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adverts", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.UserFavoriteDetailUsers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.UserFavoriteDetailUsers", new[] { "UserFavoriteDetail_AdvertID", "UserFavoriteDetail_UserID" }, "dbo.UserFavoriteDetails");
            DropForeignKey("dbo.UserFavoriteDetails", "AdvertID", "dbo.Adverts");
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropForeignKey("dbo.Orders", new[] { "OrderDetail_OrderID", "OrderDetail_AdvertID" }, "dbo.OrderDetails");
            DropForeignKey("dbo.OrderDetails", "AdvertID", "dbo.Adverts");
            DropForeignKey("dbo.Messages", "User_ID1", "dbo.Users");
            DropForeignKey("dbo.Messages", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Messages", "UserS_ID", "dbo.Users");
            DropForeignKey("dbo.Messages", "UserID", "dbo.Users");
            DropForeignKey("dbo.CommentDetails", "ID", "dbo.Users");
            DropForeignKey("dbo.Adverts", "UserID", "dbo.Users");
            DropForeignKey("dbo.Comments", new[] { "CommentDetails_AdvertID", "CommentDetails_CommentID", "CommentDetails_UserID" }, "dbo.CommentDetails");
            DropForeignKey("dbo.CommentDetails", "ID", "dbo.Adverts");
            DropForeignKey("dbo.Adverts", "CategoryID", "dbo.Categories");
            DropIndex("dbo.UserFavoriteDetailUsers", new[] { "User_ID" });
            DropIndex("dbo.UserFavoriteDetailUsers", new[] { "UserFavoriteDetail_AdvertID", "UserFavoriteDetail_UserID" });
            DropIndex("dbo.UserFavoriteDetails", new[] { "AdvertID" });
            DropIndex("dbo.OrderDetails", new[] { "AdvertID" });
            DropIndex("dbo.Orders", new[] { "OrderDetail_OrderID", "OrderDetail_AdvertID" });
            DropIndex("dbo.Orders", new[] { "UserID" });
            DropIndex("dbo.Messages", new[] { "User_ID1" });
            DropIndex("dbo.Messages", new[] { "User_ID" });
            DropIndex("dbo.Messages", new[] { "UserS_ID" });
            DropIndex("dbo.Messages", new[] { "UserID" });
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.Comments", new[] { "CommentDetails_AdvertID", "CommentDetails_CommentID", "CommentDetails_UserID" });
            DropIndex("dbo.CommentDetails", new[] { "ID" });
            DropIndex("dbo.Adverts", new[] { "Order_ID" });
            DropIndex("dbo.Adverts", new[] { "CategoryID" });
            DropIndex("dbo.Adverts", new[] { "UserID" });
            DropTable("dbo.UserFavoriteDetailUsers");
            DropTable("dbo.UserFavoriteDetails");
            DropTable("dbo.Roles");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Messages");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.CommentDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.Adverts");
        }
    }
}
