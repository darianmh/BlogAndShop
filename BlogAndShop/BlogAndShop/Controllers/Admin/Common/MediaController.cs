

using System.IO;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Common;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;
using BlogAndShop.Services.Services.Utilities.File;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace BlogAndShop.Controllers.Admin.Common
{
    [AdminFilterName(AdminControllerNames.Common, "فایل ها")]
    public class MediaController : BaseAdminController
    {
        #region Fields

        private readonly IMediaService _service;
        private readonly IFileHelperService _fileHelperService;
        private readonly IHostEnvironment _hostEnvironment;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<MediaModel, Media>(all, page, count);
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
            return View("Edit", new MediaModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] MediaModel model)
        {
            if (!ModelState.IsValid) return View("Edit", model);
            if (model.PathFile == null)
            {
                ModelState.AddModelError("PathFile", "فایل الزامی است.");
                return View("Edit", model);
            }
            var filePath = await _fileHelperService.SaveFile("MediaUpload", model.PathFile, _hostEnvironment);
            var fileExt = Path.GetExtension(filePath);
            model.Path = filePath;
            model.Extension = fileExt;
            model.Title = string.IsNullOrEmpty(model.Title) ? model.PathFile.FileName : model.Title;
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] MediaModel model)
        {
            if (!ModelState.IsValid) return View("Edit", model);
            if (model.PathFile != null)
            {
                var filePath = await _fileHelperService.SaveFile("MediaUpload", model.PathFile, _hostEnvironment);
                var fileExt = Path.GetExtension(filePath);
                _fileHelperService.RemoveFile(model.Path, _hostEnvironment);
                model.Path = filePath;
                model.Extension = fileExt;
                model.Title = string.IsNullOrEmpty(model.Title) ? model.PathFile.FileName : model.Title;
            }
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            return RedirectToAction("Details", new { id = model.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id, _hostEnvironment);
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public MediaController(IMediaService service, IFileHelperService fileHelperService, IHostEnvironment hostEnvironment, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
            _fileHelperService = fileHelperService;
            _hostEnvironment = hostEnvironment;
        }
        #endregion


    }
}
