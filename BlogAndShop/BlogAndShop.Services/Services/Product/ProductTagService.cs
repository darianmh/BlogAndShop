using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductTagService : MainServiceNonBaseEntity<ProductTag>, IProductTagService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<List<ProductTag>> GetProductTags(int id)
        {
            return await Queryable.Where(x => x.ProductId == id).ToListAsync();
        }

        public async Task<List<int>> GetByProductId(int id)
        {
            var tags = await GetProductTags(id);
            return tags.Select(x => x.TagId).ToList();
        }

        public async Task SetProductTag(int modelId, List<int> selectedTags)
        {

            var tags = await GetProductTags(modelId);
            await DeleteAsync(tags);
            if (selectedTags == null) return;
            await CreateTags(modelId, selectedTags);
        }

        #endregion
        #region Utilities
        private async Task CreateTags(int productId, List<int> selectedTags)
        {
            selectedTags = selectedTags.GroupBy(x => x).Select(x => x.First()).ToList();
            var tags = new List<ProductTag>();
            foreach (var selectedTag in selectedTags)
            {
                var temp = new ProductTag()
                {
                    ProductId = productId,
                    TagId = selectedTag
                };
                tags.Add(temp);
            }

            await InsertAsync(tags);
        }

        #endregion
        #region Ctor
        public ProductTagService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion

    }
}