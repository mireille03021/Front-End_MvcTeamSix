using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ANVI_Mvc.ViewModels
{
    [Serializable]
    public class CartItemViewModel
    {
        //public int? CategoryID { get; set; }
        public int ProductID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string PDID { get; set; }
        //public int Stock { get; set; }
        public int ColorID { get; set; }
        public string ColorName { get; set; }
        //public int SizeID { get; set; }
        //public string SizeTitle { get; set; }
        public string SizeContext { get; set; }
        public decimal Amount => this.UnitPrice * this.Quantity;
    }
}