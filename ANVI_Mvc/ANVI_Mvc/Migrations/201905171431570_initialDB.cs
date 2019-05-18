namespace ANVI_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(nullable: false, maxLength: 20),
                        CategoryID = c.Int(),
                        UnitPrice = c.Decimal(storeType: "money"),
                        DesSubTitle = c.String(),
                        DesDetail = c.String(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                        Price = c.Decimal(storeType: "money"),
                        Quantity = c.Decimal(storeType: "money"),
                        Discount = c.Decimal(storeType: "money"),
                        Products_ProductID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ProductID, t.OrderID })
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.Products_ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.Products_ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        ShippingID = c.Int(),
                        RecipientName = c.String(nullable: false, maxLength: 15),
                        RecipientAddressee = c.String(nullable: false, maxLength: 30),
                        RecipientZipCod = c.String(maxLength: 10),
                        RecipientCity = c.String(nullable: false, maxLength: 10),
                        RecipientPhone = c.String(nullable: false, maxLength: 20),
                        Payment = c.String(nullable: false, maxLength: 15),
                        OrderDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Remaeks = c.String(maxLength: 50),
                        ShipDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Shipper", t => t.ShippingID)
                .Index(t => t.CustomerID)
                .Index(t => t.ShippingID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false),
                        CustomerName = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Country = c.String(maxLength: 15),
                        City = c.String(maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        Address = c.String(),
                        ZipCode = c.String(maxLength: 10),
                        BankAccount = c.String(maxLength: 20),
                        CreditCard = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Shipper",
                c => new
                    {
                        ShipperID = c.Int(nullable: false),
                        ShippName = c.String(nullable: false, maxLength: 15),
                        Phone = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.ShipperID);
            
            CreateTable(
                "dbo.ProductDestails",
                c => new
                    {
                        PDID = c.String(nullable: false, maxLength: 10),
                        ProductID = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        SizeID = c.Int(nullable: false),
                        ColorID = c.Int(nullable: false),
                        Products_ProductID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PDID)
                .ForeignKey("dbo.Colors", t => t.ColorID)
                .ForeignKey("dbo.Sizes", t => t.SizeID)
                .ForeignKey("dbo.Products", t => t.Products_ProductID)
                .Index(t => t.SizeID)
                .Index(t => t.ColorID)
                .Index(t => t.Products_ProductID);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorID = c.Int(nullable: false),
                        Color = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ColorID);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ImgID = c.Int(nullable: false),
                        PDID = c.String(nullable: false, maxLength: 10),
                        ImgName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ImgID)
                .ForeignKey("dbo.ProductDestails", t => t.PDID)
                .Index(t => t.PDID);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        SizeID = c.Int(nullable: false),
                        SizeTitle = c.String(nullable: false, maxLength: 10),
                        SizeContext = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.SizeID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        diagram_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => new { t.name, t.principal_id, t.diagram_id });
            
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUserLogins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.ProductDestails", "Products_ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductDestails", "SizeID", "dbo.Sizes");
            DropForeignKey("dbo.Image", "PDID", "dbo.ProductDestails");
            DropForeignKey("dbo.ProductDestails", "ColorID", "dbo.Colors");
            DropForeignKey("dbo.OrderDetail", "Products_ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "ShippingID", "dbo.Shipper");
            DropForeignKey("dbo.OrderDetail", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Image", new[] { "PDID" });
            DropIndex("dbo.ProductDestails", new[] { "Products_ProductID" });
            DropIndex("dbo.ProductDestails", new[] { "ColorID" });
            DropIndex("dbo.ProductDestails", new[] { "SizeID" });
            DropIndex("dbo.Orders", new[] { "ShippingID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetail", new[] { "Products_ProductID" });
            DropIndex("dbo.OrderDetail", new[] { "OrderID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Sizes");
            DropTable("dbo.Image");
            DropTable("dbo.Colors");
            DropTable("dbo.ProductDestails");
            DropTable("dbo.Shipper");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.AspNetUserClaims", "UserId");
            CreateIndex("dbo.AspNetUsers", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            CreateIndex("dbo.AspNetRoles", "Name", unique: true, name: "RoleNameIndex");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
        }
    }
}
