using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Common;
using BlogAndShop.Services.Services.Mapper;

namespace BlogAndShop.Controllers
{
    public class AjaxService : Controller
    {
        #region Fields

        private readonly IMediaService _mediaService;

        #endregion
        #region Methods

        public async Task<IActionResult> LoadImages(int page = 1, int count = 10)
        {
            var all = await _mediaService.GetAllAsync();
            var result = all.OrderBy(x => x.CreateDateTime).Reverse().Skip((page - 1) * count).Take(count).Select(x => x.ToModel()).Where(x => x.FileType == FileType.Image).ToList();
            return View(result);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public AjaxService(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        #endregion

    }
}
