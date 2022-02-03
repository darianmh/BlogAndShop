using System;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers.Admin.Product
{
    [AdminFilterName(AdminControllerNames.Product, "برند")]
    public class BrandController : BaseAdminController
    {
        #region Fields

        private readonly IBrandService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<BrandModel, Brand>(all, page, count);
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new BrandModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BrandModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BrandModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = model.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var item = await _service.GetByIdAsync(id);
                if (item.Products.Any()) return MessagePage("اول محصولات را پاک نمایید");
                await _service.DeleteAsync(item);
                CacheHelper.ClearCache();
            }
            catch (Exception e)
            {
                // ignored
            }
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public BrandController(IBrandService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}