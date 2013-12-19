namespace VinaSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VNS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        Logo = c.String(),
                        Slogan = c.String(),
                        BrandType = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BrandId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostName = c.String(),
                        PostShortDescription = c.String(),
                        PostDescription = c.String(),
                        PostAvatar = c.String(),
                        PostTags = c.String(),
                        ContactInfo = c.String(),
                        Address = c.String(),
                        Latitude = c.Single(nullable: false),
                        Longitude = c.Single(nullable: false),
                        Priority = c.Int(nullable: false),
                        PostSize = c.Int(nullable: false),
                        PostType = c.Int(nullable: false),
                        IsActived = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Long(nullable: false, identity: true),
                        CommentContent = c.String(),
                        UserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Event_PostId = c.Int(),
                        Product_PostId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_PostId)
                .ForeignKey("dbo.Products", t => t.Product_PostId)
                .Index(t => t.UserId)
                .Index(t => t.Event_PostId)
                .Index(t => t.Product_PostId);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        LikeId = c.Long(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Comment_CommentId = c.Long(),
                        Event_PostId = c.Int(),
                        Product_PostId = c.Int(),
                    })
                .PrimaryKey(t => t.LikeId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Comments", t => t.Comment_CommentId)
                .ForeignKey("dbo.Events", t => t.Event_PostId)
                .ForeignKey("dbo.Products", t => t.Product_PostId)
                .Index(t => t.UserId)
                .Index(t => t.Comment_CommentId)
                .Index(t => t.Event_PostId)
                .Index(t => t.Product_PostId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        DisplayName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        ProfilePicture = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        MediaId = c.Int(nullable: false, identity: true),
                        MediaName = c.String(),
                        MediaUrl = c.String(),
                        ThumbnailUrl = c.String(),
                        MediaType = c.Int(nullable: false),
                        Event_PostId = c.Int(),
                        Product_PostId = c.Int(),
                    })
                .PrimaryKey(t => t.MediaId)
                .ForeignKey("dbo.Events", t => t.Event_PostId)
                .ForeignKey("dbo.Products", t => t.Product_PostId)
                .Index(t => t.Event_PostId)
                .Index(t => t.Product_PostId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostName = c.String(),
                        PostShortDescription = c.String(),
                        PostDescription = c.String(),
                        PostAvatar = c.String(),
                        PostTags = c.String(),
                        ContactInfo = c.String(),
                        Address = c.String(),
                        Latitude = c.Single(nullable: false),
                        Longitude = c.Single(nullable: false),
                        Priority = c.Int(nullable: false),
                        PostSize = c.Int(nullable: false),
                        PostType = c.Int(nullable: false),
                        IsActived = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "Product_PostId", "dbo.Products");
            DropForeignKey("dbo.Likes", "Product_PostId", "dbo.Products");
            DropForeignKey("dbo.Comments", "Product_PostId", "dbo.Products");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Media", "Event_PostId", "dbo.Events");
            DropForeignKey("dbo.Likes", "Event_PostId", "dbo.Events");
            DropForeignKey("dbo.Comments", "Event_PostId", "dbo.Events");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Likes", "Comment_CommentId", "dbo.Comments");
            DropForeignKey("dbo.Likes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Brands", "UserId", "dbo.Users");
            DropForeignKey("dbo.Events", "BrandId", "dbo.Brands");
            DropIndex("dbo.Media", new[] { "Product_PostId" });
            DropIndex("dbo.Likes", new[] { "Product_PostId" });
            DropIndex("dbo.Comments", new[] { "Product_PostId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Media", new[] { "Event_PostId" });
            DropIndex("dbo.Likes", new[] { "Event_PostId" });
            DropIndex("dbo.Comments", new[] { "Event_PostId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Likes", new[] { "Comment_CommentId" });
            DropIndex("dbo.Likes", new[] { "UserId" });
            DropIndex("dbo.Brands", new[] { "UserId" });
            DropIndex("dbo.Events", new[] { "BrandId" });
            DropTable("dbo.Products");
            DropTable("dbo.Media");
            DropTable("dbo.Users");
            DropTable("dbo.Likes");
            DropTable("dbo.Comments");
            DropTable("dbo.Events");
            DropTable("dbo.Brands");
        }
    }
}
