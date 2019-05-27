using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ANVI_Mvc.Models;
using ANVI_Mvc.Services;
using ANVI_Mvc.ViewModels;
using WebGrease.Css.Extensions;

namespace ANVI_Mvc.Controllers
{
    public class CartController : Controller
    {
        private AnviModel db;

        public CartController()
        {
            db = new AnviModel();
        }
        public ActionResult GetCart()
        {
            return PartialView("ShoppingCart");
        }

        public ActionResult AddToCart(string id)
        {
            var currentCart = CartService.GetCurrentCart();
            currentCart.AddCartItem(id);
            int count = currentCart.CartItems.Count;

            var stocks = new int[(int)count];
            for (var i = 0; i < currentCart.CartItems.Count; i++)
            {
                foreach (var item in db.ProductDetails)
                {
                    if (item.PDID == currentCart.CartItems[i].PDID)
                    {
                        stocks[i] = item.Stock;
                    }
                }
            }

            ViewBag.Stocks = stocks.ToList();
            return PartialView("ShoppingCart");

        }
        public ActionResult ShoppingCart()  //購物車頁面
        {
            //暫時傳入一筆資料，之後改用List存選到的物品資訊
            IQueryable<CartItemViewModel> productDetail =
                from p in db.Products
                join pd in db.ProductDetails on p.ProductID equals pd.ProductID
                join s in db.Sizes on pd.SizeID equals s.SizeID
                join c in db.Colors on pd.ColorID equals c.ColorID
                join i in db.Images on pd.PDID equals i.PDID
                join cat in db.Categories on p.CategoryID equals cat.CategoryID
                where pd.PDID == "1-1"            //只有一筆資料，所以只要改這個PDID就好
                select new CartItemViewModel()
                {
                    //CategoryID = p.CategoryID,
                    //ProductID = p.ProductID,
                    CategoryName = cat.CategoryName,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    PDID = pd.PDID,
                    //Stock = pd.Stock,
                    //ColorID = c.ColorID,
                    ColorName = c.ColorName,
                    //SizeID = s.SizeID,
                    //SizeTitle = s.SizeTitle,
                    SizeContext = s.SizeContext,
                    ImageName = i.ImgName
                };
            ViewData.Model = productDetail.First();
            return View();
        }
    }
}