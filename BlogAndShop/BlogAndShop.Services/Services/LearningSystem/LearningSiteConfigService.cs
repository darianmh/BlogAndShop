using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.LearningSystem;

using BlogAndShop.Services.Services.Mapper;
using CommonConfiguration.Core.Services.Main;

namespace BlogAndShop.Services.Services.LearningSystem
{
    public class LearningSiteConfigService : MainService<LearningSiteConfig>, ILearningSiteConfigService
    {
        #region Fields


        #endregion
        #region Methods
        public async Task<LearningSystemLandingModel> GetSystemInfo(int systemId)
        {
            var config = await GetByIdAsync(systemId);
            return new LearningSystemLandingModel() { ConfigModel = config.ToModel() };
        }


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public LearningSiteConfigService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion



    }
}