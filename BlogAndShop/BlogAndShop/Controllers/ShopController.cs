using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;

namespace BlogAndShop.Controllers
{
    public class ShopController : MainBaseController
    {

        #region Fields

        private readonly IProductGroupService _productGroupService;
        private readonly IProductService _productService;
        private readonly IProductMediaService _productMediaService;
        private readonly IBrandService _brandService;
        private readonly IForumTitleService _forumTitleService;
        private readonly ISiteConfigService _siteConfigService;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int? categoryId, int? brandId, int page = 1, int count = 10)
        {
            var model = await _productGroupService.GetProductModel(categoryId, brandId, page, count);
            return View(model);
        }

        public async Task<IActionResult> Categories(int? categoryId)
        {
            var model = await _productGroupService.GetGroupsModel(categoryId);
            if (!model.SubCategories.Any()) return RedirectToAction("Index", new { categoryId = categoryId });
            return View(model);
        }
        public async Task<IActionResult> Item(int productId)
        {
            var product = await _productService.GetByIdAsync(productId);
            if (product == null) return NotFound();
            var images = await _productMediaService.GetProductImagesModel(productId);
            var suggested = await _productGroupService.GetSuggestedProduct(productId, groupId: product.ProductGroupId);
            var group = await _productGroupService.GetByIdInModel(product.ProductGroupId);
            var productModel = product.ToModel();
            productModel.Brand = await _brandService.GetBrandModel(productModel.BrandId);
            var model = new ProductItemViewModel()
            {
                Images = images,
                ProductModel = productModel,
                SuggestedProducts = suggested,
                Group = group,
                ForumTitles = await _forumTitleService.GetProductForumsModel(productId),
                ShoppingModel = await _siteConfigService.GetShoppingModel()
            };
            return View(model);
        }


        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public ShopController(IProductGroupService productGroupService, IProductService productService, IProductMediaService productMediaService, IBrandService brandService, IForumTitleService forumTitleService, ISiteConfigService siteConfigService)
        {
            _productGroupService = productGroupService;
            _productService = productService;
            _productMediaService = productMediaService;
            _brandService = brandService;
            _forumTitleService = forumTitleService;
            _siteConfigService = siteConfigService;
        }
        #endregion

    }
}
