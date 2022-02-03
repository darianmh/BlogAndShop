using BlogAndShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Api;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.User;

namespace BlogAndShop.Controllers
{
    public class HomeController : MainBaseController
    {
        #region Fields

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
            return Redirect("https://darianmh.ir/");
        }
        public IActionResult AboutUs()
        {
            ViewBag.PageText = "تیم داریان، یک تیم فعال در زمینه آی تی، برنامه نویسی و آموزش می باشد. این تیم با بیش از 15 سال تجربه و سابقه همکاری در پروژه های بزرگ سعی در ارتقا سطح دانش فنی برنامه نویسان کشور دارد. \r\n همچینین در صورتی که تمایل به برون سپاری پروژه های بزرگ خود دارید، تیم داریان اینجاست تا تمام نیاز های شما از فاز طراحی تا اجرای نهایی پروژه را در اختیار بگیرد.";
            ViewBag.PageTitle = "ما کی هستیم؟";
            return View("MyView");
        }
        public IActionResult TermsAndCondition()
        {
            ViewBag.PageText = "تمامی مطالب سایت از منابع معتبر تهیه و تنظیم شده اند. همچنین برای گرد آوری مطالب زحمت بسیاری کشیده است. اما در صورتی که تمایل داشته از مطالب ما در جایی استفاده کنید، راحت باشید. تیم داریان همواره علاقه مند انتشار مطالبی برای ارتقا سطح علمی جامعه است. \n\rفروشگاه ما نیز جایی برای معرفی محصولات است. وگروه ما هیچگونه دخالتی در فروش محصولات ندارد.";
            ViewBag.PageTitle = "قوانین همکاری با ما چیست؟";
            return View("MyView");
        }



        public IActionResult Rout()
        {

            //find link item from context
            var linkCheck = HttpContext.Items.TryGetValue("LinkObject", out var item);
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

        public HomeController(INewsLetterEmailService newsLetterEmailService, ISiteConfigService siteConfigService)
        {
            _newsLetterEmailService = newsLetterEmailService;
            _siteConfigService = siteConfigService;


        }
        #endregion

    }
}
