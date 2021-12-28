using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.PaymentInfo;
using BlogAndShop.Services.Services.PostInfo;
using BlogAndShop.Services.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomeSuggestedProductsPosts : ViewComponent
    {
        #region Fields

        private readonly IProductService _productService;
        private readonly IPaymentItemService _paymentItemService;
        private readonly IPostService _postService;

        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newest = await _productService.GetNewestProducts();
            var popular = await _productService.GetMostPopularProducts(_paymentItemService);
            var recentPosts = await _postService.GetRecentPosts();
            var model = new HomeSuggestedProductsPostsModel()
            {
                Newest = newest,
                Popular = popular,
                RecentPosts = recentPosts
            };
            return View(model);
        }


        #endregion
        #region Utilities



        #endregion
        #region Ctor

        public HomeSuggestedProductsPosts(IProductService productService, IPaymentItemService paymentItemService, IPostService postService)
        {
            _productService = productService;
            _paymentItemService = paymentItemService;
            _postService = postService;
        }
        #endregion


    }
}