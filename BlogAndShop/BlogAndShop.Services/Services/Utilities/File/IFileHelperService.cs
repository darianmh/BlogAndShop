using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace BlogAndShop.Services.Services.Utilities.File
{
    public interface IFileHelperService
    {
        Task<string> SaveFile(string folder, IFormFile file, IHostEnvironment hostEnvironment);
        void RemoveFile(string itemPath, IHostEnvironment hostEnvironment);
        void Compress(string path, IHostEnvironment hostEnvironment);
        FileInfo LoadFile(string normalPath, IHostEnvironment hostEnvironment);

        /// <summary>
        /// تبدیل فایل به وبپی و بازگرداندن آدرس جدید آن
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="hostEnvironment1"></param>
        /// <returns></returns>
        string ConvertToWebp(string filePath, IHostEnvironment hostEnvironment1);
        /// <summary>
        /// بالا سمت راست هر عکس یک واترمارک اضافه می کند
        /// </summary>
        /// <param name="itemPath"></param>
        /// <param name="hostEnvironment"></param>
        void AddDarianWaterMark(string itemPath, IHostEnvironment hostEnvironment);
    }
}