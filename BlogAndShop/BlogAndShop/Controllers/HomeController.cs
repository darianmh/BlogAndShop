using BlogAndShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Api;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.User;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers
{
    public class HomeController : MainBaseController
    {
        #region Fields
        private readonly ILogger<HomeController> _logger;
        private readonly INewsLetterEmailService _newsLetterEmailService;
        private readonly ISiteConfigService _siteConfigService;

        #endregion
        #region Methods


        public async Task<IActionResult> Index()
        {
            var selectIndex = await GetSelectIndex();
            if (selectIndex == SiteIndex.Main)
                return View("Index");
            else
                return View("Index2");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error(string code)
        {
            var url = Request.Path;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// افزودن ایمیل به خبرنامه
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult<bool>> AddEmailLetter([FromQuery] string email)
        {
            var model = new NewsLetterEmail() { Email = email };
            await _newsLetterEmailService.InsertAsync(model);
            return new JsonResult<bool>(true);
        }



        public IActionResult ContactUs()
        {
            return RedirectToAction("Index");
        }
        public IActionResult AboutUs()
        {
            return RedirectToAction("Index");
        }
        public IActionResult TermsAndCondition()
        {
            return RedirectToAction("Index");
        }



        public IActionResult Rout()
        {

            //find link item from context
            var linkCheck = HttpContext.Items.TryGetValue("LinkObject", out object? item);
            if (!linkCheck || item == null) return NotFound();
            return RedirectPermanent(item.ToString());
        }
        #endregion
        #region Utilities

        private async Task<SiteIndex> GetSelectIndex()
        {
            var info = await _siteConfigService.GetInfo();
            return info?.SelectIndex ?? SiteIndex.Main;
        }

        #endregion
        #region Ctor

        public HomeController(ILogger<HomeController> logger, INewsLetterEmailService newsLetterEmailService, ISiteConfigService siteConfigService)
        {
            _logger = logger;
            _newsLetterEmailService = newsLetterEmailService;
            _siteConfigService = siteConfigService;


        }
        #endregion

    }
}
