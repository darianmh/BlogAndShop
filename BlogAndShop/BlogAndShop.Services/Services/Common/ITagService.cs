using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Common
{
    public interface ITagService : IMainService<Tag>
    {
        /// <summary>
        /// پیدا کردن تگ ها مربوط به پست
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<List<Tag>> GetPostTags(int postId);
    }
}
