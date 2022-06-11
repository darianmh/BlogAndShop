using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Services.Services.Common.Search;
using CommonConfiguration.Core.Controllers;

namespace BlogAndShop.Controllers
{
    public class SearchController : MainBaseController
    {

        #region Fields

        private readonly ISearchService _searchService;
        #endregion
        #region Methods
        public async Task<IActionResult> Index(string key)
        {
            var result = await _searchService.Search(key);
            return View(result);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }
        #endregion


    }
}
