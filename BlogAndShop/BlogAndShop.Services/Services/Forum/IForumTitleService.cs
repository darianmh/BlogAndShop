using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using CommonConfiguration.Core.Data.Classes;


namespace BlogAndShop.Services.Services.Forum
{
    public interface IForumTitleService : IMainService<ForumTitle>
    {
        /// <summary>
        /// دریافت مدل فروم های لینک شده به محصول
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<List<ForumTitleModel>> GetProductForumsModel(int productId);

        /// <summary>
        /// ایجاد یک انجمن برای محصول
        /// </summary>
        /// <param name="item"></param>
        /// <param name="forumGroupService"></param>
        /// <returns></returns>
        Task CreateProductForum(Data.Data.Product.Product item, IForumGroupService forumGroupService);

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
        /// دریافت لیست انجمن ها بر اساس گروه
        /// </summary>
        Task<DbModelInfo<ForumTitle>> GetForumByGroup(int? forumGroupId, int count, int page, IForumGroupService forumGroupService);

        Task<ForumMiniModel> GetForumMiniModel(ForumTitle forumTitle);
    }
}
