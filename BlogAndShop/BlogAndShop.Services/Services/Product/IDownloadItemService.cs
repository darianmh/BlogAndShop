using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.Product
{
    public interface IDownloadItemService : IMainService<Data.Data.Product.DownloadItem>
    {
        /// <summary>
        /// مدل نهایی برای نمایش را برمیگرداند
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<DownloadItemViewModel> GetItemModel(int postId);
        /// <summary>
        /// لیست برای نمایش در صفحه را بر میگرداند
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<BookListViewModel> GetItemsModel(int page, int count);
        /// <summary>
        /// دریافت سایت مپ
        /// </summary>
        /// <returns></returns>
        Task<List<SiteMapItemModel>> GetSiteMap();

        /// <summary>
        /// جستجو در بین موارد موجود
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<List<SearchResultItemModel>> Search(string key);
    }
}