using System.Threading.Tasks;
using BlogAndShop.Services.Services.Common;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomeAbout : ViewComponent
    {
        #region Fields


        private readonly ISiteConfigService _siteConfigService;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _siteConfigService.GetInfo();
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public HomeAbout(ISiteConfigService siteConfigService)
        {
            _siteConfigService = siteConfigService;
        }
        #endregion


    }
}