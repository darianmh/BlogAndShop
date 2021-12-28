using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PostInfo
{
    public interface IPostService : IMainService<Post>
    {
        /// <summary>
        /// دریافت لیست پست ها بر اساس گروه
        /// </summary>
        /// <returns></returns>
        Task<DbModelInfo<Post>> GetPostsByGroup(int? categoryId, int page, int count);

        /// <summary>
        /// دریافت پست های برتر از نظر کامنت از کش یا دیتابیس
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<List<TopPostModel>> GetTopPosts(int count);
        /// <summary>
        /// مدل نهایی را برای نمایش بلاگ بر میگرداند
        /// شامل تگ ها، کامنت ها و پست های مشابه
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<PostModel> GetPostModel(int postId);

        /// <summary>
        /// سایت مپ را از تولید می کند از تمام موارد
        /// </summary>
        /// <returns></returns>
        Task<List<SiteMapItemModel>> GetSiteMap();
        /// <summary>
        /// جستجو در بین موارد موجود
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<List<SearchResultItemModel>> Search(string key);
        /// <summary>
        /// دریافت 5 پست آخر
        /// </summary>
        /// <returns></returns>
        Task<List<PostModel>> GetRecentPosts();
    }
}
