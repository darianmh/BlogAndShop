using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public interface IProductGroupService : IMainService<ProductGroup>
    {
        /// <summary>
        /// مدل استفاده برای ساخت هدر سایت
        /// </summary>
        /// <returns></returns>
        Task<List<LinkGroupHeaderViewModel>> GetHeaderModel();
        /// <summary>
        /// مدل استفاده برای ساخت هدر سایت به صورت تو در تو
        /// </summary>
        /// <returns></returns>
        Task<List<ProductGroupModel>> GetHeaderNastedModel();
        /// <summary>
        /// مدل برای نمایش در صفحه دسته بندی ها
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        Task<ProductCategoryViewModel> GetGroupsModel(int? categoryId);

        /// <summary>
        /// دریافت لیست محصولات براساس گروه
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="brandId"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<ProductListViewModel> GetProductModel(int? categoryId, int? brandId, int page, int count);
        /// <summary>
        /// پیشنهاد محصول مشابه بر اساس گروه محصول
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="groupId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<List<ProductMiniModel>> GetSuggestedProduct(int productId, int groupId, int count = 4);
        /// <summary>
        /// دریافت گروه در ویومدل
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        Task<ProductGroupModel> GetByIdInModel(int groupId);

        Task<List<ProductGroup>> GetByParentId(int productGroupId);

        /// <summary>
        /// لیست گروه های زیر مجموعه به همراه خود گروه اصلی را برمیگرداند
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        Task<List<int>> GetChildrenGroupsId(int categoryId);

        /// <summary>
        /// مدل برای نمایش در صفحه دسته بندی ها، فقط گروه هایی که محصول دارند
        /// اگر تصویر نداشته باشند، تصویر آخرین محصول نمایش داده می شود
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        Task<ProductCategoryViewModel> GetGroupsHasProductsModel(int? categoryId);

        Task<Dictionary<int, ProductCategoryViewModel>> GetCategoriesDictionaryFromCache();
    }
}
