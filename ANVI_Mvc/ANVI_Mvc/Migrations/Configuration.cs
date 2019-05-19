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
                new Size() { SizeID = 1, SizeTitle = "���", SizeContext = "14" },
                new Size() { SizeID = 2, SizeTitle = "���", SizeContext = "15.5" },
                new Size() { SizeID = 3, SizeTitle = "���", SizeContext = "17" },
                new Size() { SizeID = 4, SizeTitle = "�ؤo", SizeContext = "��@�ؤo" },
                new Size() { SizeID = 5, SizeTitle = "���", SizeContext = "42" },
                new Size() { SizeID = 6, SizeTitle = "���", SizeContext = "46" },
                new Size() { SizeID = 7, SizeTitle = "�ؤo", SizeContext = "2" },
                new Size() { SizeID = 8, SizeTitle = "�ؤo", SizeContext = "3" },
                new Size() { SizeID = 9, SizeTitle = "�ؤo", SizeContext = "5" },
                new Size() { SizeID = 10, SizeTitle = "�ؤo", SizeContext = "6" },
                new Size() { SizeID = 11, SizeTitle = "�ؤo", SizeContext = "7" }
            );
            context.Products.AddOrUpdate(
                x => x.ProductID,
                new Product() { ProductID = 1, ProductName = "�ӯ]�»Ȥ���", CategoryID = 1, UnitPrice = 1250, DesSubTitle = "�N²���ӽ�P�D�q�e�����`��f���A�ӽo�����u�B�º骺�y�����~�A�֦����ηf�t�ʻP�u���g�H����", DesDetail = "����G�»�\r\n�C��G18k���h\r\n����G14/15.5/17 cm�]�i�վ�^\r\nMORE INFORMATION" },
                new Product() { ProductID = 2, ProductName = "�p�ۯ»Ȧզ�", CategoryID = 2, UnitPrice = 1580, DesSubTitle = "��y���k��������L���өʦզ��A�L���լ}�������W�հ��A�����ղK�W�ɻ�y�O�C", DesDetail = "����G�»ȡB2mm��u���^�p��\r\n�C��G18k���h\r\n�ؤo�G��@�ؤo" },
                new Product() { ProductID = 3, ProductName = "�ӯ]�h���»ȶ���", CategoryID = 3, UnitPrice = 2250, DesSubTitle = "�h�h������a�����յ��R���A�A²������P�Ӥp��]�o�өʡB�ɻ��ٱa���u���ʷP�A�U�س��X�P��f�����o�W���I", DesDetail = "����G�»�\r\n�C��G18k���h\r\n����G42/46 cm�]�i�վ�^" },
                new Product() { ProductID = 4, ProductName = "�K�~�P�ϳ��»ȧ���", CategoryID = 4, UnitPrice = 1700, DesSubTitle = "��y���k��������L���ϳ����١A²���j��өʤQ���A�P��L�ڦ����h�h����f�A�a�ӷs�¤������������X�C", DesDetail = "�»ȧ���\r\n18k���h\r\n1mm ��u���^�p��\r\n�ؤo�G2 / 3" },
                new Product() { ProductID = 5, ProductName = "�p��C�r�٫�", CategoryID = 4, UnitPrice = 900, DesSubTitle = "�N²���ӽ�P�D�q�e�����`��f���A�ӽo�����u�B�º骺�y�����~�A�֦����ηf�t�ʻP�u���g�H�����C", DesDetail = "����G�»ȡB1mm��u���^�p��\r\n�C��G18k���h\r\n�ؤo�G5 / 6 / 7" }
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
                new Image() { ImgID = 1, PDID = "1-1", ImgName = "�ӯ]�»Ȥ���1" },
                new Image() { ImgID = 2, PDID = "1-1", ImgName = "�ӯ]�»Ȥ���2" },
                new Image() { ImgID = 3, PDID = "1-1", ImgName = "�ӯ]�»Ȥ���3" },
                new Image() { ImgID = 4, PDID = "2-1", ImgName = "�p�ۯ»Ȧզ�1" },
                new Image() { ImgID = 5, PDID = "2-1", ImgName = "�p�ۯ»Ȧզ�2" },
                new Image() { ImgID = 6, PDID = "3-1", ImgName = "�ӯ]�h���»ȶ���1" },
                new Image() { ImgID = 7, PDID = "3-1", ImgName = "�ӯ]�h���»ȶ���2" },
                new Image() { ImgID = 8, PDID = "4-1", ImgName = "�K�~�P�ϳ��»ȧ���1" },
                new Image() { ImgID = 9, PDID = "4-1", ImgName = "�K�~�P�ϳ��»ȧ���2" },
                new Image() { ImgID = 10, PDID = "5-1", ImgName = "R19402-2_600x.jpg" },
                new Image() { ImgID = 11, PDID = "5-1", ImgName = "c_2_7563982b-8284-4637-a92b-a3763e0256d3_700x.jpg" },
                new Image() { ImgID = 12, PDID = "5-1", ImgName = "C_3_ef589395-f96a-4215-8b61-841d4fc579cf_700x.jpg" }
            );
            context.Customers.AddOrUpdate(
                x => x.CustomerID,
                new Customer() { CustomerID = 1, CustomerName = "Anvi", Phone = "0900-000-123", Country = "Taiwan", City = "Taipei", Email = "anvi@gmail.com", Address = "5F., Aly. 4, Ln. 2, Dalong St., Datong Dist., Taipei City", ZipCode = "103" },
                new Customer() { CustomerID = 2, CustomerName = "���ؤj��", Phone = "03-563-1988", Country = "Taiwan", City = "�s��", Email = "chu@chu.edu.tw", Address = "�s�˥����s�Ϥ��ָ��G�q707��", ZipCode = "300" }
            );
            context.Shippers.AddOrUpdate(
                x => x.ShipperID,
                new Shipper() { ShipperID = 1, ShippName = "�¿�", Phone = "02-321-5523" },
                new Shipper() { ShipperID = 2, ShippName = "�l��", Phone = "02-123-5529" }
            );
            context.Orders.AddOrUpdate(
                x => x.OrderID,
                new Order() { OrderID = 1, CustomerID = 1, ShippingID = 1, RecipientName = "Hu", RecipientAddressee = "��饫���c��", RecipientZipCod = "320", RecipientCity = "���", RecipientPhone = "0967-890-000", Payment = "�W�Ө��f", OrderDate = new DateTime(2019, 03, 20, 0, 12, 10, 927), Remaeks = "�@�Ѥ��X�f", ShipDate = new DateTime(2019, 03, 21, 0, 12, 10, 927) }
            );
            context.OrderDetails.AddOrUpdate(
                x => x.OrderID,
                new OrderDetail() { OrderID = 1, ProductID = 4, Price = 1700, Quantity = 1 }
            );
        }
    }
}
