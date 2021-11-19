using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductService : MainService<Data.Data.Product.Product>, IProductService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<DbModelInfo<Data.Data.Product.Product>> GetProductByGroup(int? categoryId, int? brandId,
            int count,
            int page)
        {
            DbModelInfo<Data.Data.Product.Product> products;
            if (categoryId == null && brandId == null) products = await GetAllInfoAsync(page, count);
            else if (brandId == null) products = await GetAllByGroupAsync(page, count, (int)categoryId);
            //category is null
            else products = await GetAllByBrandAsync(page, count, (int)brandId);
            return products;
        }


        public ProductMiniModel GetProductMiniModel(Data.Data.Product.Product product)
        {
            return new ProductMiniModel()
            {
                Title = product.Title,
                Id = product.Id,
                BannerImage = product.BannerImage,
                OffPrice = product.OffPrice,
                Price = product.Price
            };
        }

        #endregion
        #region Utilities

        private async Task<DbModelInfo<Data.Data.Product.Product>> GetAllByGroupAsync(int page, int count, int categoryId)
        {
            page = page - 1;
            var all = Queryable.Where(x => x.ProductGroupId == categoryId);
            var list = await Pagination(all, page, count);
            return new DbModelInfo<Data.Data.Product.Product>
            {
                List = list ?? new List<Data.Data.Product.Product>(),
                TotalCount = await Queryable.CountAsync()
            };
        }



        private async Task<DbModelInfo<Data.Data.Product.Product>> GetAllByBrandAsync(int page, int count, int brandId)
        {
            page = page - 1;
            var all = Queryable.Where(x => x.BrandId == brandId);
            var list = await Pagination(all, page, count);
            return new DbModelInfo<Data.Data.Product.Product>
            {
                List = list ?? new List<Data.Data.Product.Product>(),
                TotalCount = await Queryable.CountAsync()
            };
        }
        #endregion
        #region Ctor
        public ProductService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion

    }
}