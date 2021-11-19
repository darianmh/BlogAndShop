using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Common
{
    public interface ISocialMediaService : IMainService<SocialMedia>
    {
        /// <summary>
        /// get all items in view model from cache or db
        /// </summary>
        /// <returns></returns>
        Task<List<SocialMediaModel>> GetList();
    }
}