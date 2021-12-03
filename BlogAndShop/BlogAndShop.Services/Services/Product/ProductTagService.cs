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


        public async Task<List<int>> GetByProductId(int id)
        {
            return await Queryable.Where(x => x.ProductId == id).Select(x => x.TagId).ToListAsync();
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ProductTagService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion

    }
}