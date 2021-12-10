using System.Threading.Tasks;
using BlogAndShop.Data.Data.Forum;
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
    }
}