using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumTitleService : MainService<ForumTitle>, IForumTitleService
    {
        #region Fields

        private readonly IProductForumGroupService _productForumGroupService;
        private readonly IForumGroupService _forumGroupService;
        private readonly ISiteConfigService _siteConfigService;
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

        public async Task CreateProductForum(Data.Data.Product.Product item)
        {
            var group = await _siteConfigService.GetProductForumGroup();
            var check = await _forumGroupService.CheckIdAsync(group);
            if (!check) group = await _forumGroupService.GetFirst();
            var forum = await CreateProductForum(item, group);
            await _productForumGroupService.Create(forum, group);
        }

        public async Task<List<SiteMapItemModel>> GetSiteMap()
        {
            var all = await GetAllAsync();
            return all.Select(x => new SiteMapItemModel
            {
                LastDate = x.UpdateDateTime.ToString("s"),
                Url = $"{DirectoryHelper.Domain}/Forum/Item/{x.Id}"
            }).ToList();
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
                Description = item.Description,
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

        #endregion
        #region Ctor
        public ForumTitleService(ApplicationDbContext db, IProductForumGroupService productForumGroupService, IForumGroupService forumGroupService, ISiteConfigService siteConfigService) : base(db)
        {
            _productForumGroupService = productForumGroupService;
            _forumGroupService = forumGroupService;
            _siteConfigService = siteConfigService;
        }
        #endregion


    }
}