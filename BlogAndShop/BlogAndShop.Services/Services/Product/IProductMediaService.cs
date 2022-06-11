using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using CommonConfiguration.Core.Services.Main;


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

        Task<ProductMedia> Find(int productId, int mediaId);
        /// <summary>
        /// دریافت شناسه تصاویر محصول
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<int>> GetByProductId(int id);

        /// <summary>
        /// دریافت تصاویر محصول
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<ProductMedia>> GetProductImages(int id);

        Task SetProductMedia(int modelId, List<int> selectedMedias);
    }
}
