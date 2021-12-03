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

        public async Task<ProductModel> GetProductModel(int modelProductId)
        {
            var product = await GetByIdAsync(modelProductId);
            if (product == null) return new ProductModel();
            return product.ToModel();
        }

        #endregion
        #region Utilities

        private async Task<DbModelInfo<Data.Data.Product.Product>> GetAllByGroupAsync(int page, int count, int categoryId, IProductGroupService productGroupService)
        {
            page = page - 1;
            var groups = await productGroupService.GetChildrenGroupsId(categoryId);
            var all = Queryable.Where(x => groups.Contains(x.ProductGroupId));
            var list = await Pagination(all, page, count);
            return new DbModelInfo<Data.Data.Product.Product>
            {
                List = list ?? new List<Data.Data.Product.Product>(),
                TotalCount = await Queryable.CountAsync()
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