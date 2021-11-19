using System.Threading.Tasks;
using BlogAndShop.Services.Services.Common;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class SocialMedias : ViewComponent
    {
        #region Fields


        private readonly ISocialMediaService _socialMediaService;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _socialMediaService.GetList();
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public SocialMedias(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        #endregion


    }
}