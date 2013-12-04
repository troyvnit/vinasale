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
                "dbo.Discounts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        PostName = c.String(),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        Avatar = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
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
                        ClassifiedAd_PostId = c.Int(),
                        Discount_PostId = c.Int(),
                        News_PostId = c.Int(),
                        Product_PostId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.ClassifiedAds", t => t.ClassifiedAd_PostId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Discounts", t => t.Discount_PostId)
                .ForeignKey("dbo.News", t => t.News_PostId)
                .ForeignKey("dbo.Products", t => t.Product_PostId)
                .Index(t => t.ClassifiedAd_PostId)
                .Index(t => t.UserId)
                .Index(t => t.Discount_PostId)
                .Index(t => t.News_PostId)
                .Index(t => t.Product_PostId);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        LikeId = c.Long(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ClassifiedAd_PostId = c.Int(),
                        Comment_CommentId = c.Long(),
                        Discount_PostId = c.Int(),
                        News_PostId = c.Int(),
                        Product_PostId = c.Int(),
                    })
                .PrimaryKey(t => t.LikeId)
                .ForeignKey("dbo.ClassifiedAds", t => t.ClassifiedAd_PostId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Comments", t => t.Comment_CommentId)
                .ForeignKey("dbo.Discounts", t => t.Discount_PostId)
                .ForeignKey("dbo.News", t => t.News_PostId)
                .ForeignKey("dbo.Products", t => t.Product_PostId)
                .Index(t => t.ClassifiedAd_PostId)
                .Index(t => t.UserId)
                .Index(t => t.Comment_CommentId)
                .Index(t => t.Discount_PostId)
                .Index(t => t.News_PostId)
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
                "dbo.ClassifiedAds",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PostName = c.String(),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        Avatar = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        PostName = c.String(),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        Avatar = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        PostName = c.String(),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        Avatar = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Likes", "Product_PostId", "dbo.Products");
            DropForeignKey("dbo.Comments", "Product_PostId", "dbo.Products");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Likes", "News_PostId", "dbo.News");
            DropForeignKey("dbo.Comments", "News_PostId", "dbo.News");
            DropForeignKey("dbo.News", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Likes", "Discount_PostId", "dbo.Discounts");
            DropForeignKey("dbo.Comments", "Discount_PostId", "dbo.Discounts");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Likes", "Comment_CommentId", "dbo.Comments");
            DropForeignKey("dbo.Likes", "UserId", "dbo.Users");
            DropForeignKey("dbo.ClassifiedAds", "UserId", "dbo.Users");
            DropForeignKey("dbo.Likes", "ClassifiedAd_PostId", "dbo.ClassifiedAds");
            DropForeignKey("dbo.Comments", "ClassifiedAd_PostId", "dbo.ClassifiedAds");
            DropForeignKey("dbo.Brands", "UserId", "dbo.Users");
            DropForeignKey("dbo.Discounts", "BrandId", "dbo.Brands");
            DropIndex("dbo.Likes", new[] { "Product_PostId" });
            DropIndex("dbo.Comments", new[] { "Product_PostId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Likes", new[] { "News_PostId" });
            DropIndex("dbo.Comments", new[] { "News_PostId" });
            DropIndex("dbo.News", new[] { "BrandId" });
            DropIndex("dbo.Likes", new[] { "Discount_PostId" });
            DropIndex("dbo.Comments", new[] { "Discount_PostId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Likes", new[] { "Comment_CommentId" });
            DropIndex("dbo.Likes", new[] { "UserId" });
            DropIndex("dbo.ClassifiedAds", new[] { "UserId" });
            DropIndex("dbo.Likes", new[] { "ClassifiedAd_PostId" });
            DropIndex("dbo.Comments", new[] { "ClassifiedAd_PostId" });
            DropIndex("dbo.Brands", new[] { "UserId" });
            DropIndex("dbo.Discounts", new[] { "BrandId" });
            DropTable("dbo.Products");
            DropTable("dbo.News");
            DropTable("dbo.ClassifiedAds");
            DropTable("dbo.Users");
            DropTable("dbo.Likes");
            DropTable("dbo.Comments");
            DropTable("dbo.Discounts");
            DropTable("dbo.Brands");
        }
    }
}
