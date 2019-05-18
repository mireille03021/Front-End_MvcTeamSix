using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ANVI_Mvc.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        
        public ActionResult Index()   //主頁面
        {
            return View();
        }
        public ActionResult ProductsPage() //商品頁面
        {
            return View();
        }
        public ActionResult ProductDetailPage()  //單一商品頁面
        {
            return View();
        }
        public ActionResult Cart()  //購物車頁面
        {
            return View();
        }
        public ActionResult Order_Customer()  //下單-客戶頁面(填入收件人)
        {
            return View();
        }
        public ActionResult Order_Pay()  //下單-付費頁面
        {
            return View();
        }
        public ActionResult Order_Check()  //下單-確認頁面
        {
            return View();
        }
    }
}