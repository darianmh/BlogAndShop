using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Utilities.File;
using Microsoft.Extensions.Hosting;

namespace BlogAndShop.Services.Services.Common
{
    public class MediaService : MainService<Media>, IMediaService
    {
        #region Fields

        private readonly IFileHelperService _fileHelperService;
        #endregion
        #region Methods


        public async Task<List<MediaModel>> GetImagesModel(List<ProductMedia> all)
        {
            var result = new List<MediaModel>();
            foreach (var productMedia in all)
            {
                var temp = await GetMediaModel(productMedia);
                result.Add(temp);
            }
            return result;
        }

        public async Task DeleteAsync(int id, IHostEnvironment hostEnvironment)
        {
            var item = await GetByIdAsync(id);
            _fileHelperService.RemoveFile(item.Path, hostEnvironment);
            await DeleteAsync(item);
        }


        #endregion
        #region Utilities

        private async Task<MediaModel> GetMediaModel(ProductMedia productMedia)
        {
            var media = await GetByIdAsync(productMedia.MediaId);
            var model = media.ToModel();
            return model;
        }

        #endregion
        #region Ctor
        public MediaService(ApplicationDbContext db, IFileHelperService fileHelperService) : base(db)
        {
            _fileHelperService = fileHelperService;
        }
        #endregion

    }
}