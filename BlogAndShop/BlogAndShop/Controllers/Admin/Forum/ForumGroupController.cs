using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers.Admin.Forum
{
    [AdminFilterName(AdminControllerNames.Forum, "گروه انجمن ها")]
    public class ForumGroupController : BaseAdminController
    {
        #region Fields

        private readonly IForumGroupService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<ForumGroupModel, ForumGroup>(all, page, count);
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
            return View("Edit", new ForumGroupModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ForumGroupModel model)
        {
            if (!ModelState.IsValid) return View("Edit", model);
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ForumGroupModel model)
        {
            if (!ModelState.IsValid) return View("Edit", model);
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

        public ForumGroupController(IForumGroupService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}