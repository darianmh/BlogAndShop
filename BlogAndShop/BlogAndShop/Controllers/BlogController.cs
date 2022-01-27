using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PostInfo;
using BlogAndShop.Services.Services.User.Identity;
using Microsoft.AspNetCore.Http;

namespace BlogAndShop.Controllers
{
    public class BlogController : MainBaseController
    {
        #region Fields

        private readonly IPostGroupService _postGroupService;
        private readonly IPostService _postService;
        private readonly ITagService _tagService;
        private readonly IPostCommentService _postCommentService;
        private readonly ApplicationUserManager _applicationUserManager;


        #endregion
        #region Methods

        [Route("Blog/{action=Index}/{categoryId?}")]
        public async Task<IActionResult> Index(int? categoryId, int page = 1, int count = 10)
        {
            if (page < 1) page = 1;
            var model = await _postGroupService.GetPostModel(categoryId, page, count);
            model.Posts = model.Posts.OrderBy(x => x.CreateDateTime).Reverse().ToList();
            return View(model);
        }
        //[Route("Blog/Index2/{*catName}")]
        //public async Task<IActionResult> Index2(string catName, int page = 1, int count = 10)
        //{
        //    var catNames = catName.Replace("%2F", "/").Split('/');
        //    var category = await _postGroupService.GetCatByName(catNames);
        //    var model = await _postGroupService.GetPostModel(category?.Id, page, count);
        //    model.Posts = model.Posts.OrderBy(x => x.CreateDateTime).Reverse().ToList();
        //    return View("Index", model);
        //}
        [Route("Blog/Item/{postId}")]
        public async Task<IActionResult> Item(int postId)
        {
            var model = await _postService.GetPostModel(postId);

            return PostItem(model);
        }

        [Route("Blog/Post/{postUrl}")]
        public async Task<IActionResult> Post(string postUrl)
        {
            var model = await _postService.GetPostModel(postUrl);
            return PostItem(model);
        }



        [Route("Blog/Tag/{tagName}")]
        public async Task<IActionResult> Tag(string tagName, int page = 1, int count = 10)
        {
            tagName = tagName.Replace('-', ' ');
            var tag = await _tagService.GetTagByName(tagName);
            var model = await _postService.GetPostsByTag(tag?.Id, page, count);
            model.Posts = model.Posts.OrderBy(x => x.UpdateDateTime).Reverse().ToList();
            return View("Index", model);
        }

        public async Task<IActionResult> AddComment(PostCommentModel model)
        {
            if (User.Identity == null) return NotFound();
            var user = await _applicationUserManager.FindAsync(User.Identity.Name);
            if (user == null) return NotFound();
            var entity = model.ToEntity();
            entity.OwnerId = user.Id;
            entity.IsAccepted = false;
            await _postCommentService.InsertAsync(entity);
            HttpContext.Response.Cookies.Append("BlogMessage", "نظر پس از تایید ادمین افزوده خواهد شد.");
            return RedirectToAction("Item", new { postId = model.PostId });
            //return await Item(model.PostId);
        }
        #endregion
        #region Utilities

        private IActionResult PostItem(PostModel model)
        {
            if (model == null) return NotFound();
            if (HttpContext.Request.Cookies.ContainsKey("BlogMessage"))
            {
                model.MessageText = HttpContext.Request.Cookies["BlogMessage"].ToString();
                HttpContext.Response.Cookies.Delete("BlogMessage");
            }

            return View("Item", model);
        }


        #endregion
        #region Ctor

        public BlogController(IPostGroupService postGroupService, IPostService postService, ITagService tagService, IPostCommentService postCommentService, ApplicationUserManager applicationUserManager)
        {
            _postGroupService = postGroupService;
            _postService = postService;
            _tagService = tagService;
            _postCommentService = postCommentService;
            _applicationUserManager = applicationUserManager;
        }
        #endregion


    }
}
