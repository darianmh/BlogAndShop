

using System.Collections.Generic;
using System.Threading.Tasks;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Common;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Email;
using BlogAndShop.Data.ViewModel.Email;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Email;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin.Common
{
    [AdminFilterName(AdminControllerNames.Common, "ایمیل ها")]
    public class EmailAccountController : BaseAdminController
    {
        #region Fields

        private readonly IEmailAccountService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<EmailAccountModel, EmailAccount>(all, page, count);
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
            return View(new EmailAccountModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }
        public async Task<IActionResult> Test(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = new EmailAccountTestModel
            {
                Email = "",
                Id = item.Id
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmailAccountModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Test(EmailAccountTestModel model)
        {
            var item = await _service.GetByIdAsync(model.Id);
            var check = await _service.SendEmailAsync(item, model.Email, "test body", "test subject", new List<string>());
            model.Text = check ? "ایمیل ارسال شد" : "مشکلی پیش آمده است";
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EmailAccountModel model)
        {
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

        public EmailAccountController(IEmailAccountService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}
