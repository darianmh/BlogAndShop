using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.User
{
    public class AddressService : MainService<Address>, IAddressService
    {
        #region Fields


        #endregion
        #region Methods


        public async Task<List<Address>> GetUserAddresses(int userId)
        {
            var result = await Queryable.Where(x => x.OwnerId == userId).ToListAsync();
            return result;
        }
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