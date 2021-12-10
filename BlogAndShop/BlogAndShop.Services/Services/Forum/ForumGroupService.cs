using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumGroupService : MainService<ForumGroup>, IForumGroupService
    {
        #region Fields


        #endregion
        #region Methods


        public async Task<int> GetFirst()
        {
            return (await Queryable.FirstOrDefaultAsync())?.Id ?? 0;
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ForumGroupService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}