namespace ANVI_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDB : DbMigration
    {
        public override void Up()
        {
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
                        ProductID = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => new { t.ProductID, t.OrderID })
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.OrderID);
            
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
                        ZipCode = c.Int(),
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
                    })
                .PrimaryKey(t => t.PDID)
                .ForeignKey("dbo.Colors", t => t.ColorID)
                .ForeignKey("dbo.Sizes", t => t.SizeID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.SizeID)
                .Index(t => t.ColorID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDestails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductDestails", "SizeID", "dbo.Sizes");
            DropForeignKey("dbo.Image", "PDID", "dbo.ProductDestails");
            DropForeignKey("dbo.ProductDestails", "ColorID", "dbo.Colors");
            DropForeignKey("dbo.OrderDetail", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "ShippingID", "dbo.Shipper");
            DropForeignKey("dbo.OrderDetail", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Image", new[] { "PDID" });
            DropIndex("dbo.ProductDestails", new[] { "ColorID" });
            DropIndex("dbo.ProductDestails", new[] { "SizeID" });
            DropIndex("dbo.ProductDestails", new[] { "ProductID" });
            DropIndex("dbo.Orders", new[] { "ShippingID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetail", new[] { "OrderID" });
            DropIndex("dbo.OrderDetail", new[] { "ProductID" });
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
        }
    }
}
