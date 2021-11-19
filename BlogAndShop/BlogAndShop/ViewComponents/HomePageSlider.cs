using System.Threading.Tasks;
using BlogAndShop.Services.Services.HomePage;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomePageSlider : ViewComponent
    {
        #region Fields


        private readonly IHomeBannerService _homeBannerService;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _homeBannerService.GetList();
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public HomePageSlider(IHomeBannerService homeBannerService)
        {
            _homeBannerService = homeBannerService;
        }
        #endregion


    }
}