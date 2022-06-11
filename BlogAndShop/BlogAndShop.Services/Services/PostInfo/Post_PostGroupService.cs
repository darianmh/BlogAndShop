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

        public async Task<List<Post_PostGroupModel>> GetPostGroupsModel(int postId)
        {
            var groups = await GetPostGroups(postId);
            return groups.Select(x => x.ToModel()).ToList();
        }

        public async Task SetPostGroups(int postId, List<int> selectedGroups)
        {

            var tags = await GetPostGroups(postId);
            await DeleteAsync(tags);
            if (selectedGroups == null) return;
            await CreateGroups(postId, selectedGroups);
        }

        private async Task CreateGroups(int postId, List<int> selectedGroups)
        {
            selectedGroups = selectedGroups.GroupBy(x => x).Select(x => x.First()).ToList();
            var tags = new List<Post_PostGroup>();
            foreach (var selectedGroup in selectedGroups)
            {
                var temp = new Post_PostGroup()
                {
                    PostId = postId,
                    GroupId = selectedGroup
                };
                tags.Add(temp);
            }

            await InsertAsync(tags);
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