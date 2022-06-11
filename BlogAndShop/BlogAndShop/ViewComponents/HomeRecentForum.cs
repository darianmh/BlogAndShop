using System.Threading.Tasks;
using BlogAndShop.Services.Services.Forum;
using CommonConfiguration.Core.Services.User.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomeRecentForum : ViewComponent
    {
        #region Fields

        private readonly IForumCommentService _forumCommentService;
        private readonly ApplicationUserManager _applicationUserManager;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recent = await _forumCommentService.GetRecentComments(_applicationUserManager);
            return View(recent);
        }


        #endregion
        #region Utilities
        #endregion
        #region Ctor

        public HomeRecentForum(IForumCommentService forumCommentService, ApplicationUserManager applicationUserManager)
        {
            _forumCommentService = forumCommentService;
            _applicationUserManager = applicationUserManager;
        }
        #endregion


    }
}