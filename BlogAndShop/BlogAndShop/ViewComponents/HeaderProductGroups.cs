using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HeaderProductGroups : ViewComponent
    {
        #region Fields


        private readonly IProductGroupService _productGroupService;
        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _productGroupService.GetHeaderNastedModel();
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public HeaderProductGroups(IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService;
        }

        #endregion


    }
}