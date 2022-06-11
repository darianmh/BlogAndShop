using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.HomePage;
using CommonConfiguration.Core.Services.Main;
using BlogAndShop.Data.ViewModel.HomePage;


namespace BlogAndShop.Services.Services.HomePage
{
    public interface IHomeBannerService : IMainService<HomeBanner>
    {
        /// <summary>
        /// get all banners from cache
        /// </summary>
        /// <returns></returns>
        Task<List<HomeBannerModel>> GetList();
    }
}