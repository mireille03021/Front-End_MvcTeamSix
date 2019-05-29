using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ANVI_Mvc.Models
{
    public class CartModel
    {
        public List<CartItemModel> CartItems;

        //建構值，初始化
        public CartModel()
        {
            this.CartItems = new List<CartItemModel>();
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
    }
}