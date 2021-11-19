using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
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
    }
}
