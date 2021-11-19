using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Product;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    public class BlogSideBarModel
    {
        public List<LinkGroupHeaderViewModel> Categories { get; set; }
        public List<TopPostModel> TopPosts { get; set; }
        public string AdvertizeHtml { get; set; }
    }
}
