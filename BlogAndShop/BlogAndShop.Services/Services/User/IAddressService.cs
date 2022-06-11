using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.User
{
    public interface IAddressService : IMainService<Address>
    {
        Task<List<Address>> GetUserAddresses(int userId);
    }
}
