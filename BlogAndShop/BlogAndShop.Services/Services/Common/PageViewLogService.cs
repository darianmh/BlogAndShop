using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Common
{
    public class PageViewLogService : MainService<PageViewLog>, IPageViewLogService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task InsertLog(string referer, string ip, int? userId, string currentPage)
        {
            var item = new PageViewLog()
            {
                UserId = userId,
                IpV4 = ip,
                RefererUrl = referer,
                CurrentPage = currentPage
            };
            await InsertAsync(item);
        }
        public async Task<DbModelInfo<PageViewLog>> GetAllInfoAsync(int page, int count, string searchKey)
        {
            page = page - 1;
            var all = Pagination(Queryable.AsNoTracking().ToList()
                .Where(x => x.CurrentPage.Contains(searchKey, StringComparison.OrdinalIgnoreCase) ||
                          x.RefererUrl.Contains(searchKey, StringComparison.OrdinalIgnoreCase) ||
                          x.IpV4.Contains(searchKey, StringComparison.OrdinalIgnoreCase)), page, count);
            return new DbModelInfo<PageViewLog>
            {
                List = all ?? new List<PageViewLog>(),
                TotalCount = await Queryable.CountAsync()
            };
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public PageViewLogService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}