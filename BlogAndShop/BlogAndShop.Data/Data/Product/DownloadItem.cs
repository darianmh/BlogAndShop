using BlogAndShop.Data.Data.Common;

namespace BlogAndShop.Data.Data.Product
{
    public class DownloadItem : BaseEntity
    {
        public string DownloadPath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string BannerImage { get; set; }
    }
}