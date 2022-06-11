using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Product;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.Product
{
    public class ProductCommentService : MainService<ProductComment>, IProductCommentService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ProductCommentService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}