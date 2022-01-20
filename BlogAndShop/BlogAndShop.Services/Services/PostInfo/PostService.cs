using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Classes.Date;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class PostService : MainService<Post>, IPostService
    {
        #region Fields

        private readonly IPost_PostGroupService _postPostGroupService;
        private readonly ITagService _tagService;
        private readonly IPostCommentService _postCommentService;
        private readonly IPost_TagsService _postTagsService;

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
            var model = await CreateBlogModel(item, postId);
            //increase visit count
            await IncreaseVisitCount(item);
            return model;
        }

        public async Task IncreaseVisitCount(Post item)
        {
            item.VisitCount++;
            await UpdateAsync(item);
        }


        public async Task<List<SiteMapItemModel>> GetSiteMap()
        {
            var all = await GetAllAsync();
            var encoder = UrlEncoder.Create();
            return all.Select(x => new SiteMapItemModel
            {
                LastDate = x.UpdateDateTime.ToSiteMapString(),
                Url = $"{DirectoryHelper.Domain}/Blog/Post/{encoder.Encode(x.PreferUrl)}"
            }).ToList();
        }

        public async Task<List<SearchResultItemModel>> Search(string key)
        {
            var all = await Queryable.Where(x => x.Title.Contains(key)).ToListAsync();
            return all.Select(x => new SearchResultItemModel()
            {
                ImagePath = x.BannerImage,
                Name = x.Title,
                SearchResultType = SiteMapType.Blog,
                Id = x.Id
            }).ToList();
        }

        public async Task<List<PostModel>> GetRecentPosts()
        {
            var recent = await Queryable.Where(x => x.IsPublished).OrderBy(x => x.CreateDateTime).Reverse().Take(5).ToListAsync();
            return recent.Select(x => x.ToModel()).ToList();
        }

        public async Task<PostModel> GetPostModel(string postUrl)
        {
            var item = await GetPostByUrl(postUrl);
            if (item == null) return null;
            var model = await CreateBlogModel(item, item.Id);
            //increase visit count
            await IncreaseVisitCount(item);
            return model;
        }

        public async Task<Post> GetPostByUrl(string url)
        {
            return await Queryable.FirstOrDefaultAsync(x => x.PreferUrl.Equals(url));
        }

        public async Task<Post> GetLastPost() => await Queryable.OrderBy(x => x.CreateDateTime).Reverse().FirstOrDefaultAsync();

        public async Task<BlogListViewModel> GetPostsByTag(int? tagId, int page, int count)
        {
            DbModelInfo<Post> posts;
            if (tagId == null) posts = await GetAllInfoAsync(page, count);
            else posts = await GetAllByTagAsync(page, count, (int)tagId);
            posts.List = posts.List.Where(x => x.IsPublished).ToList();
            var model = CreatePostListModel(posts, page, count);
            return model;
        }

        private BlogListViewModel CreatePostListModel(DbModelInfo<Post> posts, int page, int count)
        {
            var result = new BlogListViewModel()
            {
                ListPaginationModel = new ListPaginationModel(posts.TotalCount > page * count, hasPre: page > 1, page: page, count: posts.List.Count, pagesCount: ((posts.TotalCount - 1) / count) + 1),
                Posts = posts.List.Select(x => x.ToModel()).ToList(),
            };
            return result;
        }

        #endregion
        #region Utilities

        private async Task<PostModel> CreateBlogModel(Post item, int postId)
        {
            var model = item.ToModel();
            model.Tags = await GetPostTags(postId, model);
            model.Keywords = GetTagsKeyWords(model.Tags, model.Keywords);
            model.RelatedPosts = await GetRelatedPosts(item);
            model.CommentsModel = await _postCommentService.GetPostCommentsModel(postId);
            return model;
        }

        /// <summary>
        /// دریافت کلمات کلیدی از تگ ها
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="modelKeywords"></param>
        /// <returns></returns>
        private string GetTagsKeyWords(List<TagModel> tags, string modelKeywords)
        {
            var keywords = string.Join(',', tags.Select(x => x.Title));
            return modelKeywords + keywords;
        }

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
        private async Task<DbModelInfo<Post>> GetAllByTagAsync(int page, int count, int tagId)
        {
            page = page - 1;
            var all = await GetPostsInTag(tagId);
            var list = await Pagination(all, page, count);
            return new DbModelInfo<Post>
            {
                List = list ?? new List<Post>(),
                TotalCount = await Queryable.CountAsync()
            };
        }

        private async Task<IQueryable<Post>> GetPostsInTag(int tagId)
        {
            var postsGroups = await _postTagsService.GetPostsWithTag(tagId);
            //if null return nothing
            if (postsGroups == null) return Queryable.Take(0);
            return Queryable.Where(x => postsGroups.Contains(x.Id));
        }
        private async Task<IQueryable<Post>> GetPostsInGroup(int categoryId)
        {
            var postsGroups = await _postPostGroupService.GetPostsWithGroup(categoryId);
            //if null return nothing
            if (postsGroups == null) return Queryable.Take(0);
            return Queryable.Where(x => postsGroups.Contains(x.Id));
        }

        #endregion
        #region Ctor
        public PostService(ApplicationDbContext db, IPost_PostGroupService postPostGroupService, ITagService tagService, IPostCommentService postCommentService, IPost_TagsService postTagsService) : base(db)
        {
            _postPostGroupService = postPostGroupService;
            _tagService = tagService;
            _postCommentService = postCommentService;
            _postTagsService = postTagsService;
        }
        #endregion

    }
}