using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Common;

using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;
using CommonConfiguration.Core.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductMediaService : MainServiceNonBaseEntity<ProductMedia>, IProductMediaService
    {
        #region Fields

        private IMediaService _mediaService;
        #endregion
        #region Methods


        public async Task<List<MediaModel>> GetProductImagesModel(int productId)
        {
            var all = await Queryable.Where(x => x.ProductId == productId).ToListAsync();
            var model = await _mediaService.GetImagesModel(all);
            return model;
        }

        public async Task<ProductMedia> Find(int productId, int mediaId)
        {
            return await Queryable.FirstOrDefaultAsync(x => x.ProductId == productId && x.MediaId == mediaId);
        }

        public async Task<List<int>> GetByProductId(int id)
        {
            var tags = await GetProductImages(id);
            return tags.Select(x => x.MediaId).ToList();
        }

        public async Task<List<ProductMedia>> GetProductImages(int id)
        {
            return await Queryable.Where(x => x.ProductId == id).ToListAsync();
        }

        public async Task SetProductMedia(int modelId, List<int> selectedMedias)
        {

            var medias = await GetProductImages(modelId);
            await DeleteAsync(medias);
            if (selectedMedias == null) return;
            await CreateMedias(modelId, selectedMedias);
        }
        #endregion
        #region Utilities

        private async Task CreateMedias(int productId, List<int> selectedMedias)
        {
            selectedMedias = selectedMedias.GroupBy(x => x).Select(x => x.First()).ToList();
            var tags = new List<ProductMedia>();
            foreach (var selectedMedia in selectedMedias)
            {
                var temp = new ProductMedia()
                {
                    ProductId = productId,
                    MediaId = selectedMedia
                };
                tags.Add(temp);
            }

            await InsertAsync(tags);
        }

        #endregion
        #region Ctor
        public ProductMediaService(ApplicationDbContext db, IMediaService mediaService) : base(db)
        {
            _mediaService = mediaService;
        }
        #endregion

    }
}