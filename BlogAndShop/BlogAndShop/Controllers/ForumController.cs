using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.User.Identity;

namespace BlogAndShop.Controllers
{
    public class ForumController : MainBaseController
    {
        #region Fields

        private readonly IForumTitleService _forumTitleService;
        private readonly IForumGroupService _forumGroupService;
        private readonly IForumCommentService _forumCommentService;
        private readonly ApplicationUserManager _applicationUserManager;


        #endregion
        #region Methods
        public async Task<IActionResult> Index(int? forumGroupId, int page = 1, int count = 10)
        {
            if (page < 1) page = 1;
            var model = await _forumGroupService.GetForumModel(forumGroupId, page, count);
            return View(model);
        }

        public async Task<IActionResult> Item(int id)
        {
            var forumTitle = await _forumTitleService.GetByIdAsync(id);
            if (forumTitle == null) return NotFound();
            var group = await _forumGroupService.GetByIdInModel(forumTitle.ForumGroupId);
            var forumTitleModel = forumTitle.ToModel();
            forumTitleModel.ForumComments = await _forumCommentService.GetAcceptedCommentsByTitleInModel(forumTitle.Id, _applicationUserManager);
            var model = new ForumItemViewModel()
            {
                Group = group,
                ForumTitleModel = forumTitleModel
            };
            return View(model);
        }


        public IActionResult Faq()
        {
            return View();
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ForumController(IForumTitleService forumTitleService, IForumGroupService forumGroupService, IForumCommentService forumCommentService, ApplicationUserManager applicationUserManager)
        {
            _forumTitleService = forumTitleService;
            _forumGroupService = forumGroupService;
            _forumCommentService = forumCommentService;
            _applicationUserManager = applicationUserManager;
        }

        #endregion


    }
}
