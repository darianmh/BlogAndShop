using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class PostService : MainService<Post>, IPostService
    {
        #region Fields

        private readonly IPost_PostGroupService _postPostGroupService;

        #endregion
        #region Methods

        public async Task<DbModelInfo<Post>> GetPostsByGroup(int? categoryId, int page, int count)
        {

            DbModelInfo<Post> posts;
            if (categoryId == null) posts = await GetAllInfoAsync(page, count);
            else posts = await GetAllByGroupAsync(page, count, (int)categoryId);
            posts.List = posts.List.Where(x => x.IsPublished).ToList();
            return posts;
        }

        public async Task<List<TopPostModel>> GetTopPosts(int count)
        {
            var top = CacheHelper.TopPosts;
            if (top == null)
            {
                var all = await FindTopPosts(count);
                top = all.Select(GetTopPostModel).ToList(); ;
                CacheHelper.TopPosts = top;
            }

            return top;
        }


        #endregion
        #region Utilities

        private TopPostModel GetTopPostModel(Post post)
        {
            return new TopPostModel()
            {
                PostId = post.Id,
                PostTitle = post.Title
            };
        }
        private async Task<List<Post>> FindTopPosts(int count)
        {
            var allSorted = Queryable.OrderBy(x => x.PostComments.Count);
            return await allSorted.Take(count).ToListAsync();
        }
        private async Task<DbModelInfo<Post>> GetAllByGroupAsync(int page, int count, int categoryId)
        {
            page = page - 1;
            var all = await GetPostsInGroup(categoryId);
            var list = await Pagination(all, page, count);
            return new DbModelInfo<Post>
            {
                List = list ?? new List<Post>(),
                TotalCount = await Queryable.CountAsync()
            };
        }

        private async Task<IQueryable<Post>> GetPostsInGroup(int categoryId)
        {
            var postsGroups = await _postPostGroupService.GetPostsWithGroup(categoryId);
            //if null return nothing
            if (postsGroups == null) return Queryable.Where(x => false);
            return Queryable.Where(x => postsGroups.Contains(x.Id));
        }

        #endregion
        #region Ctor
        public PostService(ApplicationDbContext db, IPost_PostGroupService postPostGroupService) : base(db)
        {
            _postPostGroupService = postPostGroupService;
        }
        #endregion

    }
}