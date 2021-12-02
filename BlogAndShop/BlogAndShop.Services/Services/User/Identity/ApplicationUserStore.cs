using System;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.User.Identity
{
    public class ApplicationUserStore : UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, int>,
        IUserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
        /// <summary>
        /// find user from phone or mobile or username
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> FindAsync(string name)
        {
            name = name.Trim();
            return Context.Users.AsEnumerable().FirstOrDefault(x =>
                (x.UserName != null && x.UserName.Equals(name, StringComparison.OrdinalIgnoreCase)) ||
                (x.Email != null && x.Email.Equals(name, StringComparison.OrdinalIgnoreCase)) ||
                (x.PhoneNumber != null && x.PhoneNumber.Equals(name, StringComparison.OrdinalIgnoreCase)));
        }
    }
}