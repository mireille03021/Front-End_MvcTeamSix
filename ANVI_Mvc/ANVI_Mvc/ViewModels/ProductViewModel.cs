using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ANVI_Mvc.Models;

namespace ANVI_Mvc.ViewModels
{
    public class ProductViewModel
    {
        public string CategoryName { get; set; }
        public Product Product { get; set; }
        public List<ProductDetailViewModel> ProductDetailViewModels { get; set; }
        public List<Image> Images { get; set; }
        public List<DesSubTitle> DesSubTitles { get; set; }
        public List<DesDetail> DesDetails { get; set; }
    }
}