using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common.Search;

namespace BlogAndShop.Services.Services.Common.Search
{
    public interface ISearchService
    {
        /// <summary>
        /// جستجو بر اساس یک جمله
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<SearchResultModel> Search(string key);
        /// <summary>
        /// جستجو بر اساس چند کلمه
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        Task<SearchResultModel> Search(string[] keys);
    }
}