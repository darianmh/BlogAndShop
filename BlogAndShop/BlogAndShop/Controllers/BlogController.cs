using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PostInfo;

namespace BlogAndShop.Controllers
{
    public class BlogController : MainBaseController
    {
        #region Fields

        private readonly IPostGroupService _postGroupService;
        private readonly IPostService _postService;
        private readonly ITagService _tagService;


        #endregion
        #region Methods

        public async Task<IActionResult> Index(int? categoryId, int page = 1, int count = 10)
        {
            var model = await _postGroupService.GetPostModel(categoryId, page, count);
            return View(model);
        }

        public async Task<IActionResult> Item(int postId)
        {
            var item = await _postService.GetByIdAsync(postId);
            if (item == null) return NotFound();
            var model = item.ToModel();
            var tags = await _tagService.GetPostTags(postId);
            model.Tags = tags.Select(x => x.ToModel()).ToList();
            return View(model);
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public BlogController(IPostGroupService postGroupService, IPostService postService, ITagService tagService)
        {
            _postGroupService = postGroupService;
            _postService = postService;
            _tagService = tagService;
        }
        #endregion


    }
}
