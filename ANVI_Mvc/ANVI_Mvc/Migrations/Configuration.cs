using ANVI_Mvc.Models;

namespace ANVI_Mvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ANVI_Mvc.Models.AnviModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ANVI_Mvc.Models.AnviModel context)
        {
            context.Categories.AddOrUpdate(
                x => x.CategoryID,
                new Category() { CategoryID = 1, CategoryName = "Bracelets" },
                new Category() { CategoryID = 2, CategoryName = "EarRings" },
                new Category() { CategoryID = 3, CategoryName = "Necklaces" },
                new Category() { CategoryID = 4, CategoryName = "Rings" }
            );
            context.Colors.AddOrUpdate(
                x => x.ColorID,
                new Color() { ColorID = 1, ColorName = "18k-Gold" }
            );
            context.Sizes.AddOrUpdate(
                x => x.SizeID,
                new Size() { SizeID = 1, SizeTitle = "鏈長", SizeContext = "14" },
                new Size() { SizeID = 2, SizeTitle = "鏈長", SizeContext = "15.5" },
                new Size() { SizeID = 3, SizeTitle = "鏈長", SizeContext = "17" },
                new Size() { SizeID = 4, SizeTitle = "尺寸", SizeContext = "單一尺寸" },
                new Size() { SizeID = 5, SizeTitle = "鏈長", SizeContext = "42" },
                new Size() { SizeID = 6, SizeTitle = "鏈長", SizeContext = "46" },
                new Size() { SizeID = 7, SizeTitle = "尺寸", SizeContext = "2" },
                new Size() { SizeID = 8, SizeTitle = "尺寸", SizeContext = "3" },
                new Size() { SizeID = 9, SizeTitle = "尺寸", SizeContext = "5" },
                new Size() { SizeID = 10, SizeTitle = "尺寸", SizeContext = "6" },
                new Size() { SizeID = 11, SizeTitle = "尺寸", SizeContext = "7" }
            );
            context.Products.AddOrUpdate(
                x => x.ProductID,
                new Product() { ProductID = 1, ProductName = "細珠純銀手鍊", CategoryID = 1, UnitPrice = 1250, DesSubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味", DesDetail = "材質：純銀\r\n顏色：18k金層\r\n鏈長：14/15.5/17 cm（可調整）\r\nMORE INFORMATION" },
                new Product() { ProductID = 2, ProductName = "鋯石純銀耳扣", CategoryID = 2, UnitPrice = 1580, DesSubTitle = "潮流型女絕不能錯過的個性耳扣，無須耳洞直接掛上耳骨，為雙耳添上時髦魅力。", DesDetail = "材質：純銀、2mm手工精鑲鋯石\r\n顏色：18k金層\r\n尺寸：單一尺寸" },
                new Product() { ProductID = 3, ProductName = "細珠層次純銀項鍊", CategoryID = 3, UnitPrice = 2250, DesSubTitle = "多層次項鍊帶有高調華麗姿態，簡約細鍊與細小圓珠卻個性、時髦還帶有優雅性感，各種場合與穿搭都派得上場！", DesDetail = "材質：純銀\r\n顏色：18k金層\r\n鏈長：42/46 cm（可調整）" },
                new Product() { ProductID = 4, ProductName = "八芒星圖章純銀尾戒", CategoryID = 4, UnitPrice = 1700, DesSubTitle = "潮流型女絕不能錯過的圖章尾戒，簡約大方個性十足，與其他款式做多層次穿搭，帶來新舊元素的完美結合。", DesDetail = "純銀材質\r\n18k金層\r\n1mm 手工精鑲鋯石\r\n尺寸：2 / 3" },
                new Product() { ProductID = 5, ProductName = "鋯石C字戒指", CategoryID = 4, UnitPrice = 900, DesSubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味。", DesDetail = "材質：純銀、1mm手工精鑲鋯石\r\n顏色：18k金層\r\n尺寸：5 / 6 / 7" }
            );
            context.ProductDestails.AddOrUpdate(
                x => x.PDID,
                new ProductDestail() { PDID = "1-1", ProductID = 1, Stock = 10, SizeID = 1, ColorID = 1 },
                new ProductDestail() { PDID = "1-2", ProductID = 1, Stock = 10, SizeID = 2, ColorID = 1 },
                new ProductDestail() { PDID = "1-3", ProductID = 1, Stock = 10, SizeID = 3, ColorID = 1 },
                new ProductDestail() { PDID = "2-1", ProductID = 2, Stock = 10, SizeID = 4, ColorID = 1 },
                new ProductDestail() { PDID = "3-1", ProductID = 3, Stock = 5, SizeID = 5, ColorID = 1 },
                new ProductDestail() { PDID = "3-2", ProductID = 3, Stock = 5, SizeID = 6, ColorID = 1 },
                new ProductDestail() { PDID = "4-1", ProductID = 4, Stock = 3, SizeID = 7, ColorID = 1 },
                new ProductDestail() { PDID = "4-2", ProductID = 4, Stock = 3, SizeID = 8, ColorID = 1 },
                new ProductDestail() { PDID = "5-1", ProductID = 5, Stock = 4, SizeID = 9, ColorID = 1 },
                new ProductDestail() { PDID = "5-2", ProductID = 5, Stock = 10, SizeID = 10, ColorID = 1 },
                new ProductDestail() { PDID = "5-3", ProductID = 5, Stock = 3, SizeID = 11, ColorID = 1 }
            );
            context.Images.AddOrUpdate(
                x => x.ImgID,
                new Image() { ImgID = 1, PDID = "1-1", ImgName = "細珠純銀手鍊1" },
                new Image() { ImgID = 2, PDID = "1-1", ImgName = "細珠純銀手鍊2" },
                new Image() { ImgID = 3, PDID = "1-1", ImgName = "細珠純銀手鍊3" },
                new Image() { ImgID = 4, PDID = "2-1", ImgName = "鋯石純銀耳扣1" },
                new Image() { ImgID = 5, PDID = "2-1", ImgName = "鋯石純銀耳扣2" },
                new Image() { ImgID = 6, PDID = "3-1", ImgName = "細珠層次純銀項鍊1" },
                new Image() { ImgID = 7, PDID = "3-1", ImgName = "細珠層次純銀項鍊2" },
                new Image() { ImgID = 8, PDID = "4-1", ImgName = "八芒星圖章純銀尾戒1" },
                new Image() { ImgID = 9, PDID = "4-1", ImgName = "八芒星圖章純銀尾戒2" },
                new Image() { ImgID = 10, PDID = "5-1", ImgName = "R19402-2_600x.jpg" },
                new Image() { ImgID = 11, PDID = "5-1", ImgName = "c_2_7563982b-8284-4637-a92b-a3763e0256d3_700x.jpg" },
                new Image() { ImgID = 12, PDID = "5-1", ImgName = "C_3_ef589395-f96a-4215-8b61-841d4fc579cf_700x.jpg" }
            );
            context.Customers.AddOrUpdate(
                x => x.CustomerID,
                new Customer() { CustomerID = 1, CustomerName = "Anvi", Phone = "0900-000-123", Country = "Taiwan", City = "Taipei", Email = "anvi@gmail.com", Address = "5F., Aly. 4, Ln. 2, Dalong St., Datong Dist., Taipei City", ZipCode = "103" },
                new Customer() { CustomerID = 2, CustomerName = "中華大學", Phone = "03-563-1988", Country = "Taiwan", City = "新竹", Email = "chu@chu.edu.tw", Address = "新竹市香山區五福路二段707號", ZipCode = "300" }
            );
            context.Shippers.AddOrUpdate(
                x => x.ShipperID,
                new Shipper() { ShipperID = 1, ShippName = "黑貓", Phone = "02-321-5523" },
                new Shipper() { ShipperID = 2, ShippName = "郵局", Phone = "02-123-5529" }
            );
            context.Orders.AddOrUpdate(
                x => x.OrderID,
                new Order() { OrderID = 1, CustomerID = 1, ShippingID = 1, RecipientName = "Hu", RecipientAddressee = "桃園市中壢區", RecipientZipCod = "320", RecipientCity = "桃園", RecipientPhone = "0967-890-000", Payment = "超商取貨", OrderDate = new DateTime(2019, 03, 20, 0, 12, 10, 927), Remaeks = "一天內出貨", ShipDate = new DateTime(2019, 03, 21, 0, 12, 10, 927) }
            );
            context.OrderDetails.AddOrUpdate(
                x => x.OrderID,
                new OrderDetail() { OrderID = 1, ProductID = 4, Price = 1700, Quantity = 1 }
            );
        }
    }
}
