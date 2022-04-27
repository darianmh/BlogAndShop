using System.Threading.Tasks;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.LearningSystem;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.LearningSystem
{
    public interface ILearningSiteConfigService : IMainService<LearningSiteConfig>
    {
        /// <summary>
        /// تبدیل کافیک به ویو مدل
        /// </summary>
        /// <param name="systemId"></param>
        /// <returns></returns>
        Task<LearningSystemLandingModel> GetSystemInfo(int systemId);
    }
}