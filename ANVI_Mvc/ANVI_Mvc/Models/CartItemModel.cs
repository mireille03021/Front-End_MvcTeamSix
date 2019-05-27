using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ANVI_Mvc.Models
{
    [Serializable]
    public class CartItemModel
    {
        public string PDID { get; set; }
        public string ProductName { get; set; }
        public string ColorName { get; set; }
        public string SizeContext { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount => this.UnitPrice * this.Quantity;
    }
}