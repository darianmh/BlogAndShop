using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public class CartItemService : MainService<CartItem>, ICartItemService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public CartItemService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}