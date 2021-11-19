using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumGroupService : MainService<ForumGroup>,IForumGroupService
    {
        #region Fields


        #endregion
        #region Methods


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