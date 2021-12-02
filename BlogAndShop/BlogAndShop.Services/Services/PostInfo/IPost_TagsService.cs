using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PostInfo
{
    public interface IPost_TagsService : IMainService<Post_Tags>
    {
        /// <summary>
        /// برگرداندن تگ های مربوط به پست
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<List<Post_Tags>> GetPostTags(int postId);
    }
}
