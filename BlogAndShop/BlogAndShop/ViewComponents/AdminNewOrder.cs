using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Services.Services.PaymentInfo;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class AdminNewOrder : ViewComponent
    {
        #region Fields

        private readonly IPaymentService _paymentService;
        private readonly IProductCallRequestService _productCallRequestService;


        #endregion
        #region Methods
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var post = await _paymentService.GetNewOrders();
            var forum = await _productCallRequestService.GetNewOrders();
            var result = new List<NewNotificationModel>();
            result.AddRange(post);
            result.AddRange(forum);
            result = result.OrderBy(x => x.Date).Reverse().ToList();
            return View(result);
        }

        #endregion
        #region Utilities
        #endregion
        #region Ctor
        public AdminNewOrder(IPaymentService paymentService, IProductCallRequestService productCallRequestService)
        {
            _paymentService = paymentService;
            _productCallRequestService = productCallRequestService;
        }
        #endregion




    }
}