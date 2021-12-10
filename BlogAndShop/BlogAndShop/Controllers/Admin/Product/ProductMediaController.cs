

using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin.Product
{
    [AdminFilterName(AdminControllerNames.Product, "تصاویر محصولات")]
    public class ProductMediaController : BaseAdminController
    {
        #region Fields

        private readonly IProductMediaService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<ProductMediaModel, ProductMedia>(all, page, count);
            return View(model);
        }

        public async Task<IActionResult> Details(int ProductId, int MediaId)
        {
            var item = await _service.Find(ProductId, MediaId);
            var model = item.ToModel();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new ProductMediaModel());
        }
        public async Task<IActionResult> Edit(int ProductId, int MediaId)
        {
            var item = await _service.Find(ProductId, MediaId);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductMediaModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            return RedirectToAction("Details", new { ProductId = model.ProductId, MediaId = model.MediaId });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductMediaModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            return RedirectToAction("Details", new { ProductId = model.ProductId, MediaId = model.MediaId });
        }

        public async Task<IActionResult> Delete(int ProductId, int MediaId)
        {
            var item = await _service.Find(ProductId, MediaId);
            await _service.DeleteAsync(item);
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public ProductMediaController(IProductMediaService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}
