using System.Collections.Generic;
using BlogAndShop.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    /// نمایش محصولات موجود در دسته بندی
    /// </summary>
    public class ProductListViewModel
    {
        public ProductGroupModel CurrentGroup { get; set; }
        public BrandModel Brand { get; set; }
        public List<ProductMiniModel> Products { get; set; }
        public ListPaginationModel ListPaginationModel { get; set; }
        public string Keywords { get; set; }
        public string HeaderText { get; set; }
        public int TotalCount { get; set; }
    }
}