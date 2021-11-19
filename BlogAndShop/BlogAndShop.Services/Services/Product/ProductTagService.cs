using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductTagService : MainServiceNonBaseEntity<ProductTag>, IProductTagService
    {
        #region Fields


        #endregion
        #region Methods


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