using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ANVI_Mvc.Models;

namespace ANVI_Mvc.ViewModels
{
    public class ProductDetailViewModel
    {
        public ProductDetail PD { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
}