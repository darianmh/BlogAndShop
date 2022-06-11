using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.PostInfo;

using BlogAndShop.Services.Services.Mapper;
using CommonConfiguration.Core.Services.Main;
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

        public async Task<List<Post_TagsModel>> GetPostTagsModel(int postId)
        {
            var tags = await GetPostTags(postId);
            return tags.Select(x => x.ToModel()).ToList();
        }

        public async Task SetPostTags(int postId, List<int> selectedTags)
        {
            var tags = await GetPostTags(postId);
            await DeleteAsync(tags);
            if (selectedTags == null) return;
            await CreateTags(postId, selectedTags);
        }

        public async Task<List<int>> GetPostsWithTag(int tagId)
        {
            return await Queryable.Where(x => x.TagId == tagId).Select(x => x.PostId).ToListAsync();

        }

        #endregion
        #region Utilities

        private async Task CreateTags(int postId, List<int> selectedTags)
        {
            selectedTags = selectedTags.GroupBy(x => x).Select(x => x.First()).ToList();
            var tags = new List<Post_Tags>();
            foreach (var selectedTag in selectedTags)
            {
                var temp = new Post_Tags()
                {
                    PostId = postId,
                    TagId = selectedTag
                };
                tags.Add(temp);
            }

            await InsertAsync(tags);
        }

        #endregion
        #region Ctor
        public Post_TagsService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}