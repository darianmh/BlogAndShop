using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.ViewModel.PaymentInfo;


namespace BlogAndShop.Services.Services.PaymentInfo
{
    public interface IPaymentItemService : IMainService<PaymentItem>
    {
        /// <summary>
        /// بازگرداندن مدل آیتم های فاکتور به همراه اطلاعات محصول
        /// </summary>
        /// <param name="userPaymentId"></param>
        /// <returns></returns>
        Task<List<PaymentItemModel>> GetPaymentItemsModel(int userPaymentId);
        /// <summary>
        /// بازگرداندن آیتم های فاکتور
        /// </summary>
        /// <param name="userPaymentId"></param>
        /// <returns></returns>
        Task<List<PaymentItem>> GetPaymentItems(int userPaymentId);

        /// <summary>
        /// دریافت محصولات فروش
        /// </summary>
        /// <returns></returns>
        Task<List<int>> GetTopProducts();
    }
}
