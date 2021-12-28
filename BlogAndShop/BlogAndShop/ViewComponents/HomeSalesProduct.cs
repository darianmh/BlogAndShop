using System.Threading.Tasks;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomeSalesProduct : ViewComponent
    {
        #region Fields


        private readonly IProductService _productService;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _productService.SalesProduct();
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public HomeSalesProduct(IProductService productService)
        {
            _productService = productService;
        }
        #endregion


    }
}