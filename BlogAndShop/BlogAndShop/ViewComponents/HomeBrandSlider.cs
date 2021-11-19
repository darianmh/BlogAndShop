using System.Threading.Tasks;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomeBrandSlider : ViewComponent
    {
        #region Fields


        private readonly IBrandService _brandService;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _brandService.GetList();
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public HomeBrandSlider(IBrandService brandService)
        {
            _brandService = brandService;
        }
        #endregion


    }
}