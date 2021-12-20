using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.PostInfo;
using BlogAndShop.Services.Services.Product;

namespace BlogAndShop.Services.Services.Utilities.SiteMap
{
    public class SiteMapService : ISiteMapService
    {
        #region Fields

        private readonly IPostService _postService;
        private readonly IProductService _productService;
        private readonly IForumTitleService _forumTitleService;

        #endregion
        #region Methods
        public List<SiteMapItemModel> GetMainSiteMap()
        {
            var domain = DirectoryHelper.Domain;
            return new List<SiteMapItemModel>()
            {
                new SiteMapItemModel()
                {
                    LastDate = DateTime.Now.ToString("s"),
                    Url = $"{domain}/sitemap/Blog"
                },
                new SiteMapItemModel()
                {
                    LastDate = DateTime.Now.ToString("s"),
                    Url = $"{domain}/sitemap/Shop"
                },
                new SiteMapItemModel()
                {
                    LastDate = DateTime.Now.ToString("s"),
                    Url = $"{domain}/sitemap/Forum"
                }
            };
        }

        public async Task<List<SiteMapItemModel>> GetCategorySiteMap(SiteMapType category)
        {
            switch (category)
            {
                case SiteMapType.Shop:
                    return await _productService.GetSiteMap();
                case SiteMapType.Blog:
                    return await _postService.GetSiteMap();
                case SiteMapType.Forum:
                    return await _forumTitleService.GetSiteMap();
                default: return new List<SiteMapItemModel>();
            }
        }

        public string CreateSIteMap(List<SiteMapItemModel> list)
        {
            var text = "";
            text += "<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">";
            foreach (var item in list)
            {
                text += "<url>";
                text += $"<loc>{item.Url}</loc>";
                text += $"<lastmod>{item.LastDate}</lastmod>";
                text += "</url>";
            }

            text += "</urlset>";
            return text;
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public SiteMapService(IPostService postService, IProductService productService, IForumTitleService forumTitleService)
        {
            _postService = postService;
            _productService = productService;
            _forumTitleService = forumTitleService;
        }
        #endregion


    }
}
