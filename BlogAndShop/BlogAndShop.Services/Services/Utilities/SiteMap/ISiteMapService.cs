using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;

namespace BlogAndShop.Services.Services.Utilities.SiteMap
{
    public interface ISiteMapService
    {
        /// <summary>
        /// سایت مپ اصلی که آدرس سایت مپ های بلاگ و محصولات راد دارد
        /// </summary>
        /// <returns></returns>
        List<SiteMapItemModel> GetMainSiteMap();
        /// <summary>
        /// سایت مپ محصولات یا بلاگ را برمیگرداند
        /// </summary>
        /// <param name="category">Blog or Shop or Forum</param>
        /// <returns></returns>
        Task<List<SiteMapItemModel>> GetCategorySiteMap(SiteMapType category);
        /// <summary>
        /// تبدیل لیست به سایت مپ
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        string CreateSIteMap(List<SiteMapItemModel> list);
    }
}