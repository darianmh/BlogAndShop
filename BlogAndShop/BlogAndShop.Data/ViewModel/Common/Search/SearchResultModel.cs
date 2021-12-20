using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.ViewModel.Common.Search
{
    public class SearchResultModel
    {
        public string Key { get; set; }
        public int BlogCount { get; set; }
        public int ShopCount { get; set; }
        public int ForumCount { get; set; }
        public List<SearchResultItemModel> Items { get; set; }
    }
}
