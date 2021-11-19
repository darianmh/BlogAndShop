using System.Threading.Tasks;
using BlogAndShop.Services.Services.PostInfo;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HeaderBlogGroups : ViewComponent
    {
        #region Fields


        private readonly IPostGroupService _postGroupService;
        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _postGroupService.GetHeaderModel();
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public HeaderBlogGroups(IPostGroupService postGroupService)
        {
            _postGroupService = postGroupService;
        }

        #endregion


    }
}