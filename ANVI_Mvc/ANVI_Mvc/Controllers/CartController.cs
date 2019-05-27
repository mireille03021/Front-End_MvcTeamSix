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
            return View("ShoppingCart");
        }

        public ActionResult AddToCart(string id)
        {
            var currentCart = CartService.GetCurrentCart();
            currentCart.AddCartItem(id);
            if (currentCart.AddCartItem(id))
            {
                currentCart = CartService.GetCurrentCart();
                int count = currentCart.Count;
                var stocks = new int[count];
                for (var i = 0; i < currentCart.Count; i++)
                {
                    foreach (var item in db.ProductDetails)
                    {
                        if (item.PDID == currentCart.cartItems[i].PDID)
                        {
                            stocks[i] = item.Stock;
                        }
                    }
                }
                ViewBag.Stocks = stocks;
            }





            return View("ShoppingCart");

        }
        public ActionResult ShoppingCart()  //購物車頁面
        {
            return View();
        }
    }
}