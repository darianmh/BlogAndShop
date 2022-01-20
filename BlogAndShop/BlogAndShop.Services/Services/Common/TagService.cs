using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.PostInfo;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Common
{
    public class TagService : MainService<Tag>, ITagService
    {
        #region Fields

        private readonly IPost_TagsService _postTagsService;

        #endregion
        #region Methods

        public async Task<List<Tag>> GetPostTags(int postId)
        {
            var postTags = await _postTagsService.GetPostTags(postId);
            var tags = await Find(postTags.Select(x => x.TagId).ToList());
            return tags;
        }

        public async Task<Tag> GetTagByName(string tagName)
        {
            tagName = tagName.Trim();
            return (await Queryable.ToListAsync()).FirstOrDefault(x => x.Title.Trim().Equals(tagName, StringComparison.OrdinalIgnoreCase));
        }

        #endregion
        #region Utilities

        private async Task<List<Tag>> Find(List<int> tagsId)
        {
            return await Queryable.Where(x => tagsId.Contains(x.Id)).ToListAsync();
        }

        #endregion
        #region Ctor
        public TagService(ApplicationDbContext db, IPost_TagsService postTagsService) : base(db)
        {
            _postTagsService = postTagsService;
        }
        #endregion

    }
}