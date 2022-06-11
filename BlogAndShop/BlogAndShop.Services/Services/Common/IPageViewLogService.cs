using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Classes;
using CommonConfiguration.Core.Data.Data.Common;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.Common
{
    public interface IPageViewLogService : IMainService<PageViewLog>
    {
        /// <summary>
        /// افزودن لاگ در دیتاابیس
        /// </summary>
        /// <param name="referer"></param>
        /// <param name="ip"></param>
        /// <param name="userId"></param>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        Task InsertLog(string referer, string ip, int? userId, string currentPage);
        /// <summary>
        /// همان لیست ادمین اما قابلیت جستجو
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="searchKey"></param>
        /// <returns></returns>
        Task<DbModelInfo<PageViewLog>> GetAllInfoAsync(int page, int count, string searchKey);
    }
}