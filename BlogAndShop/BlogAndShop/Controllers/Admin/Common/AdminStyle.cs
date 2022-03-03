using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;
using BlogAndShop.Services.Services.Utilities.File;
using Microsoft.Extensions.Hosting;

namespace BlogAndShop.Controllers.Admin.Common
{
    /// <summary>
    /// صفحه ویرایش استایل در پنل ادمین
    /// </summary>
    [AdminFilterName(AdminControllerNames.Common, "استایل های اضافی")]
    public class AdminStyle : BaseAdminController
    {
        private readonly IFileHelperService _fileHelperService;
        private readonly IHostEnvironment _hostEnvironment;

        public AdminStyle(IFileHelperService fileHelperService, IHostEnvironment hostEnvironment, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _fileHelperService = fileHelperService;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var path = "css/AdminCustom.css";
            var file = _fileHelperService.LoadFile(path, _hostEnvironment);
            var reader = file.OpenText();
            var text = await reader.ReadToEndAsync();
            var model = new AdminStyleViewModel { Style = text };
            reader.Close();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminStyleViewModel model)
        {
            var path = "css/AdminCustom.css";
            var file = _fileHelperService.LoadFile(path, _hostEnvironment);
            var writer = file.CreateText();
            await writer.WriteAsync(model.Style);
            writer.Close();
            return View(model);
        }
    }
}
