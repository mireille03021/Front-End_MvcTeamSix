using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ANVI_Mvc.Models;
using ANVI_Mvc.ViewModels;
using Microsoft.SqlServer.Server;

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

                return (CartModel) HttpContext.Current.Session["Cart"];
            }
            else
            {
                throw new InvalidOperationException("System.web.HttpContext.Current為空，請檢察");
            }
        }
    }
}