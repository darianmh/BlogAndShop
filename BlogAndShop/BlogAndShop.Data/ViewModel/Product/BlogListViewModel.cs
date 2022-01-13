using System.Collections.Generic;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PostInfo;

namespace BlogAndShop.Data.ViewModel.Product
{
    public class BookListViewModel
    {
        public List<DownloadItemViewModel> Posts { get; set; }
        public ListPaginationModel ListPaginationModel { get; set; }
    }
}
