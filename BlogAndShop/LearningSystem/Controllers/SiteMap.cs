using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Utilities.SiteMap;

using BlogAndShop.Services.Services.Utilities.SiteMap;
using CommonConfiguration.Core.Services.Classes.Date;

namespace LearningSystem.Controllers
{
    public class SiteMap : Controller
    {
        #region Fields

        private readonly ISiteMapService _siteMapService;


        #endregion
        #region Methods
        [Route("SiteMap.xml")]
        public ContentResult Index()
        {
            var items = new List<SiteMapItemModel>()
            {
                new SiteMapItemModel()
                {
                    LastDate = new DateTime(2022,4,27).ToSiteMapString(),
                    Url = "https://"+Request.Host.ToString()
                }
            };
            return Xml(items);
        }

        #endregion
        #region Utilities

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
