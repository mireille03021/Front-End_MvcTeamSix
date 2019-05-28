using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ANVI_Mvc.Models;
using ANVI_Mvc.ViewModels;
using Microsoft.SqlServer.Server;
using WebGrease.Css.Ast.Selectors;

namespace ANVI_Mvc.Services
{
    public static class CartService
    {
        //儲存所有商品
        [WebMethod(EnableSession = true)] //啟用Session
        public static CartModel GetCurrentCart()
        {
            //確認HttpContext.Current是否為空
            if (HttpContext.Current != null)
            {
                //如果Session["Cart"]不存在，就建一個空的Cart物件
                if (HttpContext.Current.Session["Cart"] == null)
                {
                    var order = new CartModel();
                    HttpContext.Current.Session["Cart"] = order;
                }

                return (CartModel)HttpContext.Current.Session["Cart"];
            }
            else
            {
                throw new InvalidOperationException("System.web.HttpContext.Current為空，請檢察");
            }
        }

        public static int[] getEachProductStocks(AnviModel db)  //取得購物車中物品每個庫存，給Jquery防呆用
        {
            var currentCart = GetCurrentCart();
            int count = currentCart.Count;
            var stocks = new int[count];
            for (var i = 0; i < currentCart.Count; i++)
            {
                foreach (var item in db.ProductDetails)
                {
                    if (item.PDID == currentCart.cartItems[i].PDID)
                    {
                        stocks[i] = item.Stock;
                        break;
                    }
                }
            }

            return stocks;
        }

        internal static string[] getEachProductImages(AnviModel db)
        {
            var currentCart = GetCurrentCart();
            int count = currentCart.Count;
            var images = new string[count];
            for (var i = 0; i < currentCart.Count; i++)
            {
                var cartItem = currentCart.cartItems[i];
                //如果這個物品本身就有圖片，就拿自己的第一張圖
                if (db.Images.Any(x => x.PDID == cartItem.PDID))
                {
                    images[i] = db.Images.First(x => x.PDID == cartItem.PDID).ImgName;
                }
                //如果這個物品本身沒有圖片
                else
                {
                    var sameProductImage =      //找出此物品所屬的產品所有關聯的圖片
                        from p in db.Products
                        join pd in db.ProductDetails on p.ProductID equals pd.ProductID
                        join img in db.Images on pd.PDID equals img.PDID
                        where p.ProductID == cartItem.ProductID && pd.ColorID == cartItem.ColorID
                        select new
                        {
                            ImgName = img.ImgName
                        };
                    images[i] = sameProductImage.First().ImgName;
                }
            }

            return images;
        }
    }
}