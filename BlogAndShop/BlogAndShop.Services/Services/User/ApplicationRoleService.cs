using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.User
{
    public class ApplicationRoleService : MainServiceNonBaseEntity<ApplicationRole>, IApplicationRoleService
    {
        #region Fields


        #endregion
        #region Methods
        public async Task<List<ApplicationRole>> GetRolesByNames(List<string> roles)
        {
            return await Queryable.Where(x => roles.Contains(x.Name)).ToListAsync();
        }

        public async Task<List<ApplicationRole>> GetRolesByIds(List<int> ids)
        {
            var result = new List<ApplicationRole>();
            foreach (var id in ids)
            {
                var temp = await GetByIdAsync(id);
                if (temp != null) result.Add(temp);
            }

            return result;
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ApplicationRoleService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}