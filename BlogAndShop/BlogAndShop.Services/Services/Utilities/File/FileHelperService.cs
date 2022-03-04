using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace BlogAndShop.Services.Services.Utilities.File
{
    public class FileHelperService : IFileHelperService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<string> SaveFile(string folder, IFormFile file, IHostEnvironment hostEnvironment)
        {
            if (string.IsNullOrEmpty(folder)) folder = DateTime.Now.ToString("yyyyMMdd");
            var folderPath = $"/UploadedFiles/{folder}";
            var path = $"{hostEnvironment.ContentRootPath}/wwwroot/{folderPath}";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            var name = $"{DateTime.Now:yyMMddhhmm}_{file.FileName}";
            var finalPath = Path.Combine(path, name);
            await using FileStream fileStream = new FileStream(finalPath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            fileStream.Close();
            var normalPath = $"{folderPath}/{name}";
            Compress(normalPath, hostEnvironment);
            return normalPath;
        }

        public void Compress(string path, IHostEnvironment hostEnvironment)
        {
            //var fileName = hostEnvironment.ContentRootPath + "/wwwroot/UploadedFiles/MediaUpload/2021/04/Main-1.jpg";
            var file = LoadFile(path, hostEnvironment);
            if (file == null) return;
            var old = file.Length;

            try
            {
                var optimizer = new ImageOptimizer();
                optimizer.Compress(file);

                file.Refresh();
            }
            catch (Exception e)
            {
                //ignore
            }
            var newVal = file.Length;
            if (newVal != old)
            {

            }
        }

        public FileInfo LoadFile(string normalPath, IHostEnvironment hostEnvironment)
        {
            var path = hostEnvironment.ContentRootPath + "/wwwroot/" + normalPath;
            if (System.IO.File.Exists(path))
            {
                var file = new FileInfo(path);
                return file;
            }
            return null;
        }

        public string ConvertToWebp(string filePath, IHostEnvironment hostEnvironment)
        {
            var formatConvertor = new FormatConvertor();
            var finalPath = formatConvertor.ProcessConvertToWebp(filePath, "webp", hostEnvironment);
            return finalPath;
        }

        public void RemoveFile(string itemPath, IHostEnvironment hostEnvironment)
        {
            var path = hostEnvironment.ContentRootPath + "/wwwroot/" + itemPath;
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
        }


        public void AddDarianWaterMark(string itemPath, IHostEnvironment hostEnvironment)
        {
            var file = LoadFile(itemPath, hostEnvironment);
            //add water mark
        }


        /// <summary>
        /// بازگرداندن پشوند فایل
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFileExtension(string path)
        {
            var extension = Path.GetExtension(path);
            return extension;
        }

        /// <summary>
        /// بازگرداندن نوع فایل
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static FileType GetFileType(string path)
        {
            var extension = GetFileExtension(path);
            var fileType = FileType.Document;
            if (extension.Equals("bmp", StringComparison.OrdinalIgnoreCase)
                || extension.Equals("jpg", StringComparison.OrdinalIgnoreCase)
                || extension.Equals("jpeg", StringComparison.OrdinalIgnoreCase)
                || extension.Equals("gif", StringComparison.OrdinalIgnoreCase)
                || extension.Equals("png", StringComparison.OrdinalIgnoreCase)
                || extension.Equals(".bmp", StringComparison.OrdinalIgnoreCase)
                || extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
                || extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase)
                || extension.Equals(".gif", StringComparison.OrdinalIgnoreCase)
                || extension.Equals(".WebP", StringComparison.OrdinalIgnoreCase)
                || extension.Equals(".png", StringComparison.OrdinalIgnoreCase))
            {
                fileType = FileType.Image;
            }
            else if (extension.Equals("mp4", StringComparison.OrdinalIgnoreCase)
                     || extension.Equals("WMV", StringComparison.OrdinalIgnoreCase)
                     || extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase)
                     || extension.Equals(".WMV", StringComparison.OrdinalIgnoreCase))
            {
                fileType = FileType.Video;
            }
            else
            {
                fileType = FileType.Document;
            }

            return fileType;
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        #endregion

    }
}