using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.User
{
    public class RoleAccessService : MainService<RoleAccess>, IRoleAccessService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public RoleAccessService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}