using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ANVI_Mvc.Models;

namespace ANVI_Mvc.ViewModels
{
    public class ProductDetailViewModel
    {
        public Category Category { get; set; }
        public Product Product { get; set; }
        public List<ProductDestail> ProductDestails { get; set; }
        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Image> Images { get; set; }
    }
}