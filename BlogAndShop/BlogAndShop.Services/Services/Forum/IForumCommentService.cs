using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.User.Identity;

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

        /// <summary>
        /// دریافت لیست کامنت های انجمن
        /// </summary>
        /// <param name="forumTitleId"></param>
        /// <returns></returns>
        Task<List<ForumComment>> GetCommentsByTitle(int forumTitleId);

        /// <summary>
        /// دریافت لیست کامنت های انجمن در ویوممدل
        /// </summary>
        /// <param name="forumTitleId"></param>
        /// <returns></returns>
        Task<List<ForumCommentModel>> GetCommentsByTitleInModel(int forumTitleId);

        /// <summary>
        /// دریافت لیست کامنت های تایید شده انجمن در ویوممدل
        /// </summary>
        /// <param name="forumTitleId"></param>
        /// <param name="userManager"></param>
        /// <returns></returns>
        Task<List<ForumCommentModel>> GetAcceptedCommentsByTitleInModel(int forumTitleId, ApplicationUserManager userManager);

        /// <summary>
        /// دریافت لیست کامنت های تایید شده انجمن
        /// </summary>
        /// <param name="forumTitleId"></param>
        /// <returns></returns>
        Task<List<ForumComment>> GetAcceptedCommentsByTitle(int forumTitleId);
        /// <summary>
        /// دریافت 2 کامنت آخر 
        /// </summary>
        /// <returns></returns>
        Task<List<ForumCommentModel>> GetRecentComments(ApplicationUserManager applicationUserManager);
    }
}
