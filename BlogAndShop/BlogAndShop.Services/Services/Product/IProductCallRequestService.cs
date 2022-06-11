using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Admin;


namespace BlogAndShop.Services.Services.Product
{
    public interface IProductCallRequestService : IMainService<ProductCallRequest>
    {
        /// <summary>
        /// سفارشاتی که جدید هستند را باز می کند
        /// </summary>
        /// <returns></returns>
        Task<List<NewNotificationModel>> GetNewOrders();
        /// <summary>
        /// چک کردن وجود داشتن محصول
        /// ایجاد درخواست جدید
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<bool> CreateNew(ProductCallRequest item);
    }
}
