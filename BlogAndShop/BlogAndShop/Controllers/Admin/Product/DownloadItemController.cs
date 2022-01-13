

using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin.Product
{
    [AdminFilterName(AdminControllerNames.Product, "فایل دانلودی")]
    public class DownloadItemController : BaseAdminController
    {
        #region Fields

        private readonly IDownloadItemService _service;
        private readonly IMediaService _mediaService;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<DownloadItemViewModel, DownloadItem>(all, page, count);
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
            return View(new DownloadItemViewModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(DownloadItemViewModel model)
        {
            model = await GetMediaInfo(model);
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = item.Id });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DownloadItemViewModel model)
        {
            model = await GetMediaInfo(model);
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = model.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        /// <summary>
        /// اگر مدیا انتخاب کرده باشد
        /// اطلاعات فایل انتخابی را قرار می دهیم
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private async Task<DownloadItemViewModel> GetMediaInfo(DownloadItemViewModel model)
        {
            if (model.MediaId == null) return model;
            var media = await _mediaService.GetByIdAsync((int)model.MediaId);
            if (media == null) return model;
            if (string.IsNullOrEmpty(model.Title)) model.Title = media.Title;
            if (string.IsNullOrEmpty(model.Description)) model.Description = media.Description;
            if (string.IsNullOrEmpty(model.DownloadPath)) model.DownloadPath = media.Path;
            return model;
        }
        #endregion
        #region Ctor

        public DownloadItemController(IDownloadItemService service, IAdminModelHelper adminModelHelper, IMediaService mediaService) : base(adminModelHelper)
        {
            _service = service;
            _mediaService = mediaService;
        }
        #endregion


    }
}
