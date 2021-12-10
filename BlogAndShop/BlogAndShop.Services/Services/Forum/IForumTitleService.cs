using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Services.Services.Main;

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
        /// <returns></returns>
        Task CreateProductForum(Data.Data.Product.Product item);
    }
}
