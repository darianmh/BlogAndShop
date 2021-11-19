using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class Post_TagsService : MainServiceNonBaseEntity<Post_Tags>, IPost_TagsService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public Post_TagsService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}