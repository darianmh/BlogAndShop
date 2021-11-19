using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.HomePage;
using BlogAndShop.Data.ViewModel.HomePage;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;

namespace BlogAndShop.Services.Services.HomePage
{
    public class HomeBannerService : MainService<HomeBanner>, IHomeBannerService
    {
        #region Fields


        #endregion
        #region Methods
        public async Task<List<HomeBannerModel>> GetList()
        {
            if (CacheHelper.HomeBanner == null)
            {
                var all = await GetAllAsync();
                CacheHelper.HomeBanner = all.Select(x => x.ToModel()).ToList();
            }

            return CacheHelper.HomeBanner;
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public HomeBannerService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}