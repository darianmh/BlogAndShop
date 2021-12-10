using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public interface IProductForumGroupService : IMainService<Data.Data.Forum.Product_ForumInfo>
    {
        /// <summary>
        /// یافتن بر اساس ومحصول و فروم
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="forumId"></param>
        /// <returns></returns>
        Task<Product_ForumInfo> Find(int productId, int forumId);

        /// <summary>
        /// دریافت انجمن های مربوط به محصول
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<List<Product_ForumInfo>> GetProductForums(int productId);
        /// <summary>
        /// ایجاد رابطه جدید
        /// </summary>
        /// <param name="forum"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        Task Create(ForumTitle forum, int @group);
    }
}