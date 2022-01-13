using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.HomePage;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.HomePage;
using BlogAndShop.Services.Services.PostInfo;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class HomePageSlider : ViewComponent
    {
        #region Fields


        private readonly IHomeBannerService _homeBannerService;
        private readonly IPostService _postService;


        #endregion
        #region Methods


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _homeBannerService.GetList();
            var lastBlog = await _postService.GetLastPost();
            model = AddPost(model, lastBlog);
            return View(model);
        }


        #endregion
        #region Utilities


        private List<HomeBannerModel> AddPost(List<HomeBannerModel> model, Post lastBlog)
        {
            var htmlContent =
                $@"<h1 class='h2-xs fs--50 line-height-1' data-swiper-parallax='-300'>{lastBlog.Title}</h1><p data-swiper-parallax='-100'>{lastBlog.Description.GetShortString()}</p><p class='mt-5' data-swiper-parallax='-200'><a href='/Blog/Post/{lastBlog.PreferUrl}' class='btn btn-danger transition-hover-top'><i class='fi fi-arrow-end'></i>بیشتر بخوانید</a></p>";
            var post = new HomeBannerModel
            {
                CreateDateTime = lastBlog.CreateDateTime,
                UpdateDateTime = lastBlog.UpdateDateTime,
                BannerPath = lastBlog.BannerImage,
                HtmlContent = htmlContent,
                Link = $"/Blog/Post/{lastBlog.PreferUrl}"
            };
            model.Add(post);
            return model;
        }
        #endregion
        #region Ctor

        public HomePageSlider(IHomeBannerService homeBannerService, IPostService postService)
        {
            _homeBannerService = homeBannerService;
            _postService = postService;
        }
        #endregion


    }
}