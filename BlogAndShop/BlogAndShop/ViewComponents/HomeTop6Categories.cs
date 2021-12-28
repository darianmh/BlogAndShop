using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomeTop6Categories : ViewComponent
    {
        #region Fields

        private readonly IProductGroupService _productGroupService;

        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var top = await GetTopCategories();
            return View(top);
        }


        #endregion
        #region Utilities
        private async Task<List<ProductCategoryViewModel>> GetTopCategories()
        {
            var all = await _productGroupService.GetCategoriesDictionaryFromCache();
            var list = all.Select(x => x.Value).Where(x => x != null && x.HasProduct).OrderBy(x => x.ProductsCount);
            return list.Take(7).ToList();
        }


        #endregion
        #region Ctor

        public HomeTop6Categories(IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService;
        }
        #endregion


    }
}