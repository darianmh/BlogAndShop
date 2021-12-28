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
            return View();
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