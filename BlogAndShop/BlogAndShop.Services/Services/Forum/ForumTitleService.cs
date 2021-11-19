using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumTitleService : MainService<ForumTitle>, IForumTitleService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ForumTitleService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}