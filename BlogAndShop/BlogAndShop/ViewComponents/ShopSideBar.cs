using System.Threading.Tasks;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class ShopSideBar : ViewComponent
    {
        #region Fields


        private readonly IProductGroupService _productGroupService;

        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync(int? categoryId)
        {
            var categories = await _productGroupService.GetHeaderModel();
            TempData["Category"] = categoryId;
            return View(categories);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public ShopSideBar(IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService;
        }


        #endregion


    }
}