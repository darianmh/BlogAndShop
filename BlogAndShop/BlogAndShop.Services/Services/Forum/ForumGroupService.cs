using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Forum;

using BlogAndShop.Services.Services.Mapper;
using CommonConfiguration.Core.Data.ViewModel.Common;
using Microsoft.EntityFrameworkCore;
using CommonConfiguration.Core.Services.Main;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumGroupService : MainService<ForumGroup>, IForumGroupService
    {
        #region Fields

        private readonly IForumTitleService _forumTitleService;

        #endregion
        #region Methods


        public async Task<int> GetFirst()
        {
            return (await Queryable.FirstOrDefaultAsync())?.Id ?? 0;
        }

        public async Task<ForumListViewModel> GetForumModel(int? forumGroupId, int page, int count)
        {
            var currentGroup = await GetCurrentGroup(forumGroupId);
            var products = await _forumTitleService.GetForumByGroup(forumGroupId, count, page, this);
            var result = new ForumListViewModel()
            {
                CurrentGroup = currentGroup,
                Forums = products.List.OrderBy(x => x.CreateDateTime).Reverse().Select(async x => await _forumTitleService.GetForumMiniModel(x)).Select(x => x.Result).ToList(),
                ListPaginationModel = new ListPaginationModel(products.TotalCount > page * count, hasPre: page > 1, page: page, count: products.List.Count, pagesCount: ((products.TotalCount - 1) / count) + 1),
            };
            result.Keywords = GetKeywords(result.CurrentGroup, result.Forums);
            result.HeaderText = GetHeaderGroupName(result);
            return result;
        }

        public async Task<ForumGroupModel> GetByIdInModel(int groupId)
        {
            var group = await GetByIdAsync(groupId);
            return group.ToModel();
        }

        public async Task<List<ForumGroupModel>> GetGroups()
        {
            var all = await GetAllAsync();
            return all.Select(x => x.ToModel()).ToList();
        }

        #endregion
        #region Utilities

        /// <summary>
        /// بازگرداندن نام سربرگ انجمن ها
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private string GetHeaderGroupName(ForumListViewModel result)
        {
            var text = result.CurrentGroup?.Title;
            return text ?? "همه انجمن ها";
        }


        /// <summary>
        /// تولید کلمات کلیدی با استفاده از ترکیب کلمات گروه و انجمن ها
        /// </summary>
        /// <returns></returns>
        private string GetKeywords(ForumGroupModel currentGroup, List<ForumMiniModel> forums)
        {
            var allKeywords = currentGroup?.Keywords + "," + string.Join(',', forums.Select(x => x.Keywords));
            var keywordsList = allKeywords.Split(',').GroupBy(x => x).Select(x => x).ToList();
            return string.Join(",", keywordsList);
        }
        /// <summary>
        /// دریافت گروه فعلی اگر موجود بود
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        private async Task<ForumGroupModel> GetCurrentGroup(int? forumGroupId)
        {
            if (forumGroupId == null) return null;
            var group = await GetByIdAsync((int)forumGroupId);
            return @group?.ToModel();
        }
        #endregion
        #region Ctor
        public ForumGroupService(ApplicationDbContext db, IForumTitleService forumTitleService) : base(db)
        {
            _forumTitleService = forumTitleService;
        }
        #endregion


    }
}