using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.User
{
    public class NewsLetterEmailService : MainService<NewsLetterEmail>, INewsLetterEmailService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public NewsLetterEmailService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}