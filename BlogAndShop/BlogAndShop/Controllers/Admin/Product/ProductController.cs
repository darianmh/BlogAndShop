

using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Classes;

namespace BlogAndShop.Controllers.Admin.Product
{
    [AdminFilterName(AdminControllerNames.Product, "Product")]
    public class ProductController : BaseAdminController
    {
        #region Fields

        private readonly IProductService _service;
        private readonly IProductTagService _productTagService;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = new AdminListViewModel<Data.Data.Product.Product>(hasNext: all.TotalCount > page * count, hasPre: page > 1, items: all.List, page: page, count: all.List.Count, pagesCount: ((all.TotalCount - 1) / count) + 1);
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            model.SelectedTags = await _productTagService.GetByProductId(id);
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
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModel model)
        {
            model.AuthorId = GetUserId();
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
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

        public ProductController(IProductService service, IProductTagService productTagService) : base()
        {
            _service = service;
            _productTagService = productTagService;
        }
        #endregion


    }
}
