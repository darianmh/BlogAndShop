using System.Collections.Generic;
using BlogAndShop.Data.ViewModel.PostInfo;

namespace BlogAndShop.Data.ViewModel.Product
{
    public class HomeSuggestedProductsPostsModel
    {
        public List<ProductModel> Newest { get; set; }
        public List<ProductModel> Popular { get; set; }
        public List<PostModel> RecentPosts { get; set; }
    }
}