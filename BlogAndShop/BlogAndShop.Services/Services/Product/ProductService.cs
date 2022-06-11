using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Common;

using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PaymentInfo;
using BlogAndShop.Services.Services.Utilities;
using CommonConfiguration.Core.Data.Classes;
using CommonConfiguration.Core.Services.Classes.Date;
using Microsoft.EntityFrameworkCore;
using CommonConfiguration.Core.Services.Main;
using CommonConfiguration.Core.Services.Utilities;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductService : MainService<Data.Data.Product.Product>, IProductService
    {
        #region Fields

        private readonly IMediaService _mediaService;

        #endregion
        #region Methods

        public async Task<DbModelInfo<Data.Data.Product.Product>> GetProductByGroup(int? categoryId, int? brandId,
            int count,
            int page, IProductGroupService productGroupService)
        {
            DbModelInfo<Data.Data.Product.Product> products;
            if (categoryId == null && brandId == null) products = await GetAllInfoAsync(page, count);
            else if (brandId != null && categoryId != null) products = await GetAllByGroupAndBrandAsync(page, count, (int)categoryId, (int)brandId, productGroupService);
            else if (brandId == null) products = await GetAllByGroupAsync(page, count, (int)categoryId, productGroupService);
            //category is null
            else products = await GetAllByBrandAsync(page, count, (int)brandId);
            return products;
        }

        public async Task<List<Data.Data.Product.Product>> GetProductBySpecificGroup(int categoryId)
        {
            return await Queryable.Where(x => x.ProductGroupId == categoryId).ToListAsync();
        }


        public async Task<ProductMiniModel> GetProductMiniModel(Data.Data.Product.Product product)
        {
            return new ProductMiniModel()
            {
                Title = product.Title,
                Id = product.Id,
                BannerImage = await _mediaService.GetMediaPath(product.BannerImageId),
                OffPrice = product.OffPrice,
                Price = product.Price,
                Keywords = product.Keywords,
                IsAvailable = product.Quantity > 0
            };
        }

        public async Task<ProductModel> GetProductModel(int modelProductId)
        {
            var product = await GetByIdAsync(modelProductId);
            if (product == null) return new ProductModel();
            return product.ToModel();
        }

        public async Task<string> GetProductName(int productId)
        {
            var product = await GetByIdAsync(productId);
            return product?.Title ?? "";
        }

        public async Task<List<SiteMapItemModel>> GetSiteMap()
        {
            var all = await GetAllAsync();
            return all.Where(x => x.IsPublished).Select(x => new SiteMapItemModel
            {
                LastDate = x.UpdateDateTime.ToSiteMapString(),
                Url = $"{DirectoryHelper.Domain}/Shop/Item/{x.Id}"
            }).ToList();
        }

        public async Task<List<SearchResultItemModel>> Search(string key)
        {
            var all = await Queryable.Where(x => x.Title.Contains(key)).ToListAsync();
            return all.Select(async x => new SearchResultItemModel()
            {
                ImagePath = await _mediaService.GetMediaPath(x.BannerImageId),
                Name = x.Title,
                SearchResultType = SiteMapType.Shop,
                Id = x.Id
            }).Select(x => x.Result).ToList();
        }

        public async Task<Data.Data.Product.Product> GetLastGroupProduct(int groupId)
        {
            return await Queryable.Where(x => x.ProductGroupId == groupId).OrderBy(x => x.CreateDateTime).Reverse()
                .FirstOrDefaultAsync();
        }

        public async Task<List<ProductModel>> SalesProduct()
        {
            var sales = await FindSalingProduct();
            if (sales.Count < 5) sales = await GetNonSales(sales);
            return sales;
        }

        public async Task<List<ProductModel>> GetNewestProducts()
        {
            return await Queryable.OrderBy(x => x.CreateDateTime).Reverse().Take(3).Select(x => x.ToModel())
                .ToListAsync();
        }

        public async Task<List<ProductModel>> GetMostPopularProducts(IPaymentItemService paymentItemService)
        {
            var popularIds = await paymentItemService.GetTopProducts();
            var result = new List<ProductModel>();
            for (int i = 0; i < Math.Min(3, popularIds.Count); i++)
            {
                var tempProduct = await GetByIdAsync(popularIds[i]);
                if (tempProduct != null) result.Add(tempProduct.ToModel());
            }

            return result;
        }

        #endregion
        #region Utilities



        /// <summary>
        /// اگر تخفیف ها کمتر از پنج عدد بود بیه را پر کند
        /// </summary>
        /// <param name="sales"></param>
        /// <returns></returns>
        private async Task<List<ProductModel>> GetNonSales(List<ProductModel> sales)
        {
            var count = 5 - sales.Count;
            var nonSales = await Queryable.Where(x => x.OffPrice == null).Take(count).Select(x => x.ToModel()).ToListAsync();
            sales.AddRange(nonSales);
            return sales;
        }

        /// <summary>
        /// دریافت پنج مورد تخفیفی
        /// </summary>
        /// <returns></returns>
        private async Task<List<ProductModel>> FindSalingProduct()
        {
            var sales = await Queryable.Where(x => x.OffPrice != null).Take(5).ToListAsync();
            return sales.Select(x => x.ToModel()).ToList();
        }

        private async Task<DbModelInfo<Data.Data.Product.Product>> GetAllByGroupAsync(int page, int count, int categoryId, IProductGroupService productGroupService)
        {
            page = page - 1;
            var groups = await productGroupService.GetChildrenGroupsId(categoryId);
            var all = Queryable.Where(x => groups.Contains(x.ProductGroupId));
            var list = await Pagination(all, page, count);
            return new DbModelInfo<Data.Data.Product.Product>
            {
                List = list ?? new List<Data.Data.Product.Product>(),
                TotalCount = await all.CountAsync()
            };
        }


        private async Task<DbModelInfo<Data.Data.Product.Product>> GetAllByGroupAndBrandAsync(int page, int count,
            int categoryId, int brandId, IProductGroupService productGroupService)
        {
            var group = await GetAllByGroupAsync(page, count, categoryId, productGroupService);
            group.List = group.List.Where(x => x.BrandId == brandId).ToList();
            return group;
        }

        private async Task<DbModelInfo<Data.Data.Product.Product>> GetAllByBrandAsync(int page, int count, int brandId)
        {
            page = page - 1;
            var all = Queryable.Where(x => x.BrandId == brandId);
            var list = await Pagination(all, page, count);
            return new DbModelInfo<Data.Data.Product.Product>
            {
                List = list ?? new List<Data.Data.Product.Product>(),
                TotalCount = await all.CountAsync()
            };
        }
        #endregion
        #region Ctor
        public ProductService(ApplicationDbContext db, IMediaService mediaService) : base(db)
        {
            _mediaService = mediaService;
        }
        #endregion

    }
}