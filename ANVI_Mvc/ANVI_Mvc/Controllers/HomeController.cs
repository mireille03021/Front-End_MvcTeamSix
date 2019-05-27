﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using ANVI_Mvc.Models;
using ANVI_Mvc.Services;
using ANVI_Mvc.ViewModels;

namespace ANVI_Mvc.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        protected AnviModel db;

        public HomeController()
        {
            db = new AnviModel();
        }
        public ActionResult Index()   //主頁面
        {
            return View();
        }
        public ActionResult ProductsPage() //商品頁面
        {
            List<Product> products = db.Products.ToList();

            ViewBag.products = products;

            var list = from cat in db.Categories
                join p in db.Products on cat.CategoryID equals p.CategoryID
                join pd in db.ProductDetails on p.ProductID equals pd.ProductID
                select new ProductPageViewModel
                {
                    ProductID = p.ProductID,
                    PDID = pd.PDID,
                    ColorID = pd.ColorID,
                    CategoryName = cat.CategoryName
                };
            ViewBag.productDetails = list.ToList();
            ViewBag.Images = db.Images.ToList();
            ViewBag.Colors = db.Colors.ToList();

            return View();
        }
        [HttpGet]
        public ActionResult ProductDetailPage(int id)  //單一商品頁面 Get
        {
            ProductViewModelService service = new ProductViewModelService(db, id);
            var sPVM = service.PVM;
            ViewData.Model = sPVM;
            ViewBag.ColorList = db.Colors.ToList();
            ViewBag.JsonPVM = Newtonsoft.Json.JsonConvert.SerializeObject(sPVM.ProductDetailViewModels);

            ViewData["ColorName"] = sPVM.ProductDetailViewModels[0].ColorName;
            return View();
        }
        [HttpPost]
        public ActionResult ProductDetailPage(int id, string DropDownList_Color)  //單一商品頁面Post
        {
            ProductViewModelService service = new ProductViewModelService(db, id);
            var sPVM = service.PVM;
            ViewData.Model = sPVM;
            ViewBag.ColorList = db.Colors.ToList();
            ViewBag.JsonPVM = Newtonsoft.Json.JsonConvert.SerializeObject(sPVM.ProductDetailViewModels);

            ViewData["ColorName"] = DropDownList_Color;
            return View();
        }
        //測試購物車用
        public ActionResult GetCart()
        {
            var cart = CartService.GetCurrentCart();
            if (cart.CartItems.Count == 0) //如果沒有在Session裡暫存數量
            {
                cart.CartItems.Add(new CartItemModel()
                {
                    PDID = "1-1"  //待補充
                });
            }

            return View();
        }
        public ActionResult ShoppingCart()  //購物車頁面
        {
            //暫時傳入一筆資料，之後改用List存選到的物品資訊
            IQueryable<CartPageViewModel> productDetail =
                from p in db.Products
                join pd in db.ProductDetails on p.ProductID equals pd.ProductID
                join s in db.Sizes on pd.SizeID equals s.SizeID
                join c in db.Colors on pd.ColorID equals c.ColorID
                join i in db.Images on pd.PDID equals  i.PDID
                where pd.PDID == "1-1"            //只有一筆資料，所以只要改這個PDID就好
                select new CartPageViewModel()
                {
                    CategoryID = p.CategoryID,
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    PDID = pd.PDID,
                    Stock = pd.Stock,
                    ColorID = c.ColorID,
                    ColorName = c.ColorName,
                    SizeID = s.SizeID,
                    SizeTitle = s.SizeTitle,
                    SizeContext = s.SizeContext,
                    ImageName = i.ImgName
                };
            ViewBag.Category = db.Categories.ToList();
            ViewData.Model = productDetail.First();
            return View();
        }

       [HttpGet]
        public ActionResult Order_Customer()  //下單-客戶頁面(填入收件人)!沒有HEADER跟FOOTER
        {
            //OrderViewModelService service = new OrderViewModelService(db, id);
            //var sOCVM = service.OCVM;
            //ViewData.Model = sOCVM;
            //ViewData["last_name"] = sOCVM.CustomerName;
            //ViewData["city"] = sOCVM.City;
            //ViewData["address"] = sOCVM.Address;
            //ViewData["phone"] = sOCVM.Phone;

            return View();
        }

        [HttpPost, ActionName("Order_Customer")]
        public ActionResult Order_Customer_post()
        {

            ViewData["last_name"] = Request.Form["checkout[shipping_address][last_name]"];
            ViewData["first_name"] = Request.Form["checkout[shipping_address][first_name]"];
            ViewData["city"] = Request.Form["checkout[shipping_address][city]"];
            ViewData["zip"] = Request.Form["checkout[shipping_address][zip]"];
            ViewData["address"] = Request.Form["checkout[shipping_address][address]"];
            ViewData["phone"] = Request.Form["checkout[shipping_address][phone]"];

            return View("Order_Customer_post");
        }

        public ActionResult Order_Ship()  //下單-運送頁面!沒有HEADER跟FOOTER
        {
            return View();
        }
        public ActionResult Order_Pay()  //下單-付費頁面!沒有HEADER跟FOOTER
        {
            return View();
        }
        public ActionResult Order_Check()  //下單-確認頁面!沒有HEADER跟FOOTER
        {
            return View();
        }

        public ActionResult AccountPage()   //主頁面
        {
            return View();
        }
    }
}