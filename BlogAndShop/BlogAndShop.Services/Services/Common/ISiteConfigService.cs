using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;


namespace BlogAndShop.Services.Services.Common
{
    public interface ISiteConfigService : IMainService<SiteConfig>
    {
        /// <summary>
        /// مدل را از دیتابیس یا کش می خواند
        /// </summary>
        /// <returns></returns>
        Task<SiteConfigModel> GetInfo();
        /// <summary>
        /// دریافت اطلاعات گروه انجمن برای محصولات
        /// </summary>
        /// <returns></returns>
        Task<int> GetProductForumGroup();
        /// <summary>
        /// نوع سفارش محصول را بازمیگرداند
        /// </summary>
        /// <returns></returns>
        Task<ShoppingModel> GetShoppingModel();
        /// <summary>
        /// اطلاعات ایمیل های ادمین را برمیگرداند
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetAdminPhoneNumbers();
        /// <summary>
        /// شماره تلفن های ادمین را بر میگرداند
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetAdminEmails();
    }
}
