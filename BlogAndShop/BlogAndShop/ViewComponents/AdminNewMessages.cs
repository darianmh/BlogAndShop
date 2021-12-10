using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.PostInfo;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class AdminNewMessages : ViewComponent
    {
        #region Fields

        private readonly IForumCommentService _forumCommentService;
        private readonly IPostCommentService _postCommentService;

        #endregion
        #region Methods
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var post = await _postCommentService.GetNewComments();
            var forum = await _forumCommentService.GetNewComments();
            var result = new List<NewNotificationModel>();
            result.AddRange(post);
            result.AddRange(forum);
            result = result.OrderBy(x => x.Date).Reverse().ToList();
            return View(result);
        }

        #endregion
        #region Utilities
        #endregion
        #region Ctor

        public AdminNewMessages(IForumCommentService forumCommentService, IPostCommentService postCommentService)
        {
            _forumCommentService = forumCommentService;
            _postCommentService = postCommentService;
        }
        #endregion




    }
}