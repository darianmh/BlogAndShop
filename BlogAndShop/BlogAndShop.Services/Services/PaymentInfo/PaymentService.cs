using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public class PaymentService : MainService<Payment>, IPaymentService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public PaymentService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}