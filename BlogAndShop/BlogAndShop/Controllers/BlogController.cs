using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Services.Services.PostInfo;

namespace BlogAndShop.Controllers
{
    public class BlogController : MainBaseController
    {
        #region Fields

        private readonly IPostGroupService _postGroupService;
        private readonly IPostService _postService;


        #endregion
        #region Methods

        public async Task<IActionResult> Index(int? categoryId, int page = 1, int count = 10)
        {
            var model = await _postGroupService.GetPostModel(categoryId, page, count);
            return View(model);
        }

        public IActionResult Item()
        {
            return View();
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public BlogController(IPostGroupService postGroupService, IPostService postService)
        {
            _postGroupService = postGroupService;
            _postService = postService;
        }
        #endregion


    }
}
