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
        private CartModel currentCart;

        public CartController()
        {
            db = new AnviModel();
            currentCart = CartService.GetCurrentCart();
        }
        public ActionResult GetCart()
        {
            return View("ShoppingCart");
        }

        public ActionResult AddToCart(string id)
        {
            //var currentCart = CartService.GetCurrentCart();
            currentCart.AddCartItem(id);
            //if (currentCart.AddCartItem(id))
            //{
            //    currentCart = CartService.GetCurrentCart();
            //    int count = currentCart.Count;
            //    var stocks = new int[count];
            //    for (var i = 0; i < currentCart.Count; i++)
            //    {
            //        foreach (var item in db.ProductDetails)
            //        {
            //            if (item.PDID == currentCart.cartItems[i].PDID)
            //            {
            //                stocks[i] = item.Stock;
            //            }
            //        }
            //    }
            //    ViewBag.Stocks = stocks;
            //}
            //return View("ShoppingCart");  //上方可省略，使用下方導向ActionResult
            return RedirectToAction("ShoppingCart", "Cart");  //導向ActionResult RedirectToAction("ActionName","Controller")，讓重複的程式碼給ShoppingCart()去執行
        }
        public ActionResult ShoppingCart()  //購物車頁面
        {
            if (CartService.GetCurrentCart() != null)
            {
                //var currentCart = CartService.GetCurrentCart();
                var stocks = CartService.getEachProductStocks(db);
                var images = CartService.getEachProductImages(db);
                ViewBag.Stocks = stocks; //因為只是要給JQuery用，等到Jquery寫完再考慮需不需要改用Json就好
                ViewBag.Images = images;
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddQuantity(string pdid)  //PDID指定物品用
        {
            currentCart.AddQuantity(pdid);
            return RedirectToAction("ShoppingCart", "Cart");
        }
        [HttpPost]
        public ActionResult ReduceQuantity(string pdid)  //指定物品用
        {
            currentCart.ReduceQuantity(pdid);
            return RedirectToAction("ShoppingCart", "Cart");
        }
    }
}