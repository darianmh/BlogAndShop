using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.LearningSystem;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;

namespace BlogAndShop.Services.Services.LearningSystem
{
    public class LearningSystemFooterLinkService : MainService<LearningSystemFooterLink>, ILearningSystemFooterLinkService
    {
        #region Fields


        #endregion
        #region Methods
        public async Task<List<LearningSystemFooterLinkViewModel>> LinksModel()
        {
            var all = await GetAllAsync();
            return all.Select(x => MapperService.ToModel((LearningSystemFooterLink) x)).ToList();
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public LearningSystemFooterLinkService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion



    }
}