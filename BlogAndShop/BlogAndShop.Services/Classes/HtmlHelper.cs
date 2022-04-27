using System;
using System.Threading.Tasks;
using BlogAndShop.Services.Services.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogAndShop.Services.Classes
{
    public static class HtmlHelper
    {
        #region Fields


        #endregion
        #region Methods

        public static async Task<string> GetMediaPath(this IHtmlHelper helper, object imageId)
        {
            var defaultImagePath = "";
            var check = Int32.TryParse(imageId?.ToString(), out int id);
            if (!check) return defaultImagePath;
            var mediaService =
                (IMediaService)helper.ViewContext.HttpContext.RequestServices.GetService(
                    typeof(IMediaService));
            if (mediaService == null) return defaultImagePath;
            defaultImagePath = await mediaService.GetMediaPath(id);
            return "https://darianteam.ir/" + defaultImagePath;
        }


        #endregion
        #region Utilities


        #endregion
        #region Ctor

        #endregion
    }
}