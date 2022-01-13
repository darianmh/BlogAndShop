

using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin.Product
{
    [AdminFilterName(AdminControllerNames.Product, "محصولات")]
    public class ProductController : BaseAdminController
    {
        #region Fields

        private readonly IProductService _service;
        private readonly IProductTagService _productTagService;
        private readonly IForumTitleService _forumTitleService;
        private readonly IProductMediaService _productMediaService;
        private readonly IForumGroupService _forumGroupService;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<ProductModel, Data.Data.Product.Product>(all, page, count);
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            model.SelectedTags = await _productTagService.GetByProductId(id);
            model.SelectedImages = await _productMediaService.GetByProductId(id);
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new ProductModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            model.SelectedTags = await _productTagService.GetByProductId(id);
            model.SelectedImages = await _productMediaService.GetByProductId(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModel model)
        {
            model.AuthorId = await GetUserId();
            var item = model.ToEntity();
            var id = await _service.InsertAsync(item);
            item.Id = id;
            await _productTagService.SetProductTag(item.Id, model.SelectedTags);
            await _productMediaService.SetProductMedia(item.Id, model.SelectedImages);
            await _forumTitleService.CreateProductForum(item, _forumGroupService);
            CacheHelper.ClearCache();
            if (model.SaveAndContinue) return View(model);
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            await _productTagService.SetProductTag(model.Id, model.SelectedTags);
            await _productMediaService.SetProductMedia(model.Id, model.SelectedImages);
            CacheHelper.ClearCache();
            if (model.SaveAndContinue) return View(model);
            return RedirectToAction("Details", new { id = model.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public ProductController(IProductService service, IProductTagService productTagService, IAdminModelHelper adminModelHelper, IForumTitleService forumTitleService, IProductMediaService productMediaService, IForumGroupService forumGroupService) : base(adminModelHelper)
        {
            _service = service;
            _productTagService = productTagService;
            _forumTitleService = forumTitleService;
            _productMediaService = productMediaService;
            _forumGroupService = forumGroupService;
        }
        #endregion


    }
}
