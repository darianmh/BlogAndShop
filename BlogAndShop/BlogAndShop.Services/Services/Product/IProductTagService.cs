using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.Product
{
    public interface IProductTagService : IMainService<ProductTag>
    {
        Task<List<ProductTag>> GetProductTags(int id);
        Task<List<int>> GetByProductId(int id);
        Task SetProductTag(int modelId, List<int> modelSelectedTags);
    }
}
