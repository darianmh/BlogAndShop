using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;

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

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ProductMediaService(ApplicationDbContext db, IMediaService mediaService) : base(db)
        {
            _mediaService = mediaService;
        }
        #endregion

    }
}