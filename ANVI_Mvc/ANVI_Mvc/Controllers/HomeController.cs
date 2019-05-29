using System;
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
        //---------------------單一商品頁面-----------------------
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
        [MultiButton("ChangeColor")]
        [HttpPost]
        public ActionResult ChangeColor(int id, string DropDownList_Color)  //單一商品頁面Post
        {
            ProductViewModelService service = new ProductViewModelService(db, id);
            var sPVM = service.PVM;
            ViewData.Model = sPVM;
            ViewBag.ColorList = db.Colors.ToList();
            ViewBag.JsonPVM = Newtonsoft.Json.JsonConvert.SerializeObject(sPVM.ProductDetailViewModels);

            ViewData["ColorName"] = DropDownList_Color;
            return View("ProductDetailPage");
        }
        [MultiButton("BuyItNow")]
        [HttpPost]
        public ActionResult ProductDetailPage()  //單一商品頁面 Get
        {
            return View("Order_Customer");
        }
        //-----------------------------------------------------------------
        //----------------------------下單-----------------------------
        [HttpGet]
        public ActionResult Order_Customer()  //下單-客戶頁面(填入收件人)!沒有HEADER跟FOOTER
        {
            if (Session["Order_Session"] != null)
            {
                var OCVM = (OrderCustomerViewModel)Session["Order_Session"];
                ViewData["CustomerName"] = OCVM.CustomerName;
                ViewData["City"] = OCVM.City;
                ViewData["ZipCode"] = OCVM.ZipCode;
                ViewData["Address"] = OCVM.Address;
                ViewData["Phone"] = OCVM.Phone;
                ViewData["Email"] = OCVM.Email;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Order_Customer(OrderCustomerViewModel OCVM)
        {
            Session["Order_Session"] = OCVM;
            ViewData["CustomerName"] = OCVM.CustomerName;
            ViewData["City"] = OCVM.City;
            ViewData["ZipCode"] = OCVM.ZipCode;
            ViewData["Address"] = OCVM.Address;
            ViewData["Phone"] = OCVM.Phone;
            ViewData["Email"] = OCVM.Email;

            return View("Order_Ship");
        }
        [HttpGet]
        public ActionResult Order_Ship()  //下單-運送頁面!沒有HEADER跟FOOTER
        {
            var OCVM = (OrderCustomerViewModel)Session["Order_Session"];
            ViewData["Email"] = OCVM.Email;
            ViewData["Address"] = OCVM.Address;
            ViewData.Model = OCVM;
            return View();
        }

        [HttpPost]
        public ActionResult Order_Ship(string Nothing)  //下單-運送頁面!沒有HEADER跟FOOTER
        {
            var OCVM = (OrderCustomerViewModel)Session["Order_Session"];
            ViewData["CustomerName"] = OCVM.CustomerName;
            ViewData["City"] = OCVM.City;
            ViewData["ZipCode"] = OCVM.ZipCode;
            ViewData["Address"] = OCVM.Address;
            ViewData["Phone"] = OCVM.Phone;
            ViewData["Email"] = OCVM.Email;
            ViewData.Model = OCVM;

            return View("Order_Pay");
        }
        [HttpGet]
        public ActionResult Order_Pay()  //下單-付費頁面!沒有HEADER跟FOOTER
        {
            var OCVM = (OrderCustomerViewModel)Session["Order_Session"];
            ViewData["Email"] = OCVM.Email;
            ViewData["Address"] = OCVM.Address;
            ViewData.Model = OCVM;
            return View();
        }

        [HttpPost]
        public ActionResult Order_Pay(string Nothing)  //下單-付費頁面!沒有HEADER跟FOOTER
        {
            var OCVM = (OrderCustomerViewModel)Session["Order_Session"];
            ViewData["CustomerName"] = OCVM.CustomerName;
            ViewData["City"] = OCVM.City;
            ViewData["ZipCode"] = OCVM.ZipCode;
            ViewData["Address"] = OCVM.Address;
            ViewData["Phone"] = OCVM.Phone;
            ViewData["Email"] = OCVM.Email;
            return View("Order_Check");
        }
        [HttpGet]
        public ActionResult Order_Check()  //下單-確認頁面!沒有HEADER跟FOOTER
        {
            var OCVM = (OrderCustomerViewModel)Session["Order_Session"];
            ViewData["CustomerName"] = OCVM.CustomerName;
            ViewData["City"] = OCVM.City;
            ViewData["ZipCode"] = OCVM.ZipCode;
            ViewData["Address"] = OCVM.Address;
            ViewData["Email"] = OCVM.Email;
            return View();
        }
        [HttpPost]
        public ActionResult Order_Check(string Nothing)  //下單-確認頁面!沒有HEADER跟FOOTER
        {
            var OCVM = (OrderCustomerViewModel)Session["Order_Session"];
            ViewData["CustomerName"] = OCVM.CustomerName;
            ViewData["City"] = OCVM.City;
            ViewData["ZipCode"] = OCVM.ZipCode;
            ViewData["Address"] = OCVM.Address;
            ViewData["Phone"] = OCVM.Phone;
            ViewData["Email"] = OCVM.Email;
            return View();
        }

        public ActionResult AccountPage()   //主頁面
        {
            return View();
        }
    }
}