using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class PostCommentService : MainService<PostComment>, IPostCommentService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public PostCommentService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}