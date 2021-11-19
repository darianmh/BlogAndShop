using System.Collections.Generic;

namespace BlogAndShop.Data.ViewModel.Product
{
    public class ProductCategoryViewModel
    {
        public ProductGroupModel CurrentGroup { get; set; }
        public List<ProductCategoryViewModel> SubCategories { get; set; }
    }
}