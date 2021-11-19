using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PostInfo
{
    public interface IPost_PostGroupService : IMainService<Post_PostGroup>
    {
        /// <summary>
        /// return post ids fro selected post group
        /// </summary>
        /// <param name="categoryId">group id</param>
        /// <returns></returns>
        Task<List<int>> GetPostsWithGroup(int categoryId);
    }
}
