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
                new Color() { ColorID = 1, ColorName = "18k-Gold" },
                new Color() { ColorID = 2, ColorName = "Rose Gold" },
                new Color() { ColorID = 3, ColorName = "Silver" }
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
                new Size() { SizeID = 11, SizeTitle = "尺寸", SizeContext = "7" },
                new Size() { SizeID = 12, SizeTitle = "尺寸", SizeContext = "7" },
                new Size() { SizeID = 13, SizeTitle = "鍊長", SizeContext = "40" },
                new Size() { SizeID = 14, SizeTitle = "尺寸", SizeContext = "單一尺寸(可調整)" }
            );
            context.Products.AddOrUpdate(
                x => x.ProductID,
                new Product() { ProductID = 1, ProductName = "細珠純銀手鍊", CategoryID = 1, UnitPrice = 1250 },
                new Product() { ProductID = 2, ProductName = "鋯石純銀耳扣", CategoryID = 2, UnitPrice = 1580 },
                new Product() { ProductID = 3, ProductName = "細珠層次純銀項鍊", CategoryID = 3, UnitPrice = 2250 },
                new Product() { ProductID = 4, ProductName = "八芒星圖章純銀尾戒", CategoryID = 4, UnitPrice = 1700 },
                new Product() { ProductID = 5, ProductName = "鋯石C字戒指", CategoryID = 4, UnitPrice = 900 },
                new Product() { ProductID = 6, ProductName = "雙圈純銀戒指", CategoryID = 4, UnitPrice = 1800 },
                new Product() { ProductID = 7, ProductName = "ESSENTIAL DOUBLE LAYER RING(3MM)", CategoryID = 4, UnitPrice = 2200 },
                new Product() { ProductID = 8, ProductName = "LOVE字樣戒指", CategoryID = 4, UnitPrice = 2050 },
                new Product() { ProductID = 9, ProductName = "BAE字樣戒指", CategoryID = 4, UnitPrice = 2050 },
                 new Product() { ProductID = 10, ProductName = "LOVE字樣戒指", CategoryID = 4, UnitPrice = 2050 },
                new Product() { ProductID = 11, ProductName = "BAE字樣戒指", CategoryID = 4, UnitPrice = 2050 },
                new Product() { ProductID = 12, ProductName = "CHINESE \"發\" NECKLACE", CategoryID = 3, UnitPrice = 1880 },
                new Product() { ProductID = 13, ProductName = "CHINESE \"喜\" NECKLACE", CategoryID = 3, UnitPrice = 1880 },
                new Product() { ProductID = 14, ProductName = "CHINESE \" 福 \" NECKLACE", CategoryID = 3, UnitPrice = 1880 },
                new Product() { ProductID = 15, ProductName = "經典開口設計手環", CategoryID = 1, UnitPrice = 3300 },
                new Product() { ProductID = 16, ProductName = "金屬純銀耳扣", CategoryID = 2, UnitPrice = 1180 },
                new Product() { ProductID = 17, ProductName = "雙圈閃耀細錐純銀手鍊", CategoryID = 1, UnitPrice = 1800 },
                new Product() { ProductID = 18, ProductName = "細珠層次純銀手鍊", CategoryID = 1, UnitPrice = 1850 }
            );
            context.ProductDetails.AddOrUpdate(
            x => x.PDID,
            new ProductDetail() { PDID = "1-1", ProductID = 1, Stock = 10, SizeID = 14, ColorID = 1 },
            new ProductDetail() { PDID = "2-1", ProductID = 2, Stock = 10, SizeID = 4, ColorID = 1 },
            new ProductDetail() { PDID = "3-1", ProductID = 3, Stock = 5, SizeID = 13, ColorID = 1 },
            new ProductDetail() { PDID = "4-1", ProductID = 4, Stock = 3, SizeID = 7, ColorID = 1 },
            new ProductDetail() { PDID = "4-2", ProductID = 4, Stock = 3, SizeID = 8, ColorID = 1 },
            new ProductDetail() { PDID = "5-1", ProductID = 5, Stock = 4, SizeID = 9, ColorID = 1 },
            new ProductDetail() { PDID = "5-2", ProductID = 5, Stock = 10, SizeID = 10, ColorID = 1 },
            new ProductDetail() { PDID = "5-3", ProductID = 5, Stock = 3, SizeID = 11, ColorID = 1 },
            new ProductDetail() { PDID = "6-1", ProductID = 6, Stock = 6, SizeID = 9, ColorID = 1, },
            new ProductDetail() { PDID = "6-2", ProductID = 6, Stock = 3, SizeID = 10, ColorID = 1, },
            new ProductDetail() { PDID = "6-3", ProductID = 6, Stock = 1, SizeID = 11, ColorID = 1, },
            new ProductDetail() { PDID = "7-1", ProductID = 7, Stock = 7, SizeID = 9, ColorID = 1, },
            new ProductDetail() { PDID = "7-2", ProductID = 7, Stock = 3, SizeID = 10, ColorID = 1, },
            new ProductDetail() { PDID = "7-3", ProductID = 7, Stock = 1, SizeID = 11, ColorID = 1, },
            new ProductDetail() { PDID = "7-4", ProductID = 7, Stock = 7, SizeID = 9, ColorID = 2, },
            new ProductDetail() { PDID = "7-5", ProductID = 7, Stock = 2, SizeID = 10, ColorID = 2, },
            new ProductDetail() { PDID = "7-6", ProductID = 7, Stock = 3, SizeID = 11, ColorID = 2, },
            new ProductDetail() { PDID = "8-1", ProductID = 8, Stock = 6, SizeID = 10, ColorID = 1, },
            new ProductDetail() { PDID = "8-2", ProductID = 8, Stock = 3, SizeID = 11, ColorID = 1, },
            new ProductDetail() { PDID = "9-1", ProductID = 9, Stock = 1, SizeID = 10, ColorID = 1, },
            new ProductDetail() { PDID = "9-2", ProductID = 9, Stock = 7, SizeID = 11, ColorID = 1, },
            new ProductDetail() { PDID = "10-1", ProductID = 10, Stock = 3, SizeID = 10, ColorID = 3, },
            new ProductDetail() { PDID = "10-2", ProductID = 10, Stock = 1, SizeID = 11, ColorID = 3, },
            new ProductDetail() { PDID = "11-1", ProductID = 11, Stock = 7, SizeID = 10, ColorID = 3, },
            new ProductDetail() { PDID = "11-2", ProductID = 11, Stock = 2, SizeID = 11, ColorID = 3, },
            new ProductDetail() { PDID = "12-1", ProductID = 12, Stock = 2, SizeID = 12, ColorID = 1 },
            new ProductDetail() { PDID = "13-1", ProductID = 13, Stock = 0, SizeID = 12, ColorID = 1 },
            new ProductDetail() { PDID = "14-1", ProductID = 14, Stock = 4, SizeID = 12, ColorID = 1 },
            new ProductDetail() { PDID = "15-1", ProductID = 15, Stock = 12, SizeID = 14, ColorID = 1, },
            new ProductDetail() { PDID = "16-1", ProductID = 16, Stock = 20, SizeID = 4, ColorID = 3, },
            new ProductDetail() { PDID = "17-1", ProductID = 17, Stock = 5, SizeID = 13, ColorID = 1 },
            new ProductDetail() { PDID = "18-1", ProductID = 18, Stock = 8, SizeID = 13, ColorID = 3 }
        );
            context.DesSubTitles.AddOrUpdate(
                x => x.DSTID,
                new DesSubTitle() { DSTID = 1, ProductID = 1, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味" },
                new DesSubTitle() { DSTID = 2, ProductID = 2, SubTitle = "潮流型女絕不能錯過的個性耳扣，無須耳洞直接掛上耳骨，為雙耳添上時髦魅力。" },
                new DesSubTitle() { DSTID = 3, ProductID = 3, SubTitle = "多層次項鍊帶有高調華麗姿態，簡約細鍊與細小圓珠卻個性、時髦還帶有優雅性感，各種場合與穿搭都派得上場！" },
                new DesSubTitle() { DSTID = 4, ProductID = 4, SubTitle = "潮流型女絕不能錯過的圖章尾戒，簡約大方個性十足，與其他款式做多層次穿搭，帶來新舊元素的完美結合。" },
                new DesSubTitle() { DSTID = 5, ProductID = 5, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味。" },
                new DesSubTitle() { DSTID = 6, ProductID = 6, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品， 擁有絕佳搭配性與優雅迷人韻味。" },
                new DesSubTitle() { DSTID = 7, ProductID = 7, SubTitle = "ANVI 經典設計款雙環戒指" },
                new DesSubTitle() { DSTID = 8, ProductID = 7, SubTitle = "經典簡約設計，現代感優雅雙環輕珠寶 獻給保有柔軟與堅毅的都會女性，一份令人豔羨的獨立宣言。" },
                new DesSubTitle { DSTID = 9, ProductID = 8, SubTitle = "對於字母情有獨鍾的妳絕不能錯過此款，獨特的鋯石閃耀穿插於金屬面之間， 獨特的款式獻給熱愛質感，獨一無二的妳。" },
                new DesSubTitle { DSTID = 10, ProductID = 9, SubTitle = "對於字母情有獨鍾的妳絕不能錯過此款，獨特的鋯石閃耀穿插於金屬面之間， 獨特的款式獻給熱愛質感，獨一無二的妳。" },
                new DesSubTitle { DSTID = 11, ProductID = 10, SubTitle = "對於字母情有獨鍾的妳絕不能錯過此款，獨特的鋯石閃耀穿插於金屬面之間， 獨特的款式獻給熱愛質感，獨一無二的妳。" },
                new DesSubTitle { DSTID = 12, ProductID = 11, SubTitle = "對於字母情有獨鍾的妳絕不能錯過此款，獨特的鋯石閃耀穿插於金屬面之間， 獨特的款式獻給熱愛質感，獨一無二的妳。" },
                new DesSubTitle() { DSTID = 13, ProductID = 12, SubTitle = "ANVI 早春系列新品 香檳金開運首飾揉合傳統過年吉祥字與簡約質感設計，優雅呈現新生代女性拜年首飾的最佳首選。" },
                new DesSubTitle() { DSTID = 14, ProductID = 13, SubTitle = "ANVI 早春系列新品 香檳金開運首飾揉合傳統過年吉祥字與簡約質感設計，優雅呈現新生代女性拜年首飾的最佳首選。" },
                new DesSubTitle() { DSTID = 15, ProductID = 14, SubTitle = "ANVI 早春系列新品 香檳金開運首飾揉合傳統過年吉祥字與簡約質感設計，優雅呈現新生代女性拜年首飾的最佳首選。" },
                new DesSubTitle() { DSTID = 16, ProductID = 15, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品， 擁有絕佳搭配性與優雅迷人韻味。" },
                new DesSubTitle() { DSTID = 17, ProductID = 16, SubTitle = "潮流型女絕不能錯過的個性耳扣，無須耳洞直接掛上耳骨，為雙耳添上時髦魅力。" },
                new DesSubTitle() { DSTID = 18, ProductID = 17, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味" },
                new DesSubTitle() { DSTID = 19, ProductID = 18, SubTitle = "將簡約而質感主義貫徹於日常穿搭中，細緻的做工、純粹的造型飾品，擁有絕佳搭配性與優雅迷人韻味" }

            );
            context.DesDetails.AddOrUpdate(
                x => x.DDID,
                new DesDetail() { DDID = 1, ProductID = 1, Detail = "材質：純銀" },
                new DesDetail() { DDID = 2, ProductID = 1, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 3, ProductID = 1, Detail = "鏈長：14/15.5/17 cm（可調整）" },
                new DesDetail() { DDID = 4, ProductID = 1, Detail = "材質：純銀、2mm手工精鑲鋯石" },
                new DesDetail() { DDID = 5, ProductID = 2, Detail = "材質：純銀、2mm手工精鑲鋯石" },
                new DesDetail() { DDID = 6, ProductID = 2, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 7, ProductID = 2, Detail = "尺寸：單一尺寸" },
                new DesDetail() { DDID = 8, ProductID = 3, Detail = "材質：純銀" },
                new DesDetail() { DDID = 9, ProductID = 3, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 10, ProductID = 3, Detail = "鏈長：42/46 cm（可調整）" },
                new DesDetail() { DDID = 11, ProductID = 4, Detail = "純銀材質" },
                new DesDetail() { DDID = 12, ProductID = 4, Detail = "18k金層" },
                new DesDetail() { DDID = 13, ProductID = 4, Detail = "1mm 手工精鑲鋯石" },
                new DesDetail() { DDID = 14, ProductID = 4, Detail = "尺寸：2 / 3" },
                new DesDetail() { DDID = 15, ProductID = 5, Detail = "材質：純銀、1mm手工精鑲鋯石" },
                new DesDetail() { DDID = 16, ProductID = 5, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 17, ProductID = 5, Detail = "尺寸：5 / 6 / 7" },
                new DesDetail() { DDID = 18, ProductID = 6, Detail = "純銀材質" },
                new DesDetail() { DDID = 19, ProductID = 6, Detail = "18k金層" },
                new DesDetail() { DDID = 20, ProductID = 6, Detail = "戒圍：5/6/7" },
                new DesDetail() { DDID = 21, ProductID = 7, Detail = "純銀材質" },
                new DesDetail() { DDID = 22, ProductID = 7, Detail = "18Ｋ金 / 玫瑰金 色" },
                new DesDetail() { DDID = 23, ProductID = 7, Detail = "戒圍：5 / 6 / 7" },
                new DesDetail() { DDID = 24, ProductID = 8, Detail = "純銀材質" },
                new DesDetail() { DDID = 25, ProductID = 8, Detail = "18k金層" },
                new DesDetail() { DDID = 26, ProductID = 8, Detail = "1mm 手工精鑲鋯石" },
                new DesDetail() { DDID = 27, ProductID = 8, Detail = "戒圍：6/7" },
                new DesDetail() { DDID = 28, ProductID = 9, Detail = "純銀材質" },
                new DesDetail() { DDID = 29, ProductID = 9, Detail = "18k金層" },
                new DesDetail() { DDID = 30, ProductID = 9, Detail = "1mm 手工精鑲鋯石" },
                new DesDetail() { DDID = 31, ProductID = 9, Detail = "戒圍：6/7" },
                new DesDetail() { DDID = 32, ProductID = 10, Detail = "純銀材質" },
                new DesDetail() { DDID = 33, ProductID = 10, Detail = "白k金層" },
                new DesDetail() { DDID = 34, ProductID = 10, Detail = "1mm 手工精鑲鋯石" },
                new DesDetail() { DDID = 35, ProductID = 10, Detail = "戒圍：6/7" },
                new DesDetail() { DDID = 36, ProductID = 11, Detail = "純銀材質" },
                new DesDetail() { DDID = 37, ProductID = 11, Detail = "白k金層" },
                new DesDetail() { DDID = 38, ProductID = 11, Detail = "1mm 手工精鑲鋯石" },
                new DesDetail() { DDID = 39, ProductID = 11, Detail = "戒圍：6/7" },
                new DesDetail() { DDID = 40, ProductID = 12, Detail = "純銀材質" },
                new DesDetail() { DDID = 41, ProductID = 12, Detail = "香檳金電鍍" },
                new DesDetail() { DDID = 42, ProductID = 12, Detail = "鏈長：40cm" },
                new DesDetail() { DDID = 43, ProductID = 13, Detail = "純銀材質" },
                new DesDetail() { DDID = 44, ProductID = 12, Detail = "香檳金電鍍" },
                new DesDetail() { DDID = 45, ProductID = 12, Detail = "鏈長：40cm" },
                new DesDetail() { DDID = 46, ProductID = 14, Detail = "純銀材質" },
                new DesDetail() { DDID = 47, ProductID = 14, Detail = "香檳金電鍍" },
                new DesDetail() { DDID = 48, ProductID = 14, Detail = "鏈長：40cm" },
                new DesDetail() { DDID = 49, ProductID = 15, Detail = "材質：純銀" },
                new DesDetail() { DDID = 50, ProductID = 15, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 51, ProductID = 15, Detail = "尺寸：單一尺寸（可調整）" },
                new DesDetail() { DDID = 52, ProductID = 16, Detail = "材質：純銀" },
                new DesDetail() { DDID = 53, ProductID = 16, Detail = "顏色：白k金層" },
                new DesDetail() { DDID = 54, ProductID = 16, Detail = "尺寸：單一尺寸" },
                new DesDetail() { DDID = 55, ProductID = 17, Detail = "材質：純銀" },
                new DesDetail() { DDID = 56, ProductID = 17, Detail = "顏色：18k金層" },
                new DesDetail() { DDID = 57, ProductID = 17, Detail = "鏈長：14/15.5/17 cm（可調整）" },
                new DesDetail() { DDID = 58, ProductID = 18, Detail = "材質：純銀" },
                new DesDetail() { DDID = 59, ProductID = 18, Detail = "顏色：白k金層" },
                new DesDetail() { DDID = 60, ProductID = 18, Detail = "鏈長：14/15.5/17 cm（可調整）" }
            );
            context.Images.AddOrUpdate(
                x => x.ImgID,
                new Image() { ImgID = 1, PDID = "1-1", ImgName = "B19401_900x.jpg" },
                new Image() { ImgID = 2, PDID = "1-1", ImgName = "3_ebcf859e-215d-4b14-8a01-6ad2535e40a2_900x.jpg" },
                new Image() { ImgID = 3, PDID = "1-1", ImgName = "4_970e215a-18c2-4afb-826f-0c5b3835757b_900x.jpg" },
                new Image() { ImgID = 4, PDID = "1-1", ImgName = "f5251328ce40a7a02253945753c430e6_900x.jpg" },
                new Image() { ImgID = 5, PDID = "2-1", ImgName = "E19402G-1_900x.jpg" },
                new Image() { ImgID = 6, PDID = "2-1", ImgName = "G3_a94660c7-92de-46e5-966d-617f55f9d59e_900x.jpg" },
                new Image() { ImgID = 7, PDID = "2-1", ImgName = "E19402_900x.jpg" },
                new Image() { ImgID = 8, PDID = "2-1", ImgName = "G_900x.jpg" },
                new Image() { ImgID = 9, PDID = "2-1", ImgName = "G2_f583a5ec-d1b5-4c7c-aee4-d70ea9c43d85_900x.jpg" },
                new Image() { ImgID = 10, PDID = "2-1", ImgName = "G4_7951994a-a222-4b80-8b9e-e178648ae724_900x.jpg" },
                new Image() { ImgID = 11, PDID = "3-1", ImgName = "N19402G_900x.jpg" },
                new Image() { ImgID = 12, PDID = "3-1", ImgName = "3_3_2e459b5c-083d-4682-9861-2718a9292092_900x.jpg" },
                new Image() { ImgID = 13, PDID = "3-1", ImgName = "3_c4bfb307-ddd3-43b2-b5bf-0bc9eb854216_900x.jpg" },
                new Image() { ImgID = 14, PDID = "3-1", ImgName = "3_0f400335-81ef-4b14-b646-481183164d3a_900x.jpg" },
                new Image() { ImgID = 15, PDID = "3-1", ImgName = "N19401B_5c4f29c5-d0a0-4d72-b6c7-e7688895c60f_900x.jpg" },
                new Image() { ImgID = 16, PDID = "4-1", ImgName = "R19401_900x.jpg" },
                new Image() { ImgID = 17, PDID = "4-1", ImgName = "3_e011466f-942c-4c87-87df-cfaa3f0b17ee_900x.jpg" },
                new Image() { ImgID = 18, PDID = "4-1", ImgName = "1_0fe82ab3-bb99-4711-96c4-b47f2b1d25ac_900x.jpg" },
                new Image() { ImgID = 19, PDID = "4-1", ImgName = "2_f318b4e4-ff07-4ca4-8bd8-d181206cba26_900x.jpg" },
                new Image() { ImgID = 20, PDID = "4-1", ImgName = "R19401-1_900x.jpg" },
                new Image() { ImgID = 21, PDID = "5-1", ImgName = "R19402-2_900x.jpg" },
                new Image() { ImgID = 22, PDID = "5-1", ImgName = "c_2_7563982b-8284-4637-a92b-a3763e0256d3_900x.jpg" },
                new Image() { ImgID = 23, PDID = "5-1", ImgName = "c_bf10070a-2fe0-4aca-8aaa-b4af42889cdf_900x.jpg" },
                new Image() { ImgID = 24, PDID = "5-1", ImgName = "C_3_ef589395-f96a-4215-8b61-841d4fc579cf_900x.jpg" },
                new Image() { ImgID = 25, PDID = "5-1", ImgName = "R19402_900x.jpg" },
                new Image() { ImgID = 26, PDID = "6-1", ImgName = "R19301_900x.jpg" },
                new Image() { ImgID = 27, PDID = "6-1", ImgName = "R_2_254969e1-1c77-4080-97c5-2c01f726250b_900x.jpg" },
                new Image() { ImgID = 28, PDID = "6-1", ImgName = "R19301-1_900x.jpg" },
                new Image() { ImgID = 29, PDID = "6-1", ImgName = "R19301-2_900x.jpg" },
                new Image() { ImgID = 30, PDID = "7-1", ImgName = "Gold_900x.jpg" },
                new Image() { ImgID = 31, PDID = "7-1", ImgName = "RG_900x.jpg" },
                new Image() { ImgID = 32, PDID = "7-4", ImgName = "3-2_900x.jpg" },
                new Image() { ImgID = 33, PDID = "7-4", ImgName = "IG1212_900x.jpg" },
                new Image() { ImgID = 34, PDID = "8-1", ImgName = "R19304G_900x.jpg" },
                new Image() { ImgID = 35, PDID = "8-1", ImgName = "R_LOVE_G_1_900x.jpg" },
                new Image() { ImgID = 36, PDID = "8-1", ImgName = "R_LOVE_G_2_900x.jpg" },
                new Image() { ImgID = 37, PDID = "9-1", ImgName = "R19305G_900x.jpg" },
                new Image() { ImgID = 38, PDID = "9-1", ImgName = "R_BAE_G_900x.jpg" },
                new Image() { ImgID = 39, PDID = "9-1", ImgName = "R_BAE_G_2_900x.jpg" },
                new Image() { ImgID = 40, PDID = "10-1", ImgName = "R19304S_900x.jpg" },
                new Image() { ImgID = 41, PDID = "10-1", ImgName = "R_LOVE_S_1_900x.jpg" },
                new Image() { ImgID = 42, PDID = "10-1", ImgName = "R_LOVE_S_2_900x.jpg" },
                new Image() { ImgID = 43, PDID = "11-1", ImgName = "R19305S_900x.jpg" },
                new Image() { ImgID = 43, PDID = "11-1", ImgName = "R19305S_900x.jpg" },
                new Image() { ImgID = 44, PDID = "11-1", ImgName = "R_BAE_S_1_900x.jpg" },
                new Image() { ImgID = 45, PDID = "11-1", ImgName = "R_BAE_S_2_900x.jpg" },
                new Image() { ImgID = 46, PDID = "12-1", ImgName = "N_d855ee98-d0d1-40e1-a8e4-1977a4c51afc_900x.jpg" },
                new Image() { ImgID = 47, PDID = "12-1", ImgName = "N2_e777e584-9cae-4009-8e62-0d450a21366d_900x.jpg" },
                new Image() { ImgID = 48, PDID = "12-1", ImgName = "N1_32d18e09-7901-4eb4-b5ea-6bf038b7f300_900x.jpg" },
                new Image() { ImgID = 49, PDID = "13-1", ImgName = "N_4401c74d-ffd8-469a-b7fc-1b0796f3ccf8_900x.jpg" },
                new Image() { ImgID = 50, PDID = "13-1", ImgName = "N1_24d28200-fa8e-4de3-b8cd-762f26c6ebbb_900x.jpg" },
                new Image() { ImgID = 51, PDID = "13-1", ImgName = "N2_343b6768-cbd4-4514-a29c-4c806e143901_900x.jpg" },
                new Image() { ImgID = 52, PDID = "14-1", ImgName = "N_665dd2fb-a090-46dc-983f-798a8a74f875_900x.jpg" },
                new Image() { ImgID = 53, PDID = "14-1", ImgName = "N1_c10bc736-4f7c-447a-b8cb-a15bc87091ae_900x.jpg" },
                new Image() { ImgID = 54, PDID = "14-1", ImgName = "N2_a5f65891-1eec-4d28-af49-446b7c646807_900x.jpg" },
                new Image() { ImgID = 55, PDID = "15-1", ImgName = "B19403_600x.jpg" },
                new Image() { ImgID = 56, PDID = "15-1", ImgName = "C_1000x.jpg	" },
                new Image() { ImgID = 57, PDID = "15-1", ImgName = "C_3_1000x.jpg" },
                new Image() { ImgID = 58, PDID = "15-1", ImgName = "C_2_1000x.jpg" },
                new Image() { ImgID = 59, PDID = "15-1", ImgName = "B19403-1_1000x.jpg" },
                new Image() { ImgID = 60, PDID = "16-1", ImgName = "E19403S_600x.jpg" },
                new Image() { ImgID = 61, PDID = "16-1", ImgName = "E19403S-1_1000x.jpg" },
                new Image() { ImgID = 62, PDID = "16-1", ImgName = "S_c13dd082-9ddd-4e3d-95de-1b427f0bc827_1000x.jpg" },
                new Image() { ImgID = 63, PDID = "16-1", ImgName = "S2_b7105dbe-3ff4-4485-971e-fe5209408ec6_1000x.jpg" },
                new Image() { ImgID = 64, PDID = "17-1", ImgName = "B19404_900x.jpg" },
                new Image() { ImgID = 65, PDID = "17-1", ImgName = "a13293119f9023188859b28658db52c5_900x.jpg" },
                new Image() { ImgID = 66, PDID = "17-1", ImgName = "2_fae8f255-1152-4a34-8c7b-54b8f3033a87_900x.jpg" },
                new Image() { ImgID = 67, PDID = "17-1", ImgName = "3_eccab948-1084-4916-9f4c-b1171d0c9683_900x.jpg" },
                new Image() { ImgID = 68, PDID = "18-1", ImgName = "B19402S_900x.jpg" },
                new Image() { ImgID = 69, PDID = "18-1", ImgName = "3_18536ee1-d9ad-490e-9755-ae6b03dab5ab_900x.jpg" },
                new Image() { ImgID = 70, PDID = "18-1", ImgName = "3_3_900x.jpg" },
                new Image() { ImgID = 71, PDID = "18-1", ImgName = "3_2_900x.jpg" }
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
                new OrderDetail() { OrderID = 1, PDID = "4-1", Price = 1700, Quantity = 1 }
                );
        }
    }
}
