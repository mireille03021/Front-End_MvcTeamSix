using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ANVI_Mvc.Models;
using ANVI_Mvc.ViewModels;

namespace ANVI_Mvc.Services
{
    public class ProductViewModelService
    {
        public ProductViewModel PVM { get; set; }
        private AnviModel DB { get; set; }
        private int PID { get; set; }
        public ProductViewModelService(AnviModel db, int pid)
        {
            DB = db;
            PID = pid;
            PVM = new ProductViewModel()
            {
                CategoryName = GetCategoryName(),
                Product = GetProduct(),
                ProductDetailViewModels = GetProductDetailViewModels(),
                Images = GetImages(),
                DesSubTitles = GetDeSubtitles(),
                DesDetails = GetDetails()
            };
        }

        
        private List<DesDetail> GetDetails()
        {
            return DB.DesDetails.Where(x=>x.ProductID == PID).ToList();
        }

        private List<DesSubTitle> GetDeSubtitles()
        {
            return DB.DesSubTitles.Where(x => x.ProductID == PID).ToList();
        }
        private List<Image> GetImages()
        {
            return DB.Images.Where(x => x.PDID.Substring(0, 1) == PID.ToString()).ToList();
        }
        public List<ProductDetailViewModel> GetProductDetailViewModels()
        {
            var PDVMList = from pd in DB.ProductDetails
                join c in DB.Colors on pd.ColorID equals c.ColorID
                join s in DB.Sizes on pd.SizeID equals s.SizeID
                where pd.ProductID == PID
                select new ProductDetailViewModel
                {
                    ProductID = pd.ProductID,
                    Stock = pd.Stock,
                    ColorID = c.ColorID,
                    ColorName = c.ColorName,
                    SizeID = s.SizeID,
                    SizeTitle = s.SizeTitle,
                    SizeContext = s.SizeContext
                };
            return PDVMList.ToList();
        }
        private Product GetProduct()
        {
            return DB.Products.First(x => x.ProductID == PID);
        }

        public string GetCategoryName()
        {
            var catID = GetProduct().CategoryID;
            return DB.Categories.First(x => x.CategoryID == catID).CategoryName;
        }
    }
}