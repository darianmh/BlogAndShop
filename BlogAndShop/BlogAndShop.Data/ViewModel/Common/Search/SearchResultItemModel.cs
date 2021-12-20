using BlogAndShop.Data.ViewModel.Utilities.SiteMap;

namespace BlogAndShop.Data.ViewModel.Common.Search
{
    public class SearchResultItemModel
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public SiteMapType SearchResultType { get; set; }
        public int Id { get; set; }
    }
}