using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ANVI_Mvc.Controllers
{
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
    }
}