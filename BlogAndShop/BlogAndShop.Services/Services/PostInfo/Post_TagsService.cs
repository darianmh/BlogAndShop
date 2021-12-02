using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class Post_TagsService : MainServiceNonBaseEntity<Post_Tags>, IPost_TagsService
    {
        #region Fields


        #endregion
        #region Methods


        public async Task<List<Post_Tags>> GetPostTags(int postId)
        {
            return await Queryable.Where(x => x.PostId == postId).ToListAsync();
        }

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