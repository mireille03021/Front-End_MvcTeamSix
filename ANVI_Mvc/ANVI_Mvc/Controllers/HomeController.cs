using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            ViewData["ColorName"] = sPVM.ProductDetailViewModels[0].Color.ColorName;
            //ViewBag.JsonPVM = Newtonsoft.Json.JsonConvert.SerializeObject(sPVM);
            return View();
        }
        [HttpPost]
        public ActionResult ProductDetailPage(int id, string DropDownList_Color)  //單一商品頁面Post
        {
            ProductViewModelService service = new ProductViewModelService(db, id);
            var sPVM = service.PVM;
            ViewData.Model = sPVM;
            ViewData["ColorName"] = DropDownList_Color;
            return View();
        }
        public ActionResult Cart()  //購物車頁面
        {
            return View();
        }

        public ActionResult Order_Customer()  //下單-客戶頁面(填入收件人)!沒有HEADER跟FOOTER
        {
            return View();
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
    }
}