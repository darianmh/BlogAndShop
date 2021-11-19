using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    public class BlogListViewModel
    {
        public List<PostModel> Posts { get; set; }
        public ListPaginationModel ListPaginationModel { get; set; }
    }
}
