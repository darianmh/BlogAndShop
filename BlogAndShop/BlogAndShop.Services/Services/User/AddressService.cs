using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.User
{
    public class AddressService : MainService<Address>, IAddressService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public AddressService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion
    }
}