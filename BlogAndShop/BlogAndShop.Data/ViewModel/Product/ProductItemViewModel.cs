using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Forum;

namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    /// مدل نمایش محصول در صفحه item
    /// </summary>
    public class ProductItemViewModel
    {
        public ProductModel ProductModel { get; set; }
        public List<MediaModel> Images { get; set; }
        public List<ProductMiniModel> SuggestedProducts { get; set; }
        public ProductGroupModel Group { get; set; }
        public List<ForumTitleModel> ForumTitles { get; set; }
        public ShoppingModel ShoppingModel { get; set; }
    }
}
