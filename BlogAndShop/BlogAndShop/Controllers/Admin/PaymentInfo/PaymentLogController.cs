

using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PaymentInfo;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin.PaymentInfo
{
    [AdminFilterName(AdminControllerNames.PaymentInfo,"تاریخچه های پرداخت")]
    public class PaymentLogController : BaseAdminController
    {
        #region Fields

        private readonly IPaymentLogService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<PaymentLogModel,PaymentLog>(all, page, count);
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
            return View(new PaymentLogModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentLogModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PaymentLogModel model)
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

        public PaymentLogController(IPaymentLogService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}
