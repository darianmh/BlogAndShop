using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumCommentService : MainService<ForumComment>, IForumCommentService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ForumCommentService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}