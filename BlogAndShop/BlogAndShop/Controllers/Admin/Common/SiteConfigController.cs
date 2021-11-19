

using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Common;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Classes;
using BlogAndShop.Services.Classes;

namespace BlogAndShop.Controllers.Admin.Common
{
    [AdminFilterName("Common", "SiteConfig")]
    public class SiteConfigController : BaseAdminController
    {
        #region Fields

        private readonly ISiteConfigService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var model = await _service.GetInfo();
            return View("Details", model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new SiteConfigModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SiteConfigModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            //clear cache
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SiteConfigModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            //clear cache
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = model.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _service.DeleteAsync(id);
            CacheHelper.ClearCache();
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public SiteConfigController(ISiteConfigService service) : base()
        {
            _service = service;
        }
        #endregion


    }
}
