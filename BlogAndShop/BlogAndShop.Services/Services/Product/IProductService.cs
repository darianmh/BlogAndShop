using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public interface IProductService : IMainService<Data.Data.Product.Product>
    {
        /// <summary>
        /// دریافت لیست محصولات بر اساس گروه
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="brandId"></param>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        Task<DbModelInfo<Data.Data.Product.Product>> GetProductByGroup(int? categoryId, int? brandId, int count,
            int page);
        /// <summary>
        /// ساخت مدل کوچک از محصول
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        ProductMiniModel GetProductMiniModel(Data.Data.Product.Product product);
    }
}
