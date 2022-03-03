using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using ImageProcessor.Plugins.WebP.Imaging.Formats;
using Microsoft.Extensions.Hosting;

namespace BlogAndShop.Services.Services.Utilities.File
{
    public class FormatConvertor
    {
        #region Fields


        #endregion

        #region Methods

        /// <summary>
        /// فایل دریفاتی را به فرمت خواسته شده تبدیل می کند
        /// اگر تبدیل کردن امکان پذیر نبود
        /// همان فایل اصلی را بر میگرداند
        /// </summary>
        /// <param name="filePath">فایل ورودی</param>
        /// <param name="outExt">فرمت خروجی</param>
        /// <param name="hostEnvironment"></param>
        /// <returns></returns>
        public string ProcessConvertToWebp(string filePath, string outExt, IHostEnvironment hostEnvironment)
        {
            var webpFileName = filePath.Replace('.', '_') + "." + outExt;
            var path = hostEnvironment.ContentRootPath + "/wwwroot/" + filePath;
            var savePath = hostEnvironment.ContentRootPath + "/wwwroot/" + webpFileName;
            using (Image image = Image.FromFile(path))
            {
                WebPFormat format = new WebPFormat();
                format.Save(savePath, image, 1);
            }

            return webpFileName;
        }



        #endregion
        #region Utilities


        #endregion
        #region Ctor

        #endregion
    }
}
