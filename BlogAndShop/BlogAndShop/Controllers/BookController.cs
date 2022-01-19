using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PostInfo;
using BlogAndShop.Services.Services.Product;
using BlogAndShop.Services.Services.User.Identity;

namespace BlogAndShop.Controllers
{
    public class BookController : MainBaseController
    {
        #region Fields

        private readonly IDownloadItemService _downloadItemService;



        #endregion
        #region Methods

        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            if (page < 1) page = 1;
            var model = await _downloadItemService.GetItemsModel(page, count);
            model.Posts = model.Posts.OrderBy(x => x.UpdateDateTime).Reverse().ToList();
            return View(model);
        }
        [Route("Book/Item/{postId}")]
        public async Task<IActionResult> Item(int postId)
        {
            var model = await _downloadItemService.GetItemModel(postId);
            return View(model);
        }


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public BookController(IDownloadItemService downloadItemService)
        {
            _downloadItemService = downloadItemService;
        }

        #endregion


    }
}
