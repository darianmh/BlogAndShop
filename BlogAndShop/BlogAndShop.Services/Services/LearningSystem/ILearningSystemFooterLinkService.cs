using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.LearningSystem;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.LearningSystem
{
    public interface ILearningSystemFooterLinkService : IMainService<LearningSystemFooterLink>
    {
        /// <summary>
        /// دریافت مدل همه لینک ها
        /// </summary>
        /// <returns></returns>
        Task<List<LearningSystemFooterLinkViewModel>> LinksModel();
    }
}