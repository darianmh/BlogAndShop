using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers.Admin.Common
{
    [AdminFilterName(AdminControllerNames.Common, "شبکه های اجتماعی")]
    public class SocialMediaController : BaseAdminController
    {
        #region Fields

        private readonly ISocialMediaService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<SocialMediaModel, SocialMedia>(all, page, count);
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
            return View(new SocialMediaModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SocialMediaModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SocialMediaModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
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

        public SocialMediaController(ISocialMediaService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}