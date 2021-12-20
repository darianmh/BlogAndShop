

using System;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PostInfo;
using Microsoft.AspNetCore.Mvc;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Utilities;

namespace BlogAndShop.Controllers.Admin.PostInfo
{
    [AdminFilterName(AdminControllerNames.PostInfo, "پست ها")]
    public class PostController : BaseAdminController
    {
        #region Fields

        private readonly IPostService _service;
        private readonly IPost_TagsService _postTagsService;
        private readonly IPost_PostGroupService _postPostGroupService;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<PostModel, Post>(all, page, count);
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            model.Post_Tags = await _postTagsService.GetPostTagsModel(id);
            model.SelectedTags = model.Post_Tags.Select(x => x.TagId).ToList();
            model.Post_PostGroups = await _postPostGroupService.GetPostGroupsModel(id);
            model.SelectedGroups = model.Post_PostGroups.Select(x => x.GroupId).ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new PostModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetByIdAsync(id);
            var model = item.ToModel();
            model.Post_Tags = await _postTagsService.GetPostTagsModel(id);
            model.SelectedTags = model.Post_Tags.Select(x => x.TagId).ToList();
            model.Post_PostGroups = await _postPostGroupService.GetPostGroupsModel(id);
            model.SelectedGroups = model.Post_PostGroups.Select(x => x.GroupId).ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostModel model)
        {
            if (!ModelState.IsValid) return View(model);
            model.OwnerId = await GetUserId();
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            await _postTagsService.SetPostTags(item.Id, model.SelectedTags);
            await _postPostGroupService.SetPostGroups(item.Id, model.SelectedGroups);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = item.Id });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PostModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            await _postTagsService.SetPostTags(model.Id, model.SelectedTags);
            await _postPostGroupService.SetPostGroups(model.Id, model.SelectedGroups);
            CacheHelper.ClearCache();
            return RedirectToAction("Details", new { id = model.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var item = await _service.DeleteAsync(id);
                CacheHelper.ClearCache();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public PostController(IPostService service, IPost_TagsService postTagsService, IPost_PostGroupService postPostGroupService, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
            _postTagsService = postTagsService;
            _postPostGroupService = postPostGroupService;
        }
        #endregion


    }
}
