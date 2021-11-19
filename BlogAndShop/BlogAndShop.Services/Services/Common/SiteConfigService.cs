using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;

namespace BlogAndShop.Services.Services.Common
{
    public class SiteConfigService : MainService<SiteConfig>, ISiteConfigService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<SiteConfigModel> GetInfo()
        {

            var model = CacheHelper.SiteConfigCache;
            if (model == null)
            {
                var entity = (await GetAllAsync()).FirstOrDefault();
                if (entity == null) return new SiteConfigModel();
                model = entity?.ToModel();
                if (model == null) return new SiteConfigModel();
                CacheHelper.SiteConfigCache = model;
            }
            return model;
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public SiteConfigService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion

    }
}