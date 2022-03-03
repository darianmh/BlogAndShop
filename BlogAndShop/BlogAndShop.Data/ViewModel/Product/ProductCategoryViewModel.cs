using System.Collections.Generic;
using System.Linq;
using BlogAndShop.Data.Data.Product;

namespace BlogAndShop.Data.ViewModel.Product
{
    public class ProductCategoryViewModel
    {
        #region Fields

        /// <summary>
        /// شامل نام تمام گرو های بالاسری
        /// </summary>
        public string ParentGroupName { get; set; }
        public ProductGroupModel CurrentGroup { get; set; }
        /// <summary>
        /// یا مقدار محصولات زیر مجموعه ها را برمیگرداند یا اگر زیر مجموعه نداشت تعداد محصولات خودش را بر میگرداند
        /// </summary>
        public int ProductsCount => _productsCount + ((SubCategories != null && SubCategories.Any()) ? SubCategories.Sum(x => x.ProductsCount) : 0);

        /// <summary>
        /// تعداد محصولات گروه فعلی را برمیگرداند
        /// </summary>
        public int CurrentProductsCount => _productsCount;
        public bool HasProduct => ProductsCount > 0;
        public List<ProductCategoryViewModel> SubCategories { get; set; }
        /// <summary>
        /// اگر تصویر داشت که بر میگرداند
        /// اگر تصویر نداشت یکی از تصاویر زیر مجموعه ها را بر میگرداند
        /// </summary>
        public string ImagePath => !string.IsNullOrEmpty(_imagePath) ? _imagePath : SubCategories?.FirstOrDefault(x => !string.IsNullOrEmpty(x.ImagePath))?.ImagePath;

        #endregion
        #region Methods


        #endregion
        #region Utilities

        private readonly int _productsCount;
        private readonly string _imagePath;

        #endregion
        #region Ctor

        public ProductCategoryViewModel(List<ProductCategoryViewModel> subCategories)
        {
            SubCategories = subCategories;
        }

        public ProductCategoryViewModel(ProductGroupModel currentGroup, List<ProductCategoryViewModel> subCategories,
            int productsCount, string imagePath, string parentName)
        {
            CurrentGroup = currentGroup;
            SubCategories = subCategories;
            _productsCount = productsCount;
            _imagePath = imagePath;
            ParentGroupName = parentName;
        }

        public ProductCategoryViewModel(ProductGroupModel productGroup)
        {
            CurrentGroup = productGroup;
        }

        public ProductCategoryViewModel()
        {

        }
        #endregion


    }
}