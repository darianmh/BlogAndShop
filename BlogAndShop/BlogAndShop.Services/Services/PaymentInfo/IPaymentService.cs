using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public interface IPaymentService : IMainService<Payment>
    {
        /// <summary>
        /// بازگرداندن مدل فاکتور به همراه اطلاعات محصولات و آدرس
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<PaymentModel>> GetUserPaymentsModel(int userId);
        /// <summary>
        /// بازگرداندن فاکتور های کاربر
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Payment>> GetUserPayments(int userId);
        /// <summary>
        /// سفارشاتی که جدید هستند را باز می کند
        /// </summary>
        /// <returns></returns>
        Task<List<NewNotificationModel>> GetNewOrders();
    }
}
