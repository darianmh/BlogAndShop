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
    }
}