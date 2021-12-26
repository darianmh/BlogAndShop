using System.Threading.Tasks;
using BlogAndShop.Services.Services.Forum;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class ForumSideBar : ViewComponent
    {
        #region Fields


        private readonly IForumGroupService _forumGroupService;

        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync(int? categoryId)
        {
            var categories = await _forumGroupService.GetGroups();
            TempData["Category"] = categoryId;
            return View(categories);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public ForumSideBar(IForumGroupService forumGroupService)
        {
            _forumGroupService = forumGroupService;
        }


        #endregion


    }
}