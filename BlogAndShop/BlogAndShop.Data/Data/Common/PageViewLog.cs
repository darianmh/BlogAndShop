using CommonConfiguration.Core.Data.Data.Common;

namespace BlogAndShop.Data.Data.Common
{
    /// <summary>
    /// لاگ آیپی و لینک ورودی برای بازدید هر صفحه
    /// </summary>
    public class PageViewLog : BaseEntity
    {
        public string IpV4 { get; set; }
        public string RefererUrl { get; set; }
        public int? UserId { get; set; }
        public string CurrentPage { get; set; }
    }
}