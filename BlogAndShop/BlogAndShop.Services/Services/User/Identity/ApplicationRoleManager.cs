using System.Collections.Generic;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace BlogAndShop.Services.Services.User.Identity
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole>
    {
        public ApplicationRoleManager(ApplicationRoleStore store, IEnumerable<IRoleValidator<ApplicationRole>> roleValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, ILogger<RoleManager<ApplicationRole>> logger) : base(store, roleValidators, keyNormalizer, errors, logger)
        {
        }
    }
}