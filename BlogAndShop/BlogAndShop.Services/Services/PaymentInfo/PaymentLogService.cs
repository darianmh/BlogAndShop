using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.PaymentInfo
{
    public class PaymentLogService : MainService<PaymentLog>, IPaymentLogService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public PaymentLogService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}