using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.PostInfo;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class BlogSideBar : ViewComponent
    {
        #region Fields


        private readonly IPostGroupService _postGroupService;
        private readonly IPostService _postService;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync(int? categoryId)
        {
            var categories = await _postGroupService.GetHeaderModel();
            var topPosts = await _postService.GetTopPosts(count: 5);
            TempData["Category"] = categoryId;
            var model = new BlogSideBarModel
            {
                Categories = categories,
                TopPosts = topPosts,
                AdvertizeHtml = @"<a href='#!' class='mt-5 d-block text-center overlay-dark-hover overlay-opacity-2 rounded overflow-hidden'>
			<img class='w-100 img-fluid rounded' src='../../lib/Smarty/demo.files/images/unsplash/portfolio/thumb_330/boxed-water-is-better-6RTh34xCS1M-unsplash-min.jpg' alt='...'>
		</a>
		<h4 class='fs--13 text-gray-500 font-weight-normal mt-1 mb-0'>
			Sponsored Ad
		</h4>"
            };
            return View(model);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor


        public BlogSideBar(IPostGroupService postGroupService, IPostService postService)
        {
            _postGroupService = postGroupService;
            _postService = postService;
        }

        #endregion


    }
}