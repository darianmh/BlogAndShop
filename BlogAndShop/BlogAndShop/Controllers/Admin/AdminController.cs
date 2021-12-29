using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin
{
    [AdminFilterName(AdminControllerNames.Dashboard, "داشبرد")]
    public class AdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// پاک کردن کش
        /// </summary>
        /// <returns></returns>
        public IActionResult CacheClear()
        {
            CacheHelper.ClearCache();
            return RedirectToAction("Index");
        }

        public AdminController(IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
        }
    }
}
