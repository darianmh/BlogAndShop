using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common.Search;
using BlogAndShop.Services.Services.Forum;
using BlogAndShop.Services.Services.PostInfo;
using BlogAndShop.Services.Services.Product;

namespace BlogAndShop.Services.Services.Common.Search
{
    public class SearchService : ISearchService
    {
        #region Fields

        private readonly IPostService _postService;
        private readonly IProductService _productService;
        private readonly IForumTitleService _forumTitleService;

        #endregion
        #region Methods

        public async Task<SearchResultModel> Search(string key)
        {
            var keys = key.Split(' ');
            var result = await Search(keys);
            result.Key = key;
            return result;
        }

        public async Task<SearchResultModel> Search(string[] keys)
        {
            var results = new List<SearchResultModel>();
            foreach (var key in keys)
            {
                var temp = await SearchWithOneKey(key);
                results.Add(temp);
            }
            return CombineResult(results);
        }


        #endregion
        #region Utilities

        private async Task<SearchResultModel> SearchWithOneKey(string key)
        {
            var blog = await _postService.Search(key);
            var shop = await _productService.Search(key);
            var forum = await _forumTitleService.Search(key);
            return CreateSearchResult(blog, shop, forum, key);
        }

        private SearchResultModel CreateSearchResult(List<SearchResultItemModel> blog, List<SearchResultItemModel> shop, List<SearchResultItemModel> forum, string key)
        {

            var items = new List<SearchResultItemModel>();
            items.AddRange(blog);
            items.AddRange(shop);
            items.AddRange(forum);
            return new SearchResultModel()
            {
                Items = items,
                BlogCount = blog.Count,
                ForumCount = forum.Count,
                ShopCount = shop.Count,
                Key = key
            };
        }

        private SearchResultModel CombineResult(List<SearchResultModel> results)
        {
            return new SearchResultModel()
            {
                Items = results.SelectMany(x => x.Items).ToList(),
                BlogCount = results.Sum(x => x.BlogCount),
                ForumCount = results.Sum(x => x.ForumCount),
                ShopCount = results.Sum(x => x.ShopCount),
                Key = string.Join(' ', results.Select(x => x.Key))
            };
        }


        #endregion
        #region Ctor

        public SearchService(IPostService postService, IProductService productService, IForumTitleService forumTitleService)
        {
            _postService = postService;
            _productService = productService;
            _forumTitleService = forumTitleService;
        }
        #endregion

    }
}