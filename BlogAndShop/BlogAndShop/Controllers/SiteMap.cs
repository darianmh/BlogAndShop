using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;
using BlogAndShop.Services.Services.Utilities;
using BlogAndShop.Services.Services.Utilities.SiteMap;
using Microsoft.Net.Http.Headers;

namespace BlogAndShop.Controllers
{
    public class SiteMap : MainBaseController
    {
        #region Fields

        private readonly ISiteMapService _siteMapService;
        #endregion
        #region Methods

        [Route("/sitemap/Blog.xml")]
        public async Task<ContentResult> Blog()
        {
            CheckDomain();
            var list = await _siteMapService.GetCategorySiteMap(SiteMapType.Blog);
            return Xml(list);
        }
        [Route("/sitemap/Shop.xml")]
        public async Task<ContentResult> Shop()
        {
            CheckDomain();
            var list = await _siteMapService.GetCategorySiteMap(SiteMapType.Shop);
            return Xml(list);
        }

        [Route("/sitemap/Forum.xml")]
        public async Task<ContentResult> Forum()
        {
            CheckDomain();
            var list = await _siteMapService.GetCategorySiteMap(SiteMapType.Forum);
            return Xml(list);
        }
        [Route("/sitemap/Book.xml")]
        public async Task<ContentResult> Book()
        {
            CheckDomain();
            var list = await _siteMapService.GetCategorySiteMap(SiteMapType.Book);
            return Xml(list);
        }
        public async Task<ContentResult> Index()
        {
            CheckDomain();
            var list = _siteMapService.GetMainSiteMap();
            return Xml(list);
        }


        #endregion
        #region Utilities
        private void CheckDomain()
        {
            //domain
            if (string.IsNullOrEmpty(DirectoryHelper.Domain))
                DirectoryHelper.Domain = $"https://{ HttpContext.Request.Host.Value}";
        }

        private ContentResult Xml(List<SiteMapItemModel> list)
        {
            var xml = _siteMapService.CreateSIteMap(list);
            return new ContentResult
            {
                Content = xml,
                ContentType = "application/xml",
                StatusCode = 200
            };
        }

        #endregion
        #region Ctor

        public SiteMap(ISiteMapService siteMapService)
        {
            _siteMapService = siteMapService;
        }
        #endregion


    }
}
