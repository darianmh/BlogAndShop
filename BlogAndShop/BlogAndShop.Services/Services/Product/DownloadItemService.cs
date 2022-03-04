using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Classes.Date;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Utilities;
using BlogAndShop.Services.Services.Utilities.File;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Product
{
    public class DownloadItemService : MainService<Data.Data.Product.DownloadItem>, IDownloadItemService
    {
        #region Fields

        #endregion
        #region Methods
        public async Task<DownloadItemViewModel> GetItemModel(int postId)
        {
            var item = await GetByIdAsync(postId);
            var model = item?.ToModel();
            if (model != null) model.Extension = FileHelperService.GetFileExtension(model.DownloadPath);
            return model;
        }

        public async Task<BookListViewModel> GetItemsModel(int page, int count)
        {
            var info = await GetAllInfoAsync(page, count);
            return new BookListViewModel()
            {
                ListPaginationModel = new ListPaginationModel(info.TotalCount > page * count, hasPre: page > 1, page: page, count: info.List.Count, pagesCount: ((info.TotalCount - 1) / count) + 1),
                Posts = info.List.Select(x => x.ToModel()).ToList()
            };
        }

        public async Task<List<SiteMapItemModel>> GetSiteMap()
        {
            var all = await GetAllAsync();
            return all.Select(x => new SiteMapItemModel
            {
                LastDate = x.UpdateDateTime.ToSiteMapString(),
                Url = $"{DirectoryHelper.Domain}/Book/Item/{x.Id}"
            }).ToList();
        }

        public async Task<List<SearchResultItemModel>> Search(string key)
        {
            var all = await Queryable.Where(x => x.Title.Contains(key) || x.Description.Contains(key)).ToListAsync();
            return all.Select(x => new SearchResultItemModel()
            {
                Name = x.Title,
                SearchResultType = SiteMapType.Book,
                Id = x.Id,
                ImagePath = x.BannerImage
            }).ToList();
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public DownloadItemService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion



    }
}