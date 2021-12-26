using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Classes.Date;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumTitleService : MainService<ForumTitle>, IForumTitleService
    {
        #region Fields

        private readonly IProductForumGroupService _productForumGroupService;
        private readonly ISiteConfigService _siteConfigService;
        private readonly IForumCommentService _forumCommentService;
        #endregion
        #region Methods
        public async Task<List<ForumTitleModel>> GetProductForumsModel(int productId)
        {
            var forums = await _productForumGroupService.GetProductForums(productId);
            var result = new List<ForumTitleModel>();
            foreach (var forum in forums)
            {
                var temp = await GetByIdAsync(forum.ForumTitleId);
                if (temp != null)
                {
                    var tempModel = temp.ToModel();
                    result.Add(tempModel);
                }
            }
            return result;
        }

        public async Task CreateProductForum(Data.Data.Product.Product item, IForumGroupService forumGroupService)
        {
            var group = await _siteConfigService.GetProductForumGroup();
            var check = await forumGroupService.CheckIdAsync(group);
            if (!check) group = await forumGroupService.GetFirst();
            var forum = await CreateProductForum(item, group);
            await _productForumGroupService.Create(forum, item.Id);
        }

        public async Task<List<SiteMapItemModel>> GetSiteMap()
        {
            var all = await GetAllAsync();
            return all.Select(x => new SiteMapItemModel
            {
                LastDate = x.UpdateDateTime.ToSiteMapString(),
                Url = $"{DirectoryHelper.Domain}/Forum/Item/{x.Id}"
            }).ToList();
        }

        public async Task<List<SearchResultItemModel>> Search(string key)
        {
            var all = await Queryable.Where(x => x.Title.Contains(key) || x.Description.Contains(key)).ToListAsync();
            return all.Select(x => new SearchResultItemModel()
            {
                Name = x.Title,
                SearchResultType = SiteMapType.Forum,
                Id = x.Id
            }).ToList();
        }

        public async Task<DbModelInfo<ForumTitle>> GetForumByGroup(int? forumGroupId, int count, int page, IForumGroupService forumGroupService)
        {
            DbModelInfo<ForumTitle> forumTitles;
            //group is null
            if (forumGroupId == null) forumTitles = await GetAllInfoAsync(page, count);
            else forumTitles = await GetAllByGroupAsync(page, count, (int)forumGroupId, forumGroupService);
            return forumTitles;
        }

        public async Task<ForumMiniModel> GetForumMiniModel(ForumTitle forumTitle)
        {
            var comments = await _forumCommentService.GetAcceptedCommentsByTitle(forumTitle.Id);
            return new ForumMiniModel()
            {
                Id = forumTitle.Id,
                Title = forumTitle.Title,
                Keywords = forumTitle.Keywords,
                Description = forumTitle.Description,
                UsersCount = comments.GroupBy(x => x.UserId).Count(),
                CommentsCount = comments.Count
            };
        }

        #endregion
        #region Utilities
        /// <summary>
        /// ایجا انجمن
        /// </summary>
        /// <param name="item"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        private async Task<ForumTitle> CreateProductForum(Data.Data.Product.Product item, int @group)
        {
            var forum = new ForumTitle()
            {
                Description = item.MetaDescription,
                Keywords = item.Keywords,
                MetaDescription = item.MetaDescription,
                Status = ForumStatus.Open,
                Title = item.Title,
                OwnerId = item.AuthorId,
                ForumGroupId = group
            };
            await InsertAsync(forum);
            return forum;
        }

        private async Task<DbModelInfo<ForumTitle>> GetAllByGroupAsync(int page, int count, int forumGroupId, IForumGroupService forumGroupService)
        {
            page = page - 1;
            var all = Queryable.Where(x => x.ForumGroupId == forumGroupId);
            var list = await Pagination(all, page, count);
            return new DbModelInfo<ForumTitle>
            {
                List = list ?? new List<ForumTitle>(),
                TotalCount = await Queryable.CountAsync()
            };
        }

        #endregion
        #region Ctor
        public ForumTitleService(ApplicationDbContext db, IProductForumGroupService productForumGroupService, ISiteConfigService siteConfigService, IForumCommentService forumCommentService) : base(db)
        {
            _productForumGroupService = productForumGroupService;
            _siteConfigService = siteConfigService;
            _forumCommentService = forumCommentService;
        }
        #endregion


    }
}