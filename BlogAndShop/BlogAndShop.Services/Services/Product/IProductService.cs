using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
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
        /// <param name="productGroupService"></param>
        /// <returns></returns>
        Task<DbModelInfo<Data.Data.Product.Product>> GetProductByGroup(int? categoryId, int? brandId, int count,
            int page, IProductGroupService productGroupService);
        /// <summary>
        /// ساخت مدل کوچک از محصول
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        ProductMiniModel GetProductMiniModel(Data.Data.Product.Product product);

        /// <summary>
        /// ساخت مدل کوچک از محصول
        /// با استفاده از آی دی محصول
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<ProductModel> GetProductModel(int modelProductId);
        /// <summary>
        /// دریافت نام محصول
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<string> GetProductName(int productId);
        /// <summary>
        /// سایت مپ را از تولید می کند از تمام موارد
        /// </summary>
        /// <returns></returns>
        Task<List<SiteMapItemModel>> GetSiteMap();

        /// <summary>
        /// جستجو در بین موارد موجود
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<List<SearchResultItemModel>> Search(string key);

        /// <summary>
        /// دریافت آخرین محصول موجود در گروه
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        Task<Data.Data.Product.Product> GetLastGroupProduct(int groupId);
    }
}
