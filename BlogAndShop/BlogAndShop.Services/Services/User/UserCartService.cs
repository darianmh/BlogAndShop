using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.User
{
    public class UserCartService : MainService<UserCart>, IUserCartService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public UserCartService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}