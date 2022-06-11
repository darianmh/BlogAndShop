using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Common.SenderServices;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using CommonConfiguration.Core.Controllers;
using CommonConfiguration.Core.Data.Classes;
using CommonConfiguration.Core.Data.ViewModel.Common;

namespace BlogAndShop.Controllers
{
    public class AjaxService : MainBaseController
    {
        #region Fields

        private readonly IMediaService _mediaService;
        private readonly IProductCallRequestService _productCallRequestService;
        private readonly ISendService _sendService;
        private readonly IForumCommentService _forumCommentService;


        #endregion
        #region Methods

        public async Task<IActionResult> LoadImages(int page = 1, int count = 10)
        {
            var all = await _mediaService.GetAllAsync();
            var result = all.OrderBy(x => x.CreateDateTime).Reverse().Skip((page - 1) * count).Take(count).Select(x => x.ToModel()).Where(x => x.FileType == FileType.Image).ToList();
            return View(result);
        }

        [HttpPost]
        public async Task<ApiJsonResult<string>> AddCallRequest([FromForm] ProductCallRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return ReturnErrorJsonResult<string>("اطلاعات کامل نمی باشد");
            }

            model.UserId = await GetUserId();
            model.MessageStatus = MessageStatus.New;
            var item = model.ToEntity();
            var check = await _productCallRequestService.CreateNew(item);
            if (check)
            {
                var adminLink = $"<a href='https://{HttpContext.Request.Host.Value}/ProductCallRequest/Details/{item.Id}'>لینک اطلاعات</a>";
                await _sendService.SendNotification($"سفارش تماس جدید در سیستم ثبت شد. اطلاعات بیشتر :{adminLink}", "سفارش تماس جدید");
                return ReturnJsonResult("");
            }
            return ReturnErrorJsonResult<string>("مشکلی پیش آمد.");

        }
        [HttpPost]
        public async Task<ApiJsonResult<string>> CreateComment(ForumCommentModel model)
        {
            if (User.Identity == null || !User.Identity.IsAuthenticated)
            {
                return ReturnErrorJsonResult<string>("ابتدا باید وارد شوید.");
            }
            model.UserId = await GetUserId();
            var entity = model.ToEntity();
            entity.IsAccepted = false;
            entity.MessageStatus = MessageStatus.New;
            await _forumCommentService.InsertAsync(entity);
            return ReturnJsonResult("");
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public AjaxService(IMediaService mediaService, IProductCallRequestService productCallRequestService, ISendService sendService, IForumCommentService forumCommentService)
        {
            _mediaService = mediaService;
            _productCallRequestService = productCallRequestService;
            _sendService = sendService;
            _forumCommentService = forumCommentService;
        }

        #endregion

    }
}
