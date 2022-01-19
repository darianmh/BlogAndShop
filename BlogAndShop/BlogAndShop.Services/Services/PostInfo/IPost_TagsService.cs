using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
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

        /// <summary>
        /// برگرداندن مدل تگ های مربوط به پست
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<List<Post_TagsModel>> GetPostTagsModel(int postId);
        /// <summary>
        /// حذف تگ های قبلی و ذخیره تگ های جدید
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="selectedTags"></param>
        /// <returns></returns>
        Task SetPostTags(int postId, List<int> selectedTags);

        /// <summary>
        /// return post ids fro selected post tag
        /// </summary>
        /// <param name="tagId">tag id</param>
        /// <returns></returns>
        Task<List<int>> GetPostsWithTag(int tagId);
    }
}
