

using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PostInfo;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin.PostInfo
{
    [AdminFilterName(AdminControllerNames.PostInfo, "گروه پست ها")]
    public class PostGroupController : BaseAdminController
    {
        #region Fields

        private readonly IPostGroupService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<PostGroupModel, PostGroup>(all, page, count);
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
            return View(new PostGroupModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostGroupModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PostGroupModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            CacheHelper.ClearCache();
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

        public PostGroupController(IPostGroupService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}
