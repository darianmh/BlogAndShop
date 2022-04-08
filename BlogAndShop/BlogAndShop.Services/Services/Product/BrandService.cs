using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Product
{
    public class BrandService : MainService<Data.Data.Product.Brand>, IBrandService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<List<BrandModel>> GetList()
        {
            if (CacheHelper.Brands == null)
            {
                var all = await GetAllAsync();
                CacheHelper.Brands = all.Select(x => x.ToModel()).ToList();
            }

            return CacheHelper.Brands;
        }

        public async Task<BrandModel> GetBrandModel(int productModelBrandId)
        {
            var entity = await GetByIdAsync(productModelBrandId);
            return entity == null ? new BrandModel() : entity.ToModel();
        }

        public async Task<Brand> GetBrandByName(string normalName)
        {
            return await Queryable.FirstOrDefaultAsync(x => x.Name.Equals(normalName));
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public BrandService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}