using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Classes;

using BlogAndShop.Services.Services.Mapper;
using CommonConfiguration.Core.Services.Main;

namespace BlogAndShop.Services.Services.Common
{
    public class SocialMediaService : MainService<SocialMedia>, ISocialMediaService
    {
        #region Fields


        #endregion
        #region Methods
        public async Task<List<SocialMediaModel>> GetList()
        {
            if (CacheHelper.SocialMedias == null)
            {
                var all = await GetAllAsync();
                CacheHelper.SocialMedias = all.Select(x => x.ToModel()).ToList();
            }
            return CacheHelper.SocialMedias;
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public SocialMediaService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}