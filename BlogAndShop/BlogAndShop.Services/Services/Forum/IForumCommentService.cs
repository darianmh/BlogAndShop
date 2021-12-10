using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Forum
{
    public interface IForumCommentService : IMainService<ForumComment>
    {
        /// <summary>
        /// پیام های خوانده نشده را برمگرداند
        /// آیدی انجمن را شامل است
        /// </summary>
        /// <returns></returns>
        Task<List<NewNotificationModel>> GetNewComments();
    }
}
