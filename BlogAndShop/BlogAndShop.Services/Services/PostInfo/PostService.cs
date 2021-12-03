using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class PostService : MainService<Post>, IPostService
    {
        #region Fields

        private readonly IPost_PostGroupService _postPostGroupService;
        private readonly ITagService _tagService;
        private readonly IPostCommentService _postCommentService;

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

        public async Task<PostModel> GetPostModel(int postId)
        {
            var item = await GetByIdAsync(postId);
            if (item == null) return null;
            var model = item.ToModel();
            model.Tags = await GetPostTags(postId, model);
            model.RelatedPosts = await GetRelatedPosts(item);
            model.CommentsModel = await _postCommentService.GetPostCommentsModel(postId);
            return model;
        }


        #endregion
        #region Utilities

        private async Task<List<PostModel>> GetRelatedPosts(Post item)
        {
            //پست های مرتبط
            var postGroups = await _postPostGroupService.GetPostGroups(item.Id);
            var posts = await GetPostsInGroups(postGroups);
            if (posts.Count < 3)
            {
                posts.AddRange(await Queryable.Take(3 - posts.Count).ToListAsync());
            }

            return posts.Select(x => x.ToModel()).ToList();
        }

        private async Task<List<Post>> GetPostsInGroups(List<Post_PostGroup> postGroups)
        {
            var groups = postGroups.Select(x => x.GroupId).ToList();
            var postsId = await _postPostGroupService.GetPostsWithGroups(groups);
            var posts = await GetByIds(postsId);

            return posts;
        }

        private async Task<List<Post>> GetByIds(List<Post_PostGroup> postsId)
        {
            var ids = postsId.Select(x => x.PostId).ToList();
            return await Queryable.Where(x => ids.Contains(x.Id)).ToListAsync();
        }

        private async Task<List<TagModel>> GetPostTags(int postId, PostModel model)
        {
            var tags = await _tagService.GetPostTags(postId);
            return tags.Select(x => x.ToModel()).ToList();
        }
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
        public PostService(ApplicationDbContext db, IPost_PostGroupService postPostGroupService, ITagService tagService, IPostCommentService postCommentService) : base(db)
        {
            _postPostGroupService = postPostGroupService;
            _tagService = tagService;
            _postCommentService = postCommentService;
        }
        #endregion

    }
}