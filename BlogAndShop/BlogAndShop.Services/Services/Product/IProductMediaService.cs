using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public interface IProductMediaService : IMainService<ProductMedia>
    {
        /// <summary>
        /// دریافت تصاویر یک محصول
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<List<MediaModel>> GetProductImagesModel(int productId);
    }
}
