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
                new Categories() { CategoryID = 1, CategoryName = "����" },
                new Categories() { CategoryID = 2, CategoryName = "����" },
                new Categories() { CategoryID = 3, CategoryName = "����" },
                new Categories() { CategoryID = 4, CategoryName = "�٫�" }
            );
            context.Colors.AddOrUpdate(
                x => x.ColorID,
                new Colors() { ColorID = 1, Color = "18k Gold" }
            );
            context.Sizes.AddOrUpdate(
                x => x.SizeID,
                new Sizes() { SizeID = 1, SizeTitle = "���", SizeContext = "14" },
                new Sizes() { SizeID = 2, SizeTitle = "���", SizeContext = "15.5" },
                new Sizes() { SizeID = 3, SizeTitle = "���", SizeContext = "17" },
                new Sizes() { SizeID = 4, SizeTitle = "�ؤo", SizeContext = "��@�ؤo" },
                new Sizes() { SizeID = 5, SizeTitle = "���", SizeContext = "42" },
                new Sizes() { SizeID = 6, SizeTitle = "���", SizeContext = "46" },
                new Sizes() { SizeID = 7, SizeTitle = "�ؤo", SizeContext = "2" },
                new Sizes() { SizeID = 8, SizeTitle = "�ؤo", SizeContext = "3" }
            );
            context.Products.AddOrUpdate(
                x => x.ProductID,
                new Products() { ProductID = 1, ProductName = "�ӯ]�»Ȥ���", CategoryID = 1, UnitPrice = 1250, DesSubTitle = "�N²���ӽ�P�D�q�e�����`��f���A�ӽo�����u�B�º骺�y�����~�A�֦����ηf�t�ʻP�u���g�H����", DesDetail = "����G�»�\r\n�C��G18k���h\r\n����G14/15.5/17 cm�]�i�վ�^\r\nMORE INFORMATION" },
                new Products() { ProductID = 2, ProductName = "�p�ۯ»Ȧզ�", CategoryID = 2, UnitPrice = 1580, DesSubTitle = "��y���k��������L���өʦզ��A�L���լ}�������W�հ��A�����ղK�W�ɻ�y�O�C", DesDetail = "����G�»ȡB2mm��u���^�p��\r\n�C��G18k���h\r\n�ؤo�G��@�ؤo" },
                new Products() { ProductID = 3, ProductName = "�ӯ]�h���»ȶ���", CategoryID = 3, UnitPrice = 2250, DesSubTitle = "�h�h������a�����յ��R���A�A²������P�Ӥp��]�o�өʡB�ɻ��ٱa���u���ʷP�A�U�س��X�P��f�����o�W���I", DesDetail = "����G�»�\r\n�C��G18k���h\r\n����G42/46 cm�]�i�վ�^" },
                new Products() { ProductID = 4, ProductName = "�K�~�P�ϳ��»ȧ���", CategoryID = 4, UnitPrice = 1700, DesSubTitle = "��y���k��������L���ϳ����١A²���j��өʤQ���A�P��L�ڦ����h�h����f�A�a�ӷs�¤������������X�C", DesDetail = "�»ȧ���\r\n18k���h\r\n1mm ��u���^�p��\r\n�ؤo�G2 / 3" }
            );
            context.ProductDestails.AddOrUpdate(
                x => x.PDID,
                new ProductDestails() { PDID = "1-1", ProductID = 1, Stock = 10, SizeID = 1, ColorID = 1 },
                new ProductDestails() { PDID = "1-2", ProductID = 1, Stock = 10, SizeID = 2, ColorID = 1 },
                new ProductDestails() { PDID = "1-3", ProductID = 1, Stock = 10, SizeID = 3, ColorID = 1 },
                new ProductDestails() { PDID = "2-1", ProductID = 2, Stock = 10, SizeID = 4, ColorID = 1 },
                new ProductDestails() { PDID = "3-1", ProductID = 3, Stock = 5, SizeID = 5, ColorID = 1 },
                new ProductDestails() { PDID = "3-2", ProductID = 3, Stock = 5, SizeID = 6, ColorID = 1 },
                new ProductDestails() { PDID = "4-1", ProductID = 4, Stock = 3, SizeID = 7, ColorID = 1 },
                new ProductDestails() { PDID = "4-2", ProductID = 4, Stock = 3, SizeID = 8, ColorID = 1 }
            );
            context.Image.AddOrUpdate(
                x => x.ImgID,
                new Image() { ImgID = 1, PDID = "1-1", ImgName = "�ӯ]�»Ȥ���1" },
                new Image() { ImgID = 2, PDID = "1-1", ImgName = "�ӯ]�»Ȥ���2" },
                new Image() { ImgID = 3, PDID = "1-1", ImgName = "�ӯ]�»Ȥ���3" },
                new Image() { ImgID = 4, PDID = "2-1", ImgName = "�p�ۯ»Ȧզ�1" },
                new Image() { ImgID = 5, PDID = "2-1", ImgName = "�p�ۯ»Ȧզ�2" },
                new Image() { ImgID = 6, PDID = "3-1", ImgName = "�ӯ]�h���»ȶ���1" },
                new Image() { ImgID = 7, PDID = "3-1", ImgName = "�ӯ]�h���»ȶ���2" },
                new Image() { ImgID = 8, PDID = "4-1", ImgName = "�K�~�P�ϳ��»ȧ���1" },
                new Image() { ImgID = 9, PDID = "4-1", ImgName = "�K�~�P�ϳ��»ȧ���2" }
            );
            context.Customers.AddOrUpdate(
                x => x.CustomerID,
                new Customers() { CustomerID = 1, CustomerName = "Anvi", Phone = "0900-000-123", Country = "Taiwan", City = "Taipei", Email = "anvi@gmail.com", Address = "5F., Aly. 4, Ln. 2, Dalong St., Datong Dist., Taipei City", ZipCode = "103" },
                new Customers() { CustomerID = 2, CustomerName = "���ؤj��", Phone = "03-563-1988", Country = "Taiwan", City = "�s��", Email = "chu@chu.edu.tw", Address = "�s�˥����s�Ϥ��ָ��G�q707��", ZipCode = "300" }
            );
            context.Shipper.AddOrUpdate(
                x => x.ShipperID,
                new Shipper() { ShipperID = 1, ShippName = "�¿�", Phone = "02-321-5523" },
                new Shipper() { ShipperID = 2, ShippName = "�l��", Phone = "02-123-5529" }
            );
            context.Orders.AddOrUpdate(
                x=>x.OrderID,
                new Orders() { OrderID = 1, CustomerID = 1, ShippingID = 1, RecipientName = "Hu", RecipientAddressee = "��饫���c��", RecipientZipCod = "320", RecipientCity = "���", RecipientPhone = "0967-890-000", Payment = "�W�Ө��f", OrderDate = new DateTime(2019,03,20,0,12,10,927), Remaeks  = "�@�Ѥ��X�f", ShipDate = new DateTime(2019,03,21,0,12,10,927) }
            );
            context.OrderDetail.AddOrUpdate(
                x => x.OrderID,
                new OrderDetail() { OrderID = 1, ProductID = 4, Price = 1700, Quantity = 1 }
            );
        }
    }
}
