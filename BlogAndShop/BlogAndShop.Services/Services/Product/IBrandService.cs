using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Product;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.Product
{
    public interface IBrandService : IMainService<Data.Data.Product.Brand>
    {
        /// <summary>
        /// get from cache or db
        /// </summary>
        /// <returns></returns>
        Task<List<BrandModel>> GetList();
        /// <summary>
        /// بازگرداندن مدل برند
        /// </summary>
        /// <param name="productModelBrandId"></param>
        /// <returns></returns>
        Task<BrandModel> GetBrandModel(int productModelBrandId);

        /// <summary>
        /// دریافت برند از نام برند
        /// </summary>
        /// <param name="normalName"></param>
        /// <returns></returns>
        Task<Brand> GetBrandByName(string normalName);
    }
}