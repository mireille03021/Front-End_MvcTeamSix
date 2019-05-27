using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ANVI_Mvc.ViewModels;

namespace ANVI_Mvc.Models
{
    public class CartModel
    {
        public List<CartItemViewModel> CartItems;

        //建構值，初始化
        private List<CartItemViewModel> cartItems;

        public CartModel()
        {
            this.CartItems = new List<CartItemViewModel>();
        }

        public int Count
        {
            get
            {
                if (this.cartItems == null)
                {
                    return 0;
                }
                return this.cartItems.Count;
            }
        }

        //取得商品總價
        public decimal TotalAmount
        {
            get
            {
                decimal totalAmount = 0;
                foreach (var item in CartItems)
                {
                    totalAmount += item.Amount;
                }

                return totalAmount;
            }
        }

        public bool AddCartItem(string PDID)
        {
            var findItem = new CartItemViewModel();
            //搜尋加入購物車的產品
            if (cartItems != null)
            {
                findItem = this.cartItems
                                .Where(item => item.PDID == PDID)
                                .Select(item => item).FirstOrDefault();
            }
            //判斷是否有相同產品存在購物車中
            if (findItem != default(ViewModels.CartItemViewModel))
            {
                using (AnviModel db = new AnviModel())
                {
                    var cartItem = (from p in db.Products
                                    join pd in db.ProductDetails on p.ProductID equals pd.ProductID
                                    join s in db.Sizes on pd.SizeID equals s.SizeID
                                    join c in db.Colors on pd.ColorID equals c.ColorID
                                    join i in db.Images on pd.PDID equals i.PDID
                                    join cat in db.Categories on p.CategoryID equals cat.CategoryID
                                    where pd.PDID == PDID
                                    select new CartItemViewModel()
                                    {
                                        CategoryName = cat.CategoryName,
                                        //ProductID = p.ProductID,
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
                                    }).FirstOrDefault();
                    if (cartItem != default(ViewModels.CartItemViewModel))
                    {
                        this.AddCartItem(cartItem);
                    }
                }
            }
            else
            {
                findItem.Quantity += 1;
            }
            return true;
        }
        //新增一筆CartItem
        private bool AddCartItem(CartItemViewModel cartItem)
        {
            var item = new CartItemViewModel()
            {
                PDID = cartItem.PDID,
                ProductName = cartItem.ProductName,
                UnitPrice = cartItem.UnitPrice,
                Quantity = 1,
                CategoryName = cartItem.CategoryName,
                ColorName = cartItem.ColorName,
                SizeContext = cartItem.SizeContext,
                ImageName = cartItem.ImageName
            };
            if (cartItems == null)
            {
                cartItems = new List<CartItemViewModel>(){item};
            }
            else
            {
                cartItems.Add(item);
            }
            return true;
        }
    }
}