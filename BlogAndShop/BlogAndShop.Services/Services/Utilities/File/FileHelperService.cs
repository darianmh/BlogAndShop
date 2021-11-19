using System;
using System.IO;
using System.Threading.Tasks;
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
            return $"{folderPath}/{name}";
        }

        public void RemoveFile(string itemPath, IHostEnvironment hostEnvironment)
        {
            var path = hostEnvironment.ContentRootPath + "/wwwroot/" + itemPath;
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor

        #endregion

    }
}