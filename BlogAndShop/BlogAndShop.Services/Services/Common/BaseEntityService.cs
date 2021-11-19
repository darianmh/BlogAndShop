using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.Common
{
    public class BaseEntityService : MainService<BaseEntity>, IBaseEntityService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public BaseEntityService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}