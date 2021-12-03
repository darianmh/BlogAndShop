using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class Post_PostGroupService : MainServiceNonBaseEntity<Post_PostGroup>, IPost_PostGroupService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<List<int>> GetPostsWithGroup(int categoryId)
        {
            return await Queryable.Where(x => x.GroupId == categoryId).Select(x => x.PostId).ToListAsync();
        }

        public async Task<List<Post_PostGroup>> GetPostGroups(int postId)
        {
            return await Queryable.Where(x => x.PostId == postId).ToListAsync();
        }

        public async Task<List<Post_PostGroup>> GetPostsWithGroups(List<int> groups)
        {
            return await Queryable.Where(x => groups.Contains(x.GroupId)).ToListAsync();
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public Post_PostGroupService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion

    }
}