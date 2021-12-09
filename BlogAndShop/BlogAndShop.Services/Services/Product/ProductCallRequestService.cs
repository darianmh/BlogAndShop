using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductCallRequestService : MainService<ProductCallRequest>, IProductCallRequestService
    {

        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ProductCallRequestService(ApplicationDbContext db) : base(db)
        {

        }
        #endregion

    }
}