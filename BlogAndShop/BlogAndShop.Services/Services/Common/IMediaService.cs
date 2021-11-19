using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Main;
using Microsoft.Extensions.Hosting;

namespace BlogAndShop.Services.Services.Common
{
    public interface IMediaService : IMainService<Media>
    {
        /// <summary>
        /// دریافت مدل تصاویر از محصولات
        /// </summary>
        /// <param name="all"></param>
        /// <returns></returns>
        Task<List<MediaModel>> GetImagesModel(List<ProductMedia> all);

        Task DeleteAsync(int entity, IHostEnvironment hostEnvironment);
    }
}
