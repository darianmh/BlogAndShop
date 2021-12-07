using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.User
{
    public class ApplicationUserService : MainServiceNonBaseEntity<ApplicationUser>, IApplicationUserService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ApplicationUserService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}