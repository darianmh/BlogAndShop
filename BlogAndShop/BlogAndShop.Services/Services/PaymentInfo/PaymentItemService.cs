using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public class PaymentItemService : MainService<PaymentItem>, IPaymentItemService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public PaymentItemService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}