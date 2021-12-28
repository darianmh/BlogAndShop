using System.Collections.Generic;
using BlogAndShop.Data.Data.HomePage;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.HomePage;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;

namespace BlogAndShop.Services.Classes
{
    public static class CacheHelper
    {
        #region Fields

        public static SiteConfigModel SiteConfigCache
        {
            get => _siteConfigCache;
            set => _siteConfigCache = value;
        }

        public static List<SocialMediaModel> SocialMedias
        {
            get => _socialMedias;
            set => _socialMedias = value;
        }

        public static List<HomeBannerModel> HomeBanner
        {
            get => _homeBanner;
            set => _homeBanner = value;
        }

        public static List<BrandModel> Brands
        {
            get => _brands;
            set => _brands = value;
        }

        public static List<TopPostModel> TopPosts
        {
            get => _topPosts;
            set => _topPosts = value;
        }

        public static ProductCategoryViewModel ProductCategoryViewModel
        {
            get => _productCategoryViewModel;
            set => _productCategoryViewModel = value;
        }

        public static Dictionary<int, ProductCategoryViewModel> ProductCategoryReference
        {
            get => _productCategoryReference;
            set => _productCategoryReference = value;
        }
        /// <summary>
        /// زمانی که در حال مقدار دادن به لیست رفرنس ها هستیم این مقدار 1 می باشد
        /// </summary>
        public static bool ProductCategoryReferenceLock { get; set; }

        #endregion
        #region Methods

        public static void ClearCache()
        {
            _brands = null;
            _homeBanner = null;
            _siteConfigCache = null;
            _socialMedias = null;
            _topPosts = null;
            _productCategoryViewModel = null;
            _productCategoryReference = null;
        }
        #endregion
        #region Utilities


        private static SiteConfigModel _siteConfigCache;
        private static List<SocialMediaModel> _socialMedias;
        private static List<HomeBannerModel> _homeBanner;
        private static List<BrandModel> _brands;
        private static List<TopPostModel> _topPosts;
        private static ProductCategoryViewModel _productCategoryViewModel;
        private static Dictionary<int, ProductCategoryViewModel> _productCategoryReference;

        #endregion
        #region Ctor

        #endregion

    }
}
