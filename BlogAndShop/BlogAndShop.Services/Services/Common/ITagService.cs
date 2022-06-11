using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.PostInfo;


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

        /// <summary>
        /// تگ را را بر اساس نامش می یابد
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        Task<Tag> GetTagByName(string tagName);
    }
}
