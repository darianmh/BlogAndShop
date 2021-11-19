using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public interface IBrandService : IMainService<Data.Data.Product.Brand>
    {
        /// <summary>
        /// get from cache or db
        /// </summary>
        /// <returns></returns>
        Task<List<BrandModel>> GetList();
    }
}