using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.User
{
    public interface IApplicationRoleService : IMainService<ApplicationRole>
    {
        /// <summary>
        /// بازگرداندن نقش ها بر اساس نام آن ها
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        Task<List<ApplicationRole>> GetRolesByNames(List<string> roles);

        /// <summary>
        /// بازگرداندن نقش ها بر اساس آیدی آنها
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<List<ApplicationRole>> GetRolesByIds(List<int> ids);
    }
}
