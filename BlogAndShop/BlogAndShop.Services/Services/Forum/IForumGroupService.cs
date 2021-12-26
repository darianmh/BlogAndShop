using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Forum
{
    public interface IForumGroupService : IMainService<ForumGroup>
    {
        /// <summary>
        /// دریافت یک گروه پیشفرض برای انجمن
        /// </summary>
        /// <returns></returns>
        Task<int> GetFirst();

        /// <summary>
        /// دریافت لیست انجمن ها براساس گروه
        /// </summary>
        /// <returns></returns>
        Task<ForumListViewModel> GetForumModel(int? forumGroupId, int page, int count);

        /// <summary>
        /// دریافت گروه در ویومدل
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        Task<ForumGroupModel> GetByIdInModel(int groupId);
        /// <summary>
        /// دریافت همه گروه ها این ویو مدل
        /// </summary>
        /// <returns></returns>
        Task<List<ForumGroupModel>> GetGroups();
    }
}