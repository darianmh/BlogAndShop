using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.User.Identity
{
    public class ApplicationRoleStore : RoleStore<ApplicationRole, ApplicationDbContext, int>,
        IRoleStore<ApplicationRole>
    {
        public ApplicationRoleStore(ApplicationDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}