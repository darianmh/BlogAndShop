using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PostInfo
{
    public interface IPostCommentService : IMainService<PostComment>
    {
        /// <summary>
        /// کامنت های یک پست را بر میگرداند
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<List<PostComment>> GetPostComments(int postId);
        /// <summary>
        /// مدل نهایی برای نمایش در بلاگ را برمیگرداند
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<List<CommentModel>> GetPostCommentsModel(int postId);
        /// <summary>
        /// پیام خوانده نشده را بر میگرداند
        /// </summary>
        /// <returns></returns>
        Task<List<NewNotificationModel>> GetNewComments();
    }
}
