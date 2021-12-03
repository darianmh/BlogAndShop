using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public interface IProductTagService : IMainService<ProductTag>
    {
        Task<List<int>> GetByProductId(int id);
    }
}
